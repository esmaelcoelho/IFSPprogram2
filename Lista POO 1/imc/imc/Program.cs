using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static imc.Class1;

namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMC s;
            s = new IMC();

            Console.WriteLine("BEM VINDO AO PROGRAMA");
            Console.WriteLine("Entrar com o peso e a altura de uma determinada pessoa. Após a digitação, exibir se esta" +
                "pessoa está ou não com seu peso ideal. Veja tabela da relação peso/altura²");

            Console.WriteLine("Digite a peso ");
            s.setPeso(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite a altura ");
            s.setAltura(double.Parse(Console.ReadLine()));

            s.calculo();
        }
    }
}
