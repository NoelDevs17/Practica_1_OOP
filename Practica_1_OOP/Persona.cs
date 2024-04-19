using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_OOP
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int  Edad { get; set; }
        public string  Ciudad { get; set; }
        public Persona(string nombre, int edad, string ciudad)
        {

            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;

        }

        Persona persona1 = new Persona("Genesis Santiago", 24, "San pedro de macoris");

        public void ShowInfoPerson() { 
            Console.WriteLine("Hola" + persona1.Nombre + "Tu Edad es: " + Edad + "y Perteneces a " + Ciudad);
        }
    }
}
