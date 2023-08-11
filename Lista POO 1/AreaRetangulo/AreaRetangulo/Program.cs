using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AreaRetangulo.classAreaRetangulo;

namespace AreaRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Multi s;
            s = new Multi();
            Console.WriteLine("BEM VINDO AO PROGRAMA");
            Console.WriteLine("Entrar via teclado com a base e a altura de um retângulo, calcular e exibir sua área");
            
            Console.WriteLine("Digite a altura: ");
            s.setB(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite a base: ");
            s.setA(int.Parse(Console.ReadLine()));

            s.calcular();
            Console.WriteLine("A area de um retangulo {2}", s.getB(), s.getA(), s.getresultado());
        }
    }
}

