namespace DepositCalculator.Models;

public interface ICurrency
{
	string Name { get; set; }

	decimal AnnualInterestRate { get; set; }
}