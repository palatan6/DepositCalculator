using DepositCalculator.Models;

namespace DepositCalculator.Services;

public class DataProviderService : IDataProviderService
{
	private readonly List<ICurrency> _currencies = new()
		{ new Currency("EUR", 5), new Currency("USD", 6), new Currency("UAH", 10) };

	private readonly List<IPaymentMethod> _paymentMethods = new()
		{ new CapitalizationPaymentMethod(), new MonthlyPayoutPaymentMethod() };

	public IEnumerable<ICurrency> GetAvailableCurrencies()
	{
		return _currencies;
	}

	public IEnumerable<IPaymentMethod> GetAvailablePaymentMethods()
	{
		return _paymentMethods;
	}
}