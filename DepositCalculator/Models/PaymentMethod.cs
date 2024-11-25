namespace DepositCalculator.Models;

public class PaymentMethod : IPaymentMethod
{
	public string DisplayName { get; set; }

	public bool IsSelected { get; set; }

	public PaymentMethod( string displayName )
	{
		DisplayName = displayName;
	}
}