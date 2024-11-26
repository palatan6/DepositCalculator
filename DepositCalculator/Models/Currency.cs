namespace DepositCalculator.Models;

public class Currency : ICurrency
{
	public string Name { get; set; }

	public decimal AnnualInterestRate { get; set; } = 5;

	public Currency( string name )
	{
		Name = name;
	}
}