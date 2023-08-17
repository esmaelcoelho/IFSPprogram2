using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    internal class ClassCotacaoDolar
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
                b = p;
            }
            public void setA(double o) //recebe 
            {
                a = o;
            }
            public double getB()// retorna 
            {
                return b;
            }
            public double getA()
            {
                return a;
            }
            public double getresultado()//retorna resultado
            {
                return resultado;
            }
            #endregion
            #region Método funcional
            public void calcular()
            {
                resultado = a / b;
            }
            #endregion
        }
    }
}
