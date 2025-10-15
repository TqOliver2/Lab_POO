using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class EstudianteBecado : Estudiante
{
    private double porcentajeBeca;

    public double PorcentajeBeca
    {
        get { return porcentajeBeca; }
        set
        {
            if (value < 0) porcentajeBeca = 0;
            else if (value > 100) porcentajeBeca = 100;
            else porcentajeBeca = value;
        }
    }

    public EstudianteBecado(string nombre, int edad, double porcentajeBeca): base(nombre, edad)
    {
        PorcentajeBeca = porcentajeBeca;
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
