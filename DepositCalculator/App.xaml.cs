﻿using System.Windows;
using DepositCalculator.Views;

namespace DepositCalculator
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : PrismApplication
	{
		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			
		}

		protected override Window CreateShell()
		{
			var w = Container.Resolve<MainWindow>();
			return w;
		}
	}

}
