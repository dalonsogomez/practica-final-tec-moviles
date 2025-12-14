namespace EmpresaTurismo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		
		// Registro de rutas para navegación jerárquica
		Routing.RegisterRoute(nameof(DetalleRuta), typeof(DetalleRuta));
	}
}
