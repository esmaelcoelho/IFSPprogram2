using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static triangulo3.Class1;

namespace triangulo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo s;
            s = new triangulo();

            Console.WriteLine("BEM VINDO AO PROGRAMA");
            Console.WriteLine("A partir de três valores que serão digitados, verificar se formam ou não um triângulo");

            Console.WriteLine("Digite primeiro lado ");
            s.set1(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite segundo lado ");
            s.set2(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite terceiro lado ");
            s.set3(double.Parse(Console.ReadLine()));

            s.calcular();

        }
    }
}
