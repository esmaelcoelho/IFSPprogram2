using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CotacaoDolar.ClassCotacaoDolar;

namespace CotacaoDolar
{
    internal class Program
    {
            static void Main(string[] args)
            {
            Multi s;
            s = new Multi();
            Console.WriteLine("BEM VINDO AO PROGRAMA");
            Console.WriteLine("Entrar via teclado com o valor da cotação do dólar e uma certa quantidade de dólares.Calcular e exibir o valor correspondente em Reais (R$)");

            Console.WriteLine("Digite o valor do Dolar");
            s.setB(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o Valor para Conversão");
            s.setA(int.Parse(Console.ReadLine()));

            s.calcular();
            Console.WriteLine("A conversao é: {2} R$", s.getB(), s.getA(), s.getresultado());
        }
        }
    }
