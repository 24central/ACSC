namespace ACSC;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Afterlogin), typeof(Afterlogin));
		Routing.RegisterRoute(nameof(AfterLoginUpdate), typeof(AfterLoginUpdate));
	}
}
