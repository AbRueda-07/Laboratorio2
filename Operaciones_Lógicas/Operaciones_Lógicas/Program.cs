using System;

class Program

{
    static void Main()
    {
        Console.Write("\nIngrese el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("\nIngrese el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"\n¿ {num1} es mayor que {num2}? {num1 > num2}");
        Console.WriteLine($"\n¿ {num1} es menor que {num2}? {num1 < num2}");
        Console.WriteLine($"\n¿ {num1} es igual a {num2}? {num1 == num2}");

        bool andCondition = (num1 > 0) && (num2 > 0);
        bool orCondition = (num1 < 0) || (num2 < 0);

        Console.WriteLine($"\n¿Ambos números son positivos? {andCondition}");
        Console.WriteLine($"\n¿Al menos uno de los números es negativo? {orCondition}");

        bool condicionMayorMenor = (num1 > 10 && num2 < 50);
        bool condicionIgualdad = (num1 == num2);
       
        Console.WriteLine($"\n¿El primer número es mayor a 10 y el segundo es menor a 50? {condicionMayorMenor}");
        Console.WriteLine($"\n¿Ambos números son iguales? {condicionIgualdad}");


        Console.WriteLine("\nFin del programa");
        }
}