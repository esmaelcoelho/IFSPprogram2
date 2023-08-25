using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrenoGrande
{
    internal class Class1
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
                this.resultado = a * b;
                if (this.resultado > 100)
                {
                    Console.WriteLine("Terreno grande");
                }
                else
                {
                    Console.WriteLine("Terreno pequeno");
                }
            }
            #endregion
        }
    }
}
