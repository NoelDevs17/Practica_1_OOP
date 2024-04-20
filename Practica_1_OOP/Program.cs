// See https://aka.ms/new-console-template for more information
using Practica_1_OOP;
    
class Program {

    
    static void Main(string[] args)
    {

        string fechaNacimientoString;
        string nombre;
        string ciudad;
        DateTime fechaNacimiento;
        string carrera;
        string matricula;
        int edadXAnos;


        while (true) { 


        Console.WriteLine("Bienvenido, Elija la opcion que desea realizar: ");
        Console.WriteLine();  //salto de linea
        Console.WriteLine("Ingrese 1. Para crear y Ver informacion de una persona: ");
        Console.WriteLine("Ingrese 2. Para Crear y Ver informacion de un estudiante: ");
        Console.WriteLine("Ingrese 3. Salir del programa");

        string input = Console.ReadLine();

        int opcion;
        if (!int.TryParse(input, out opcion))
        {
            Console.WriteLine("Entrada inválida. Por favor, seleccione una opción válida.");
            return;
        }

        //Opciones
        switch (opcion)
        {
            case 1:
                Console.WriteLine();//salto de linea
                Console.WriteLine("Ha seleccionado la Opción 1");
                Console.WriteLine();//salto de linea

                Console.WriteLine("Ingrese su Nombre Completo: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su fecha de nacimiento separados por ( / ) ej: dd/MM/yyyy: ");
                fechaNacimientoString = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre de la ciudad donde vive: ");
                ciudad = Console.ReadLine();

                fechaNacimiento = DateTime.ParseExact(fechaNacimientoString, "dd/MM/yyyy", null);
                Persona persona1 = new Persona(nombre, 0, ciudad, fechaNacimiento);
                Console.Clear();
                //metodo para mostrar info de Persona
                persona1.MostrarInformacion();
                edadXAnos = persona1.CalcularEdadXAnos();
                Console.WriteLine();
                    break;
            case 2:
                Console.WriteLine("Ha seleccionado la Opción 2");
                Console.WriteLine(); //salto de linea

                Console.WriteLine("Ingrese su Nombre Completo: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su fecha de nacimiento separados por / (dd/MM/yyyy): ");
                fechaNacimientoString = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre de la ciudad donde vive: ");
                ciudad = Console.ReadLine();

                Console.WriteLine("Ingrese el nombre de la carrera que estudia: ");
                carrera = Console.ReadLine();

                Console.WriteLine("Ingrese su matricula: ");
                matricula = Console.ReadLine();

                fechaNacimiento = DateTime.ParseExact(fechaNacimientoString, "dd/MM/yyyy", null);
                Estudiante estudiante = new Estudiante(nombre, 0, ciudad, fechaNacimiento, carrera, matricula);
                Console.Clear();
                estudiante.MostrarInformacion();
                edadXAnos = estudiante.CalcularEdadXAnos();
                estudiante.mostrarInfoEstudiante();
                Console.WriteLine(); //salto de linea

                    break;

                    case 3:
                    return;

            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                break;
        }


        }

    }

}
