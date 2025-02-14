using System;

namespace Verificación_de_Acceso
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombrecorrecto = "Usuario";
            String contraseñacorrecta = "102030";

            Console.Write("Ingrese su nombre de usuario:");
            string nombreUsuario = Console.ReadLine();

            Console.Write("Ingrese su contraseña:");
            string contrasena = Console.ReadLine();

            if (nombreUsuario == nombrecorrecto && contrasena == contraseñacorrecta)
            {
                Console.WriteLine("Acceso Concedido");
            }
            else if (nombreUsuario  == nombrecorrecto)
            {
                Console.WriteLine("Contraseña incorrecta");
            }
            else
            {
                Console.WriteLine("Usuario no registrado");
            }
        }
    }
}