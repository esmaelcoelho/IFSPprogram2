using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TerrenoGrande.Class1;

namespace TerrenoGrande
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multi s;
            s = new Multi();
            //s = new Multi(6,9); os Valores podem ser mencionados


            Console.WriteLine("BEM VINDO AO PROGRAMA");
            Console.WriteLine("Calcular e exibir a área de um retângulo, a partir dos valores da base e altura que serão " +
                "digitados. Se a área for maior que 100, exibir a mensagem “Terreno grande”, caso contrário, " +
                "exibir a mensagem “Terreno pequeno");

            Console.WriteLine("Digite a base ");
            s.setB(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite a altura ");
            s.setA(double.Parse(Console.ReadLine()));

            s.calcular();
        }
    }
}
