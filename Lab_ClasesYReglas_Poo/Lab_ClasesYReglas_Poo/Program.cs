using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear y poblar la lista (Herencia + Polimorfismo)
        List<IMostrable> items = new List<IMostrable>
        {
            new Estudiante("Ana", 20),
            new Estudiante("Luis", 22),
            new EstudianteBecado("María", 21, 50),
            new Materia("Matemáticas", "MAT101"),
            new Materia("Programación", "PRO202"),
            new Materia("Historia", "HIS303"),
            new Calificacion("Matemáticas", 88.5),
            new Calificacion("Programación", 92.3),
            new Calificacion("Historia", 79.0)
        };

        double matriculaBase = 1000;

        // Recorrer la lista (Polimorfismo)
        foreach (IMostrable i in items)
        {
            i.MostrarDatos(); // Cada clase usa su propia versión de MostrarDatos()

            if (i is EstudianteBecado eb)
            {
                double conDescuento = eb.CalcularMatriculaConDescuento(matriculaBase);
                Console.WriteLine($"Matrícula con descuento: ${conDescuento:F2}");
            }

            Console.WriteLine("---------------------------------");
        }

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
