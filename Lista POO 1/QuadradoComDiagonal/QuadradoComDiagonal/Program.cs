using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuadradoComDiagonal.ClassQuadradoComDiagonal.classAreaRetangulo;

namespace QuadradoComDiagonal
{
            internal class Program
        {
            static void Main(string[] args)
            {

                Multi s;
                s = new Multi();
                Console.WriteLine("BEM VINDO AO PROGRAMA");
                Console.WriteLine("Calcular e exibir a área de um quadrado a partir do valor de sua diagonal que será digitado. ");

                Console.WriteLine("Digite  diagonal");
                s.setA(int.Parse(Console.ReadLine()));

                s.calcular();
                Console.WriteLine("A área do quadrado é: {1}", s.getA(), s.getresultado());
            }
        }
 }