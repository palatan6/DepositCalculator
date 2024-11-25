using System.Collections.ObjectModel;
using DepositCalculator.Models;

namespace DepositCalculator.ViewModels;

public class MainWindowViewModel : BindableBase
{
	public ObservableCollection<ICurrency> AvailableCurrencies { get; private set; } = new ObservableCollection<ICurrency>();

	public ObservableCollection<IPaymentMethod> AvailablePaymentMethods { get; private set; } = new ObservableCollection<IPaymentMethod>();

	public MainWindowViewModel()
	{
		AvailableCurrencies.AddRange(new[]
			{ new Currency("EUR") { IsSelected = true }, new Currency("USD"), new Currency("UAH") });

		AvailablePaymentMethods.AddRange(new[]
			{ new PaymentMethod("Capitalization") { IsSelected = true }, new PaymentMethod("Monthly Payout") });

	}
}