using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_OOP
{
    public class Estudiante : Persona
    {
        private string carrera;
        private string matricula;
        public Estudiante(string nombre, int edad, string ciudad, DateTime fechaNacimiento, string carrera, string matricula ) :
            base(nombre, edad, ciudad, fechaNacimiento)
        {
            this.carrera = carrera;
            this.matricula = matricula;
        }


        public void mostrarInfoEstudiante()
        {
            //Persona estudiante = new Persona("Manuel Lopez", 25, "Haina", new DateTime(1999, 02, 17));
            Console.WriteLine("Carrera: " + carrera);
            Console.WriteLine("Matricula: " +  matricula);

        }
    }
}
