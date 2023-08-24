using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoisValoresIguais.ClassDoisValoresIguais;

namespace DoisValoresIguais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multi s;
            s = new Multi();
            //s = new Multi(6,9); os Valores podem ser mencionados


            Console.WriteLine("BEM VINDO AO PROGRAMA");
            Console.WriteLine("Entrar com dois valores quaisquer. Exibir o maior deles, se existir, caso contrário, enviar\r\nmensagem avisando que os números são idênticos. ");

            Console.WriteLine("Digite  primeiro valor: ");
            s.setB(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite segundo valor: ");
            s.setA(double.Parse(Console.ReadLine()));
            
            s.calcular();
        }
    }
}
