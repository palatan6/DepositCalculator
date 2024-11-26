using DepositCalculator.Models;

namespace DepositCalculator.Services;

public interface IDataProviderService
{
	IEnumerable<ICurrency> GetAvailableCurrencies();

	IEnumerable<IPaymentMethod> GetAvailablePaymentMethods();
}