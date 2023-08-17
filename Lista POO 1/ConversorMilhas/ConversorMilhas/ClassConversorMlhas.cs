using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMilhas
{
    internal class ClassConversorMlhas
    {
        internal class Multi
        {
            #region Atributos
            private double a;
            private double resultado;
            #endregion

            #region MetodosInterface
            public void setA(int p) //recebe 
            {
                a = p;
            }
            public double getA()// retorna 
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
                resultado = 1852 * a / 1000;
            }
            #endregion
        }
    }
}
