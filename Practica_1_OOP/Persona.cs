using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_OOP
{
    public class Persona 
    {
        // Atributos
        private string nombre;
        private int edad;
        private string ciudad;
        private DateTime fechaNacimiento;

        // Constructor
        public Persona(string nombre, int edad, string ciudad, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.ciudad = ciudad;
            this.fechaNacimiento = fechaNacimiento;
        }

        // Métodos
        public void MostrarInformacion()
        {
            Console.WriteLine("Mostrando Informacion");
            Console.WriteLine();
            Console.WriteLine("Nombre: " + nombre, "Edad: " + edad);
            Console.WriteLine("Fecha Nacimiento: "+ fechaNacimiento);
            Console.WriteLine("Ciudad de residencia: " + ciudad);
            //CalcularEdadXAnos();
            
        }

        public int CalcularEdadXAnos()
        {
            DateTime fechaActual = DateTime.Now;
            int edadXAnos = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual.Month < fechaNacimiento.Month ||
          (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edadXAnos--;
            }
            Console.WriteLine("Edad en años: " + edadXAnos);
            return edadXAnos;            
        }
    }
}
