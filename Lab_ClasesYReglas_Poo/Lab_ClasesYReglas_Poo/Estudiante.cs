using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ClasesYReglas_Poo
{
    internal class Estudiante
    {
        private string nombre;
        private string id;
        private string carrera;
        private List<Calificacion> calificaciones;

        public string Nombre { get; set; }
        public string Id { get; set; }
        public string Carrera { get; set; }
        public List<Calificacion> Calificaciones { get; set; }

        public Estudiante(string nombre, string id, string carrera)
        {
            this.nombre = nombre;
            this.id = id;
            this.carrera = carrera;
            this.calificaciones = new List<Calificacion>();
        }
        public Estudiante()
        {
            this.calificaciones = new List<Calificacion>();
        }

        public double CalcularPromedio()
        {
            if (calificaciones.Count == 0) return 0;

            double totalPonderado = 0;
            int totalCreditos = 0;

            foreach (var c in calificaciones)
            {
                totalPonderado += c.Nota * c.Materia.Creditos;
                totalCreditos += c.Materia.Creditos;
            }

            return totalCreditos > 0 ? totalPonderado / totalCreditos : 0;
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Carrera: {carrera}");
            Console.WriteLine($"Promedio: {CalcularPromedio():F2}");
        }


    }

}
