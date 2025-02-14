// PROYECTO DECLARACION Y USO DE VARIABLES
using System; 

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numeroEntero;
            double numeroDecimal;
            string texto;
            bool valorBooleano;

            
            Console.Write("Ingresa un número entero: ");
            numeroEntero = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Ingresa un número decimal: ");
            numeroDecimal = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Ingresa un texto: ");
            texto = Console.ReadLine(); 

            Console.Write("Ingresa un valor booleano (true o false): ");
            valorBooleano = Convert.ToBoolean(Console.ReadLine()); 

           
            Console.WriteLine("\nValores ingresados:");
            Console.WriteLine("Número entero: " + numeroEntero);
            Console.WriteLine("Número decimal: " + numeroDecimal);
            Console.WriteLine("Texto: " + texto);
            Console.WriteLine("Valor booleano: " + valorBooleano);
        }
    }
}
