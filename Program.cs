
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetro del cuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lados, medidacm;
            int num1, num2, resultado;
            Console.Write("Numero de lados del poligono");
            lados = Console.ReadLine();
            num1 = Convert.ToInt32(lados);
            Console.Write("Medida en CM del poligono");
            medidacm = Console.ReadLine();
            num2 = Convert.ToInt32(medidacm);
            resultado = num1 * num2;
            Console.WriteLine("El perimentro es: {0} centimetros, vuelva pronto :3", resultado);
        }
    }
}