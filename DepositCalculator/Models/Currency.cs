namespace DepositCalculator.Models;

public class Currency : ICurrency
{
	public string DisplayName { get; set; }

	public bool IsSelected { get; set; }

	public decimal AnnualInterestRate { get; set; } = 5;

	public Currency( string displayName )
	{
		DisplayName = displayName;
	}
}