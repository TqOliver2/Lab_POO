class Program
{
    static void Main()
    {
        // AQUÍ SE CREA Y POBLA LA LISTA (HERENCIA + POLIMORFISMO)
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

        // AQUÍ SE RECORRE LA LISTA CON foreach (POLIMORFISMO)
        foreach (IMostrable i in items)
        {
            i.MostrarDatos(); // Cada objeto usa su propia versión de MostrarDatos()

            if (i is EstudianteBecado eb)
            {
                double conDescuento = eb.CalcularMatriculaConDescuento(matriculaBase);
                Console.WriteLine($"Matrícula con descuento: ${conDescuento:F2}");
            }

            Console.WriteLine("---------------------------------");
        }
    }
}
