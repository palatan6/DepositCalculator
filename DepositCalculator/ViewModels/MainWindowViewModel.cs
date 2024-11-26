using System.Collections.ObjectModel;
using DepositCalculator.Events;
using DepositCalculator.Services;

namespace DepositCalculator.ViewModels;

public class MainWindowViewModel : BindableBase
{
	private readonly IDataProviderService _dataProviderService;
	private readonly IEventAggregator _eventAggregator;

	private double _depositAmount = 0;

	private double _term = 1;
	private double _expectedIncome;

	public ObservableCollection<CurrencyViewModel> AvailableCurrencies { get; private set; } = new();

	public ObservableCollection<PaymentMethodViewModel> AvailablePaymentMethods { get; private set; } = new();

	private PaymentMethodViewModel? SelectedPaymentMethod => AvailablePaymentMethods.FirstOrDefault(p => p.IsSelected);

	public CurrencyViewModel? SelectedCurrency => AvailableCurrencies.FirstOrDefault( c => c.IsSelected );

	public double DepositAmount
	{
		get => _depositAmount;
		set => SetProperty(ref _depositAmount, value, OnDataChanged);
	}

	public double Term
	{
		get => _term;
		set => SetProperty(ref _term, value, OnDataChanged);
	}

	public double ExpectedIncome
	{
		get => _expectedIncome;
		set => SetProperty(ref _expectedIncome, value);
	}

	public MainWindowViewModel(IDataProviderService dataProviderService, IEventAggregator eventAggregator)
	{
		_eventAggregator = eventAggregator;
		_eventAggregator.GetEvent<InputDataChangedEvent>().Subscribe(OnInputSelectionChanged);

		_dataProviderService = dataProviderService;

		InitializeAvailableCurrencies();
		InitializeAvailablePaymentMethods();
	}

	private void OnInputSelectionChanged()
	{
		RaisePropertyChanged(nameof(SelectedCurrency));

		OnDataChanged();
	}

	private void OnDataChanged()
	{
		if (SelectedPaymentMethod == null || SelectedCurrency == null)
		{
			ExpectedIncome = 0;

			return;
		}

		ExpectedIncome =
			SelectedPaymentMethod.PaymentMethod.CalculateExpectedIncome(DepositAmount,
				SelectedCurrency.AnnualInterestRate, Term);
	}

	private void InitializeAvailableCurrencies()
	{
		AvailableCurrencies.Clear();

		var currencyViewModels = _dataProviderService.GetAvailableCurrencies()
			.Select(c => new CurrencyViewModel(c, _eventAggregator)).ToList();

		var firstCurrency = currencyViewModels.FirstOrDefault();

		if (firstCurrency == null)
		{
			return;
		}

		firstCurrency.IsSelected = true;

		AvailableCurrencies.AddRange(currencyViewModels);
	}

	private void InitializeAvailablePaymentMethods()
	{
		AvailablePaymentMethods.Clear();

		var paymentMethodsViewModels = _dataProviderService.GetAvailablePaymentMethods()
			.Select(p => new PaymentMethodViewModel(p, _eventAggregator)).ToList();

		var firstPaymentMethod = paymentMethodsViewModels.FirstOrDefault();

		if (firstPaymentMethod == null)
		{
			return;
		}

		firstPaymentMethod.IsSelected = true;

		AvailablePaymentMethods.AddRange(paymentMethodsViewModels);
	}
}