using System.Collections.ObjectModel;
using DepositCalculator.Models;

namespace DepositCalculator.ViewModels;

public class MainWindowViewModel : BindableBase
{
	private double _depositAmount = 0;

	private double _term = 1;
	private double _expectedIncome;

	public ObservableCollection<ICurrency> AvailableCurrencies { get; private set; } = new ObservableCollection<ICurrency>();

	public ObservableCollection<IPaymentMethod> AvailablePaymentMethods { get; private set; } = new ObservableCollection<IPaymentMethod>();

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

	public MainWindowViewModel()
	{
		AvailableCurrencies.AddRange(new[]
			{ new Currency("EUR") { IsSelected = true }, new Currency("USD"), new Currency("UAH") });

		AvailablePaymentMethods.AddRange(new[]
			{ new PaymentMethod("Capitalization") { IsSelected = true }, new PaymentMethod("Monthly Payout") });
	}

	private void OnChanged()
	{
		var monthlyInterest = DepositAmount * (0.05 / 12);
		ExpectedIncome = monthlyInterest * Term;
	}
}