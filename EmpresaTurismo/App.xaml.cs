namespace EmpresaTurismo;

public partial class App : Application
{
 	public static DatosMock lRutas = new DatosMock();

	public App()
	{
		InitializeComponent();
		lRutas.Rellenar();
		
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}