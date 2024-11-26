using System.Windows;

namespace DepositCalculator.UserControls
{
	/// <summary>
	/// Interaction logic for NumericInput.xaml
	/// </summary>
	public partial class NumericInput
	{
		public static readonly DependencyProperty CaptionProperty = DependencyProperty.Register(
			nameof(Caption), typeof(string), typeof(NumericInput), new PropertyMetadata(default(string)));

		public static readonly DependencyProperty SublineProperty = DependencyProperty.Register(
			nameof(Subline), typeof(string), typeof(NumericInput), new PropertyMetadata(default(string)));

		public static readonly DependencyProperty HideUpDownButtonsProperty = DependencyProperty.Register(
			nameof(HideUpDownButtons), typeof(bool), typeof(NumericInput), new PropertyMetadata(default(bool)));

		public static readonly DependencyProperty MinimumProperty = DependencyProperty.Register(
			nameof(Minimum), typeof(decimal), typeof(NumericInput), new PropertyMetadata(default(decimal)));

		public static readonly DependencyProperty IsReadOnlyProperty = DependencyProperty.Register(
			nameof(IsReadOnly), typeof(bool), typeof(NumericInput), new PropertyMetadata(default(bool)));

		public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
			nameof(Value), typeof(double?), typeof(NumericInput), new PropertyMetadata(default(double?)));

		public string Caption
		{
			get => (string)GetValue(CaptionProperty);
			set => SetValue(CaptionProperty, value);
		}

		public string Subline
		{
			get => (string)GetValue( SublineProperty );
			set => SetValue( SublineProperty, value );
		}

		public bool HideUpDownButtons
		{
			get => (bool)GetValue( HideUpDownButtonsProperty );
			set => SetValue( HideUpDownButtonsProperty, value );
		}

		public decimal Minimum
		{
			get => (decimal)GetValue( MinimumProperty );
			set => SetValue( MinimumProperty, value );
		}

		public bool IsReadOnly
		{
			get => (bool)GetValue( IsReadOnlyProperty );
			set => SetValue( IsReadOnlyProperty, value );
		}

		public double? Value
		{
			get => (double?)GetValue( ValueProperty );
			set => SetValue( ValueProperty, value );
		}

		public NumericInput()
		{
			InitializeComponent();
		}
	}
}
