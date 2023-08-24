using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoisValoresIguais
{
    internal class ClassDoisValoresIguais
    {
        internal class Multi
        {
            #region Atributos
            private double b;
            private double a;
            private double resultado;
            #endregion
            #region MetodosInterface
            public void setB(double p) //recebe 
            {
                this.b = p;
            }
            public void setA(double o) //recebe 
            {
                this.a = o;
            }
            public double getB()// retorna 
            {
                return this.b;
            }
            public double getA()
            {
                return this.a;
            }
            public double getresultado()//retorna resultado
            {
                return this.resultado;
            }
            #endregion
            #region Método funcional
            public void calcular()
            {
                if (this.b > this.a)
                {
                    this.resultado = this.b;
                    Console.WriteLine("O maior número é " + this.b);
                }
                else if (this.a > this.b)
                {
                    this.resultado = this.a;
                    Console.WriteLine("O maior número é " + this.a);
                }
                else if(this.b == this.a)
                { 
                    this.resultado = 0;
                    Console.WriteLine("Os números são idênticos");
                }
            }
            #endregion
        }
    }
}