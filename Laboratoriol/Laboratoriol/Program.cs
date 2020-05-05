using System;
using System.IO;
namespace Laboratoriol
{
    class Program
    {
        static Usuarios us = new Usuarios();
        static Inventario inv = new Inventario();
        static Factura fac = new Factura();
        static void Main(string[] args)
        {
            int opción = 0;
            char b = 'n';
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("                                         BIENVENIDO A LA EMPRESA LOS PATOS                    ");
            Console.WriteLine(" ");
            Console.WriteLine("Inicio de Sesión");
            Console.WriteLine(" ");
            Console.Write("Ingrese Usuario: ");
            Console.ReadLine();
            Console.Write("Ingrese contraseña: ");
            Console.ReadLine();
            Console.WriteLine("\n Bienvenido");

            while (b != 's')
            {
                Console.WriteLine(" \n Elija la opción que desea revisar ");
                Console.WriteLine(" \n 1. Usuarios \n 2. Inventario \n 3. Facturación ");
                Console.Write("\n Opcion: ");
                opción = int.Parse(Console.ReadLine());

                if (opción == 1)
                {
                    us.usuario();
                }

                else if (opción == 2)
                {
                    inv.inventario();
                }

                else if (opción == 3)
                {
                    fac.facturación();

                    fac.factura();
                }



                Console.Write("\n ¿Desea salir de la aplicación? [s/n]");
                b = char.Parse(Console.ReadLine());


            }







                Console.ReadKey();
        }
    }
}
