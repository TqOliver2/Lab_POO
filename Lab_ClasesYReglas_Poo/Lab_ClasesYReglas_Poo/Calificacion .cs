using System;

public class Calificacion : IMostrable
{
    public string Materia { get; set; }
    public double Nota { get; set; }

    public Calificacion(string materia, double nota)
    {
        Materia = materia;
        if (nota < 0) Nota = 0;
        else if (nota > 100) Nota = 100;
        else Nota = nota;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("=== Datos de la Calificación ===");
        Console.WriteLine($"Materia: {Materia}");
        Console.WriteLine($"Nota: {Nota}");
    }
}
