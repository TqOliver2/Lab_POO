using System;

public class Materia : IMostrable
{
    public string Nombre { get; set; }
    public string Codigo { get; set; }

    public Materia(string nombre, string codigo)
    {
        Nombre = nombre;
        Codigo = codigo;
    }

    public Materia()
    {
        Nombre = "Sin nombre";
        Codigo = "N/A";
    }

    public void MostrarDatos()
    {
        Console.WriteLine("=== Datos de la materia ===");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Código: {Codigo}");
    }
}
