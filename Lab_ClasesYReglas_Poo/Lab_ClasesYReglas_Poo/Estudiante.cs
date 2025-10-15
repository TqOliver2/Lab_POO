using System;
using System.Collections.Generic;

public class Estudiante : IMostrable
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Estudiante(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public Estudiante() { }

    public virtual void MostrarDatos()
    {
        Console.WriteLine($"Estudiante: {Nombre}, Edad: {Edad}");
    }
}
