using ACSC.viewmodel;

namespace ACSC;

public partial class MainPage : ContentPage
{


	public MainPage(Mainviewmodel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	
}

