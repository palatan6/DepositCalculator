using DepositCalculator.Events;
using DepositCalculator.Models;

namespace DepositCalculator.ViewModels;

public class CurrencyViewModel : BindableBase
{
	private readonly IEventAggregator _eventAggregator;

	private bool _isSelected;

	public string DisplayName { get; private set; }

	public bool IsSelected
	{
		get => _isSelected;
		set => SetProperty(ref _isSelected, value, _eventAggregator.GetEvent<InputDataChangedEvent>().Publish);
	}

	public decimal AnnualInterestRate { get; private set; }

	public CurrencyViewModel(ICurrency currency, IEventAggregator eventAggregator)
	{
		_eventAggregator = eventAggregator;

		DisplayName = currency.Name;

		AnnualInterestRate = currency.AnnualInterestRate;
	}
}