namespace DepositCalculator.Models;

public class Currency : ICurrency
{
	public string Name { get; set; }

	public decimal AnnualInterestRate { get; set; }

	/// <param name="name">Currency name</param>
	/// <param name="annualInterestRate">Annual Interest Rate value in %</param>
	public Currency(string name, decimal annualInterestRate)
	{
		Name = name;
		AnnualInterestRate = annualInterestRate;
	}
}