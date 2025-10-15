using System;

public class EstudianteBecado : Estudiante
{
    public double PorcentajeBeca { get; set; }

    public EstudianteBecado(string nombre, int edad, double porcentajeBeca)
        : base(nombre, edad)
    {
        if (porcentajeBeca < 0) PorcentajeBeca = 0;
        else if (porcentajeBeca > 100) PorcentajeBeca = 100;
        else PorcentajeBeca = porcentajeBeca;
    }

    public double CalcularMatriculaConDescuento(double matriculaBase)
    {
        return matriculaBase * (1 - (PorcentajeBeca / 100.0));
    }

    public override void MostrarDatos()
    {
        Console.WriteLine($"Estudiante Becado: {Nombre}, Edad: {Edad}, Beca: {PorcentajeBeca}%");
    }
}
