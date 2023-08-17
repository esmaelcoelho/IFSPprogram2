using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConversorMilhas.ClassConversorMlhas;

namespace ConversorMilhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multi s;
            s = new Multi();
            Console.WriteLine("BEM VINDO AO PROGRAMA");
            Console.WriteLine("Sabendo que uma milha marítima equivale a um mil, oitocentos e cinqüenta e dois metros e que um quilômetro possui mil metros, fazer um programa para converter milhas marítimas em quilômetros. ");

            Console.WriteLine("Digite o valor da Milha para conversao");
            s.setA(int.Parse(Console.ReadLine()));

            s.calcular();
            Console.WriteLine("A conversao é: {1}", s.getA(), s.getresultado());
        }
    }
}