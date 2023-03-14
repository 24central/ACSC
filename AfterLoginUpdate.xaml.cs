using ACSC.viewmodel;
using CommunityToolkit.Maui.Views;


namespace ACSC;

public partial class AfterLoginUpdate : ContentPage 
{
	public AfterLoginUpdate( AfterLoginUpdateVm vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
	private async void OnsaveClicked(object sender, EventArgs e)
	{
		await this.ShowPopup(new PopupPage()); 
	}
}