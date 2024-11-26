namespace DepositCalculator.Models;

public class PaymentMethod : IPaymentMethod
{
	public string Name { get; set; }

	public PaymentMethod( string name )
	{
		Name = name;
	}
}