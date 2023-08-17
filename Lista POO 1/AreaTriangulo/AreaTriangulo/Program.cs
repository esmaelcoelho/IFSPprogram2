using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AreaTriangulo.ClassAreaTriangulo;

namespace AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multi s;
            s = new Multi();
            Console.WriteLine("BEM VINDO AO PROGRAMA");
            Console.WriteLine("A partir dos valores da base e altura de um triângulo, calcular e exibir sua área. ");

            Console.WriteLine("Digite a altura: ");
            s.setB(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite a base: ");
            s.setA(int.Parse(Console.ReadLine()));

            s.calcular();
            Console.WriteLine("A area de um Triangulo é {2}", s.getB(), s.getA(), s.getresultado());
        }
    }
}
