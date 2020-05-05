using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratoriol
{
    class Usuarios
    {
        static Inventario inv = new Inventario();
        static Factura fac = new Factura();

        static string tbt = "Usuarios.txt";
        static FileStream Archivo;
        static StreamWriter Escribir;
        static StreamReader Leer;

       
        public void usuario()
        {

            Console.WriteLine("\n Elija el rol que desempeña: ");
            Console.WriteLine(" ");
            Console.WriteLine(" 1. Administrador \n 2. Trabajador ");
            int rol = 0;
            Console.Write(" : ");
            rol = int.Parse(Console.ReadLine());

            if (rol == 1)
            {
                Console.WriteLine("\n Administrador. ");
                Console.WriteLine(" ");
                Console.WriteLine(" Elija la opción que desea realizar ");
                Console.WriteLine(" \n 1. Crear usuario\n 2. Ver Usuarios\n 3. Ver Inventario\n 4. Ver Facturas ");
                int Option = 0;
                Console.Write("\n Option: ");
                Option = int.Parse(Console.ReadLine());

                if (Option == 1)
                {
                    char a = 's';
                    while (a != 'n')
                    {
                        inicio();

                        AgregarUsuarios(Agregar("Usuario"), Agregar("Contraseña"), Agregar("Nombre"), Agregar("Apellido"), Agregar("Teléfono"), Agregar("Email"), Agregar("Rol"));

                        Console.Write(" \n ¿Desea agregar otro usuario? [s/n] ");
                        a = char.Parse(Console.ReadLine());
                    }

                }

                else if (Option == 2)
                {
                    Lectura1(tbt);
                }

                else if (Option == 3)
                {
                    inv.verinv();
                }

                else if (Option == 4)
                {
                    fac.verfac();
                }

            }

            else if (rol == 2)
            {
                Console.WriteLine("\n Trabajador ");
                Console.WriteLine(" ");
                Console.WriteLine(" Elija la opción que desea realizar ");
                Console.WriteLine(" \n 1. Cargar inventario\n 2. Facturar productos ");
                int Option = 0;
                Console.Write("\n Option: ");
                Option = int.Parse(Console.ReadLine());

                if (Option == 1)
                {
                    inv.inventario2();
                }

                else if (Option == 2)
                {
                    fac.facturar();
                }

            }


        }

        static void AgregarUsuarios(string Usuario, string Contraseña, string Nombre, string Apellido, string Teléfono, string Email, string Rol)
        {
            Escribir = File.AppendText(tbt);
            Escribir.WriteLine(Usuario + "  " + Contraseña + "  " + Nombre + "   " + Apellido + "   " + Teléfono + "   " + Email + " - " + Rol);
            Escribir.WriteLine(" ");
            Escribir.Close();
        }

        static string Agregar(string datos)
        {
            Console.Write(" Ingrese " + datos + " : ");
            return (Console.ReadLine());
        }

        static void inicio()
        {
            Escribir = File.AppendText(tbt);
            Escribir.WriteLine("Usuario - Contraseña - Nombre - Apellido - Teléfono - Email - Rol");
            Escribir.Close();
        }
        static string Lectura(string c)
        {
            string letter = " ";
            Archivo = new FileStream(c, FileMode.Open, FileAccess.Read);
            Leer = new StreamReader(Archivo);
            letter = Leer.ReadToEnd();
            Leer.Close();
            return letter;
        }
        static string Lectura1(string Usuarios)
        {
            string linea = " ";
            Archivo = new FileStream(Usuarios, FileMode.Open, FileAccess.Read);
            Leer = new StreamReader(tbt);
            linea = Leer.ReadToEnd();
            Console.WriteLine(linea);
            Leer.Close();
            return linea;

        }       

    }
}
