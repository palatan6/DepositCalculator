using System.Collections.ObjectModel;
using DepositCalculator.Events;
using DepositCalculator.Models;

namespace DepositCalculator.ViewModels;

public class MainWindowViewModel : BindableBase
{
	private readonly IEventAggregator _eventAggregator;
	private double _depositAmount = 0;

	private double _term = 1;
	private double _expectedIncome;

	public ObservableCollection<CurrencyViewModel> AvailableCurrencies { get; private set; } = new ObservableCollection<CurrencyViewModel>();

	public ObservableCollection<PaymentMethodViewModel> AvailablePaymentMethods { get; private set; } = new ObservableCollection<PaymentMethodViewModel>();

	private CurrencyViewModel? SelectedCurrency => AvailableCurrencies.FirstOrDefault(c => c.IsSelected);
	private PaymentMethodViewModel? SelectedPaymentMethod => AvailablePaymentMethods.FirstOrDefault(p => p.IsSelected);

	public double DepositAmount
	{
		get => _depositAmount;
		set => SetProperty(ref _depositAmount, value, OnChanged);
	}

	public double Term
	{
		get => _term;
		set => SetProperty(ref _term, value, OnChanged);
	}

	public double ExpectedIncome
	{
		get => _expectedIncome;
		set => SetProperty(ref _expectedIncome, value);
	}

	public MainWindowViewModel(IEventAggregator eventAggregator)
	{
		_eventAggregator = eventAggregator;
		_eventAggregator.GetEvent<InputDataChangedEvent>().Subscribe(OnChanged);

		var currencyViewModels = new List<CurrencyViewModel>()
		{
			new(new Currency("EUR"), _eventAggregator) { IsSelected = true },
			new(new Currency("USD"), _eventAggregator),
			new(new Currency("UAH"), _eventAggregator)
		};

		AvailableCurrencies.AddRange(currencyViewModels);

		var paymentMethodsViewModels = new List<PaymentMethodViewModel>()
		{
			new(new PaymentMethod("Capitalization"), _eventAggregator) { IsSelected = true },
			new(new PaymentMethod("Monthly Payout"), _eventAggregator)
		};

		AvailablePaymentMethods.AddRange(paymentMethodsViewModels);
	}

	private void OnChanged()
	{
		if (SelectedPaymentMethod == null || SelectedCurrency == null)
		{
			ExpectedIncome = 0;

			return;
		}

		if (SelectedPaymentMethod.DisplayName == "Monthly Payout" )
		{
			var monthlyInterest = DepositAmount * (double)((SelectedCurrency.AnnualInterestRate/100) / 12);
			ExpectedIncome = monthlyInterest * Term;
		}
		else
		{
			ExpectedIncome = 100500;
		}

		
	}
}