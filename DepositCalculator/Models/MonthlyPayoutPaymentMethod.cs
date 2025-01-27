namespace DepositCalculator.Models;

public class MonthlyPayoutPaymentMethod : IPaymentMethod
{
	public string Name => "Monthly Payout";

	public double CalculateExpectedIncome(double depositAmount, double annualInterestRate, int term)
	{
		var monthlyInterest = depositAmount * ((annualInterestRate / 100) / 12);
		return monthlyInterest * term;
	}
}