using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo3
{
    internal class Class1
    {
        internal class triangulo 
        { 
        #region Atributos
        private double lado1;
        private double lado2;
        private double lado3;
        #endregion
        #region MetodosInterface
        public void set1(double Um) //recebe 
        {
            this.lado1 = Um;
        }
        public void set2(double Dois) //recebe 
        {
            this.lado2 = Dois;
        }
        public void set3(double Tres) //recebe
        {
            this.lado3 = Tres;
        }
        public double get1()// retorna 
        {
            return this.lado1;
        }
        public double get2()//retorna
        {
            return this.lado2;
        }
        public double get3()//retorna
        {
            return this.lado3;
        }

        #endregion
        #region Método funcional
        public void calcular()
        {
            if ((lado1 + lado2 <= lado3) && (lado1 + lado3 <= lado2) && (lado2 + lado3 <= lado1))
            {
                Console.WriteLine("Não é triangulo");
            }
            else if ((lado1 == lado2) && (lado1 == lado3) && (lado2 == lado3))
            {
                Console.WriteLine("triangulo equilatero");
            }
            else if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
            {
                Console.WriteLine("isosceles");
            }
            else
                Console.WriteLine("Triangulo escaleno.");
            #endregion

        }
        }
    }
}
