using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laboratoriol
{
    class Factura
    {
        static string trt = "Facturas.txt";
        static FileStream Archivo;
        static StreamWriter Escribir;
        static StreamReader Leer;

        static double C;
        static double P;
        static double Sub = 0;

        public void facturar()
        {
            char op = 's';

            double Total = 0;

            while (op != 'n')
            {

                Compras(Ingresar("Producto"));
                Sub = operacion(Precio(P), Cantidad(C));
                Escribir = File.AppendText(trt);
                Escribir.WriteLine("El subtotal es: Q" + Sub);
                Escribir.Close();
                Console.WriteLine("El subtotal es: Q" + Sub);
                Console.WriteLine("¿Desea realizar otra compra? [s/n]:");
                op = char.Parse(Console.ReadLine());
                Total = Total + Sub;
            }

            Escribir = File.AppendText(trt);
            Escribir.WriteLine("El total de la compra es: Q" + Total);
            Escribir.Close();
            Console.Write("El Total es: Q" + Total);
            Console.ReadLine();

        }

        public void facturación()
        {
            inicio1();
            Facturación(Ingresar("Correlativo de la factura"), Ingresar("Nombre del Cliente"), Ingresar("NIT "), Ingresar("Fecha"), Ingresar("Detalle de la compra"), Ingresar("Monto toal de la compra"));
            Console.WriteLine(" ");
            
        }

        public void verfac()
        {
            Lectura3(trt);
        }

        static double Precio(double datos)

        {
            Console.Write("Ingrese precio del Producto" + datos + " :" );
            return double.Parse(Console.ReadLine());

        }
        static string Ingresar(string datos)
        {
            Console.Write("Ingrese " + datos + " : ");
            return (Console.ReadLine());
        }
        
        static double Cantidad(double datos)
        {
            double x = 0;
            Console.Write("Ingrese la cantidad del producto a comprar" + datos + " : ");
            x = double.Parse(Console.ReadLine());
            return x;
        }
        static void Facturación(string Correlativo, string Nombre, string NIT, string Fecha, string Detalle, string Monto)
        {
            Escribir = File.AppendText(trt);
            Escribir.WriteLine(Correlativo + " - " + Nombre + " - " + NIT + " - " + Fecha + " - " + Detalle + " - " + Monto);
            Escribir.WriteLine(" ");
            Escribir.Close();
        }

        static void inicio1()
        {
            Escribir = File.AppendText(trt);
            Escribir.WriteLine("Correlativo  - Nombre -  NIT - Fecha - Detalle de la compra - Monto Total");
            Escribir.Close();
        }
            static void Compras(string Productos)
        {
            Escribir = File.AppendText(trt);
            Escribir.WriteLine(Productos);
            Escribir.Close();
        }
        static double operacion(double C, double P)
        {
            double resultado;
            resultado = C * P;
            return resultado;
        }
        public void factura()
        {
            TextReader Letter;
            Letter = new StreamReader("Facturas.txt");
            Console.WriteLine(Letter.ReadToEnd());
        }

        static string Lectura3(string Facturacion)
        {
            string linea = " ";
            Archivo = new FileStream(Facturacion, FileMode.Open, FileAccess.Read);
            Leer = new StreamReader(trt);
            linea = Leer.ReadToEnd();
            Console.WriteLine(linea);
            Leer.Close();
            Archivo.Close();
            return linea;

        }
    }
}
