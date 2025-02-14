using System;

class Program
{
    static void Main()
    {
        Console.Write("Íngrese el primer número entero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");

        if (num2 != 0)
        {
            Console.WriteLine($"División: {num1} / {num2} = {(float) num1 / num2}");
            Console.WriteLine($"Módulo: {num1} % {num2} = {num1 % num2}");
        }
        else
        {
            Console.WriteLine("No se puede dividir entre cero.");
        }

        Console.Write("\nIngrese un número decimal (double): ");
        double numDouble = double.Parse(Console.ReadLine());

        Console.Write("\nIngrese otro número decimal: ");
        double numDouble2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Suma: (double): {numDouble} + {numDouble2} = {numDouble  + numDouble2}");
        Console.WriteLine($"Resta: (double): {numDouble} - {numDouble2} = {numDouble - numDouble2}");
        Console.WriteLine($"Multiplicación: (double): {numDouble} * {numDouble2} = {numDouble * numDouble2}");
        Console.WriteLine($"División: (double): {numDouble} / {numDouble2} = {numDouble / numDouble2}");

        Console.Write("\nIngrese un número decimal (float): ");
        float numFloat = float.Parse(Console.ReadLine());

        Console.Write("Ingrese otro número decimal: ");
        float numFloat2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"Suma (float): {numFloat} + {numFloat2} = {numFloat + numFloat2}");
        Console.WriteLine($"Resta (float): {numFloat} - {numFloat2} = {numFloat - numFloat2}");
        Console.WriteLine($"Multiplicación (float): {numFloat} * {numFloat2} = {numFloat * numFloat2}");
        Console.WriteLine($"División (float): {numFloat} / {numFloat2} = {numFloat / numFloat2}");

        Console.Write("\nIngrese un número entero pequeño (Int16): ");
        short numShort = short.Parse(Console.ReadLine());

        Console.Write("Ingrese otro número entero pequeño: ");
        short numShort2 = short.Parse(Console.ReadLine());

        Console.WriteLine($"Suma (Int16): {numShort} + {numShort2} = {numShort + numShort2}");
        Console.WriteLine($"Resta (Int16): {numShort} - {numShort2} = {numShort - numShort2}");
        Console.WriteLine($"Multiplicación (Int16): {numShort} * {numShort2} = {numShort * numShort2}");
        Console.WriteLine($"División (Int16): {numShort} / {numShort2} = {numShort / numShort2}");

        Console.WriteLine("\nIngrese un número pequeño (byte, 0-255): ");
        byte numByte = byte.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese otro número pequeño: ");
        byte numByte2 = byte.Parse(Console.ReadLine());

        Console.WriteLine($"Suma (byte): {numByte} + {numByte2} = {numByte + numByte2}");
        Console.WriteLine($"Resta (byte): {numByte} - {numByte2} = {numByte - numByte2}");
        Console.WriteLine($"Multiplicación (byte): {numByte} * {numByte2} = {numByte * numByte2}");


        Console.WriteLine($"División (byte): {numByte} / {numByte2} = {(float)numByte / numByte2}");
    }
}