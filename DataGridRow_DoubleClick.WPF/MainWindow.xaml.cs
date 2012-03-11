using System;
using System.Windows;
using System.Windows.Controls;
using DataGridRow_DoubleClick.WPF.ViewModels;

namespace DataGridRow_DoubleClick.WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		protected void OnMouseDoubleClick(object sender, EventArgs args)
		{
			var row = sender as DataGridRow;
			if (row != null && row.IsSelected)
			{
				var viewModel = (MainViewModel)DataContext;
				viewModel.CodeBehind.Edit();
			}
		}
	}
}
