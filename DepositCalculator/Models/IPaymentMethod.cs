namespace DepositCalculator.Models;

public interface IPaymentMethod
{
	string Name { get; }

	double CalculateExpectedIncome(double depositAmount, decimal annualInterestRate, double term );
}