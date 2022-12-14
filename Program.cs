using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetro_del_cuadrado
{
    class Program
    {
        //CALCULAR EL PERIMETRO DE UN CUADRADO//
    //Inicio
    //1. Pedir la medida de un lado del cuadrado
    //2.Calcular el perimetro sumando los 4 lados
    //3.Mostrar el perimetro CUADRADO
    //FIN
        static void Main(string[] args)
        {
            double lado, perimetro;
            Console.WriteLine("Para calcular el perimetro, ingresa la medida de un lado solamente:");

            lado = Convert.ToDouble(Console.ReadLine());
            perimetro = 4 * lado;
            Console.WriteLine("Valor de perimetro: " + perimetro);
            Console.WriteLine("Recuerda que el perimetro se calcula con la siguiente formula: \nperimetro = lado + lado + lado :)");
            Console.ReadKey();
        }
    }
}
