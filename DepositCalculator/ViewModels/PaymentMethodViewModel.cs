using DepositCalculator.Events;
using DepositCalculator.Models;

namespace DepositCalculator.ViewModels;

public class PaymentMethodViewModel(IPaymentMethod paymentMethod, IEventAggregator eventAggregator)
	: BindableBase
{
	private bool _isSelected;

	public string DisplayName { get; private set; } = paymentMethod.Name;

	public IPaymentMethod PaymentMethod { get; } = paymentMethod;

	public bool IsSelected
	{
		get => _isSelected;
		set => SetProperty(ref _isSelected, value, eventAggregator.GetEvent<InputSelectionChangedEvent>().Publish );
	}
}