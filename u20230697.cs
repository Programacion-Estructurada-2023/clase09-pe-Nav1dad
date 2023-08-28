using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Realizar un programa de consola donde se le ingrese una nota

            Console.WriteLine("\n<<<<<<<<<< programa de ingreso de notas >>>>>>>>>>\n");
            Console.WriteLine("\nIngrese su nota\n");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 7.0 && nota <= 8.4) 
            {
                Console.WriteLine("\nLa calificacion obtenida es "+nota+"  Tu nota es buena!");
            }


            else if (nota >= 8.5 && nota <= 9.4)
            {
                Console.WriteLine("\nLa calificacion obtenida es "+nota+" Tu nota es muy buena!!!");
            }


            else if (nota >= 9.5 && nota <=10)
            {
                Console.WriteLine("\nLa calificacion obtenida es "+nota+" Tu nota es Exelente!!!!!");  
            }


            else if (nota >10)
            {
                Console.WriteLine("\nERROR esta nota no se puede ingresar");  
            }


            else 
            {
                Console.WriteLine("\nLa calificacion obtenida es "+nota+" Tu nota es deficiente");
            }

             Console.WriteLine("\n<<<<<<<<<< FIN DEL PROGRAMA >>>>>>>>>>\n");

             // NOMBRE: PEDRO ANTONIO ALVAREZ HERNANDEZ
             // CODIGO: U20230697
             // POSDATA: LE AGREGUE ALGO AL EJERCICIO PARA QUE SE VIERA UN POCO MAS ESTETICO

        }
    }
}
