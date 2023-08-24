using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MaiordeDois.ClassMaiordeDois;

namespace MaiordeDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multi s;
            s = new Multi();
            Console.WriteLine("BEM VINDO AO PROGRAMA");
            Console.WriteLine("Entrar via teclado, com dois valores distintos. Exibir o maior deles. ");

            Console.WriteLine("Digite  primeiro valor: ");
            s.setB(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite segundo valor: ");
            s.setA(double.Parse(Console.ReadLine()));

            s.calcular();
            Console.WriteLine("O maior número é {2}", s.getB(), s.getA(), s.getresultado());
        }
    }
}
