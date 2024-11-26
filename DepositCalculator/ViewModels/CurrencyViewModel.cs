using DepositCalculator.Events;
using DepositCalculator.Models;

namespace DepositCalculator.ViewModels;

public class CurrencyViewModel(ICurrency currency, IEventAggregator eventAggregator) : BindableBase
{
	private bool _isSelected;

	public string DisplayName { get; private set; } = currency.Name;

	public bool IsSelected
	{
		get => _isSelected;
		set => SetProperty(ref _isSelected, value, eventAggregator.GetEvent<InputSelectionChangedEvent>().Publish);
	}

	public decimal AnnualInterestRate { get; private set; } = currency.AnnualInterestRate;
}