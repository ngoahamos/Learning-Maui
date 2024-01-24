using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ToDoMaui.ViewModel
{
	public partial class MainViewModel: ObservableObject
	{
		

		public MainViewModel()
		{
			Items = new ObservableCollection<string>();
		}

		[ObservableProperty]
		string text;

		[ObservableProperty]
		ObservableCollection<string> items;

		[RelayCommand]
		void AddTask()
		{
			if (string.IsNullOrEmpty(Text))
			{
				return;
			}

			Items.Add(Text);
			Text = string.Empty;
		}

		[RelayCommand]
		void DeleteTask(string s)
		{
			if (Items.Contains(s))
			{
				Items.Remove(s);
			}
		}
	}
}

