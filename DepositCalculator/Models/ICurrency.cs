namespace DepositCalculator.Models;

public interface ICurrency
{
	string Name { get; set; }

	double AnnualInterestRate { get; set; }
}