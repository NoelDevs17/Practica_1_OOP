// See https://aka.ms/new-console-template for more information
using Practica_1_OOP;
    
class Program { 
    static void Main(string[] args)
    {



        Console.WriteLine("Ingrese su fecha de nacimiento (dd/MM/yyyy): ");
        string fechaNacimientoString = Console.ReadLine();
        Console.WriteLine("Ingrese su Nombre Completo: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre de la ciudad donde vive: ");
        string ciudad = Console.ReadLine();
        DateTime fechaNacimiento = DateTime.ParseExact(fechaNacimientoString, "dd/MM/yyyy", null);

        Persona persona1 = new Persona(nombre, 22, ciudad, fechaNacimiento);

        //métodos de la clase "Persona"
        persona1.MostrarInformacion();

        int edadXAnos = persona1.CalcularEdadXAnos();
        Console.WriteLine("Edad en años: " + edadXAnos);

        // objeto de la clase "Persona"
        
    }

}
