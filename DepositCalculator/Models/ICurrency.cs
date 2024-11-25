namespace DepositCalculator.Models;

public interface ICurrency
{
	string DisplayName { get; set; }

	bool IsSelected { get; set; }

	decimal AnnualInterestRate { get; set; }
}