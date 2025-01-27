namespace DepositCalculator.Models;

public class CapitalizationPaymentMethod : IPaymentMethod
{
	public string Name => "Capitalization";

	/// <summary>
	/// <see href="https://en.wikipedia.org/wiki/Compound_interest#Periodic_compounding"/>>
	/// </summary>
	public double CalculateExpectedIncome(double depositAmount, double annualInterestRate, int term)
	{
		// nominal annual interest rate
		var r = annualInterestRate / 100;

		// compounding frequency. My assumption it's once perf month, so 12 times per year; 
		var n = 12;

		var t = term / 12;

		var finalAmount = depositAmount * Math.Pow(1 + r / n, t * n);

		return finalAmount - depositAmount;
	}
}