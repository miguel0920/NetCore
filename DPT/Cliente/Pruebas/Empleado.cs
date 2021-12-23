using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Pruebas
{
    class Empleado : Persona
    {
        public Empleado(string nombre, double edad, string profesion, double salario)
            : base(nombre, edad)
        {
            this.profesion = profesion;
            this.salario = salario;
        }

        private string profesion;
        private double salario;

        public string Profesion { get => profesion; set => profesion = value; }
        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                if (value >= 1000)
                {
                    salario = value;
                }
                else
                {
                    salario = 1000;
                }
            }
        }

        public void AsignarDatos(string nombre, double edad, string profesion, double salario)
        {
            Nombre = nombre;
            Edad = edad;
            Profesion = profesion;
            Salario = salario;
        }

        public void EmpleadoMuestra()
        {
            Mostrar();
            Console.WriteLine($"profesión: {profesion}, salario: {salario}");
        }
    }
}
