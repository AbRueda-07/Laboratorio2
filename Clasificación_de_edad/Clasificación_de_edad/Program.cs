using System;

namespace Clasificación_de_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            if (edad < 12)
            {
                Console.WriteLine("Niño");
            }
            else if (edad >= 12 && edad <= 17)
            {
                Console.WriteLine("Es un Adolescente");
            }
            else if (edad >= 18 && edad <= 59)
            {
                Console.WriteLine("Es un Adulto");
       
            }
            else
            {
                Console.WriteLine("Es un adulto mayor");
            }
        }
    }
}