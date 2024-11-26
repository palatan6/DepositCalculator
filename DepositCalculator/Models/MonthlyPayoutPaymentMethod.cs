namespace DepositCalculator.Models;

public class MonthlyPayoutPaymentMethod : IPaymentMethod
{
	public string Name => "Monthly Payout";

	public double CalculateExpectedIncome(double depositAmount, decimal annualInterestRate, double term)
	{
		var monthlyInterest = depositAmount * (double)((annualInterestRate / 100) / 12);
		return monthlyInterest * term;
	}
}