using System; // Permite el uso de funcionalidades básicas como Console.

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            int numeroEntero;
            double numeroDecimal;
            string texto;
            bool valorBooleano;

            // Solicitar valores al usuario
            Console.Write("Ingresa un número entero: ");
            numeroEntero = Convert.ToInt32(Console.ReadLine()); // Convierte la entrada en int

            Console.Write("Ingresa un número decimal: ");
            numeroDecimal = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada en double

            Console.Write("Ingresa un texto: ");
            texto = Console.ReadLine(); // Captura la cadena de texto

            Console.Write("Ingresa un valor booleano (true o false): ");
            valorBooleano = Convert.ToBoolean(Console.ReadLine()); // Convierte la entrada en bool

            // Mostrar valores ingresados
            Console.WriteLine("\nValores ingresados:");
            Console.WriteLine("Número entero: " + numeroEntero);
            Console.WriteLine("Número decimal: " + numeroDecimal);
            Console.WriteLine("Texto: " + texto);
            Console.WriteLine("Valor booleano: " + valorBooleano);
        }
    }
}
