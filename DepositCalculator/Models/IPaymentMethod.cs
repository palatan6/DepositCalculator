namespace DepositCalculator.Models;

public interface IPaymentMethod
{
	string DisplayName { get; set; }

	bool IsSelected { get; set; }
}