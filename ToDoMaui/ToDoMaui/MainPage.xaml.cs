using ToDoMaui.ViewModel;

namespace ToDoMaui;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	
}


