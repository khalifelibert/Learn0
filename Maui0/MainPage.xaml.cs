using Maui0.ViewModel;

namespace Maui0;

public partial class MainPage : ContentPage
{
	

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

