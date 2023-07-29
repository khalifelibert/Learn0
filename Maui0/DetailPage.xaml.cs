using Maui0.ViewModel;

namespace Maui0;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm; 
	}
}