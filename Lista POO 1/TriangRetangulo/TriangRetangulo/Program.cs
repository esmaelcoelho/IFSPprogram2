using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TriangRetangulo.Class1;

namespace TriangRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangulo s;
            s = new triangulo();

            Console.WriteLine("BEM VINDO AO PROGRAMA");
            Console.WriteLine("Verificar se três valores quaisquer (A,B,C) que serão digitados formam ou não um" +
            "triângulo retângulo.Lembre - se que o quadrado da hipotenusa é igual a soma dos quadrados dos" +
            "catetos. ");

            Console.WriteLine("Digite lado A cateto");
            s.set1(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite lado B cateto");
            s.set2(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite lado C hipotenusa");
            s.set3(double.Parse(Console.ReadLine()));

            s.calcular();

        }
    }
}
