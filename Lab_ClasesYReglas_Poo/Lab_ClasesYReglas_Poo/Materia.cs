using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ClasesYReglas_Poo
{
    internal class Materia
    {
        private string nombre;
        private string codigo;
        private int creditos;
        private int cupos;
        private int inscritos;


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Creditos
        {
            get { return creditos; }
            set
            {
                if (value > 0)
                    creditos = value;
                else
                    creditos = 1; 
            }
        }

        public int Cupos
        {
            get { return cupos; }
            set
            {
                if (value >= 0)
                    cupos = value;
                else
                    cupos = 0;
            }
        }

        public int Inscritos
        {
            get { return inscritos; }
            set
            {
                if (value >= 0 && value <= cupos)
                    inscritos = value;
                else if (value < 0)
                    inscritos = 0;
                else
                    inscritos = cupos; 
            }
        }

        public Materia(string nombre, string codigo, int creditos, int cupos = 0, int inscritos = 0)
        {
            Nombre = nombre;
            Codigo = codigo;
            Creditos = creditos;
            Cupos = cupos;
            Inscritos = inscritos;
        }

        public Materia()
        {
            Nombre = "Sin nombre";
            Codigo = "N/A";
            Creditos = 1;
            Cupos = 0;
            Inscritos = 0;
        }

        public int CalcularCargaSemanal(int horasPorCredito)
        {
            return Creditos * horasPorCredito;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("=== Datos de la materia ===");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Créditos: {Creditos}");
            Console.WriteLine($"Cupos/Inscritos: {Inscritos}/{Cupos}");
        }
    }
}
