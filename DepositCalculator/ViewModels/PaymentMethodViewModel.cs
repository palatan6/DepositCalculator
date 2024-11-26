using DepositCalculator.Events;
using DepositCalculator.Models;

namespace DepositCalculator.ViewModels;

public class PaymentMethodViewModel : BindableBase
{
	private readonly IEventAggregator _eventAggregator;

	private bool _isSelected;

	public string DisplayName { get; private set; }

	public bool IsSelected
	{
		get => _isSelected;
		set => SetProperty(ref _isSelected, value, _eventAggregator.GetEvent<InputDataChangedEvent>().Publish );
	}

	public PaymentMethodViewModel(IPaymentMethod paymentMethod, IEventAggregator eventAggregator )
	{
		_eventAggregator = eventAggregator;

		DisplayName = paymentMethod.Name;
	}
}