using ACSC.viewmodel;

namespace ACSC;

public partial class Afterlogin : ContentPage
{
	public Afterlogin( Afterlogviewmodel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}