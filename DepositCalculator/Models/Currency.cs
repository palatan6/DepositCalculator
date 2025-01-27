namespace DepositCalculator.Models;

public class Currency : ICurrency
{
	public string Name { get; set; }

	public double AnnualInterestRate { get; set; }

	/// <param name="name">Currency name</param>
	/// <param name="annualInterestRate">Annual Interest Rate value in %</param>
	public Currency(string name, double annualInterestRate)
	{
		Name = name;
		AnnualInterestRate = annualInterestRate;
	}
}