using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IMostrable
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Estudiante(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public virtual void MostrarDatos()
    {
        Console.WriteLine($"Estudiante: {Nombre}, Edad: {Edad}");
    }
}
