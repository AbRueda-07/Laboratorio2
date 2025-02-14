using System;

namespace Verificación_de_Acceso
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombrecorrecto = "AranR";
            String contrasenacorrecta = "102030";

            while (true)
            {
                Console.Write("Ingrese su nombre de usuario:");
                string nombreUsuario = Console.ReadLine();

                if (nombreUsuario != nombrecorrecto)
                {
                    
                    Console.WriteLine("Usuario no registrado. Intente de nuevo.\n");
                    continue;
                    break;
                }

                 Console.Write("Ingrese su contraseña:");
                 string contrasena = Console.ReadLine();

                if (contrasena == contrasenacorrecta)

                {
                    Console.WriteLine("Acceso concedido.");
                    break;
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta. Intente de nuevo.\n");
                    break;
                }

            }
        }
    }
}