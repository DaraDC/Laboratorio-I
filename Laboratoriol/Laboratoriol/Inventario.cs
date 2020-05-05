using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratoriol
{
    class Inventario
    {
        static string tdt = "Inventario.txt";
        static FileStream Archivo;
        static StreamWriter Escribir;
        static StreamReader Leer;

        public void inventario()
        {
            int op = 0;
            Console.WriteLine("¿Que desea realizar?");
            Console.WriteLine("\n 1.Agregar nuevo producto\n 2.Actualizar producto");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                char d = 's';
                while (d != 'n')
                {
                    
                    Agregarproducto(Cargar("Producto "), Cargar("Cantidad "), Cargar("Precio "));

                    Console.Write(" \n ¿Desea agregar otro producto? [s/n] ");
                    d = char.Parse(Console.ReadLine());
                }
            }

            else if (op == 2)
            {
                Agregarproducto(Cargar("Producto "), Cargar("Cantidad a agregar "), Cargar("Precio "));
                Escribir = File.AppendText(tdt);
                Escribir.Close();
                Console.WriteLine("\n El producto se ha actualizado");
            }
        }
        public void inventario2()
        {
            char c = 's';
            while (c != 'n')
            {
                inicio();
                Agregarproducto(Cargar("Producto"), Cargar("Cantidad"), Cargar("Precio"));

                Console.Write(" \n ¿Desea agregar otro producto? [s/n] ");
                c = char.Parse(Console.ReadLine());
            }
        } 
        public void verinv()
        {
            Lectura2(tdt);
        }
        static void Agregarproducto(string Productos, string Cantidad, string Precio)
        {
            Escribir = File.AppendText(tdt);
            Escribir.WriteLine(Productos + " - " + Cantidad + " - " + Precio);
            Escribir.WriteLine(" ");
            Escribir.Close();
        }
        static string Cargar(string cargar)
        {
            Console.Write(" Ingrese " + cargar + " : ");
            return (Console.ReadLine());
        }

        static void inicio()
        {
            Escribir = File.AppendText(tdt);
            Escribir.WriteLine("Producto  -  Cantidad  -  Precio");
            Escribir.Close();
        }
        static string Lectura2(string Inventario)
        {
            string linea = " ";
            Archivo = new FileStream(Inventario, FileMode.Open, FileAccess.Read);
            Leer = new StreamReader(tdt);
            linea = Leer.ReadToEnd();
            Console.WriteLine(linea);
            Leer.Close();
            Archivo.Close();
            return linea;

        }

  
    }
}
