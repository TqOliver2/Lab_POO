using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ClasesYReglas_Poo
{
    internal class Calificacion
    {
        private Estudiante estudiante;
        private Materia materia;
        private double nota;

        public Estudiante Estudiante
        {
            get { return estudiante; }
            set { estudiante = value; }
        }

        public Materia Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public double Nota
        {
            get { return nota; }
            set
            {
                if (value < 0)
                    nota = 0;
                else if (value > 100)
                    nota = 100;
                else
                    nota = value;
            }
        }

        public Calificacion(Estudiante estudiante, Materia materia, double nota)
        {
            Estudiante = estudiante;
            Materia = materia;
            Nota = nota;
        }

        public double CalcularPuntos()
        {
            return Nota * Materia.Creditos;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("=== Datos de la Calificación ===");
            Console.WriteLine($"Estudiante: {Estudiante.Nombre}");
            Console.WriteLine($"Materia: {Materia.Nombre}");
            Console.WriteLine($"Nota: {Nota}");
        }
    }
}
