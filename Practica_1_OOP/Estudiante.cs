using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_OOP
{
    public class Estudiante : Persona
    {
        public string Carrera { get; set; }
        public string Matricula { get; set; }
        public Estudiante(string nombre, int edad, string ciudad, DateTime fechaNacimiento, string carrera, string matricula ) : base(nombre, edad, ciudad, fechaNacimiento)
        {
            Carrera = carrera;
            Matricula = matricula;
        }


        public void mostrarInfoEstudiante()
        {
            //Persona estudiante = new Persona("Manuel Lopez", 25, "Haina", new DateTime(1999, 02, 17));
            Console.WriteLine("Carrera: " + Carrera);
            Console.WriteLine("Matricula: " +  Matricula);

        }
    }
}
