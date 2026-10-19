using System.Text.Json;

namespace Persistencia.Pages;

public partial class Fichero : ContentPage
{
	public Fichero()
	{
		InitializeComponent();
		cargarAlumnos();
	}
	private void cargarAlumnos()
	{
		List<Alumnos>lista=new List<Alumnos>();
		lista.Add(new Alumnos { nombre = "Beatriz", apellido = "Martinez", edad = 25 });
        lista.Add(new Alumnos { nombre = "Marta", apellido = "Martin", edad = 22 });
        lista.Add(new Alumnos { nombre = "Ivan", apellido = "Garcia", edad = 19 });
		string path = FileSystem.AppDataDirectory;
		String fichero = Path.Combine(path, "alumnos.json");
		String json = JsonSerializer.Serialize(lista);
		File.WriteAllText(fichero, json);
    }
}