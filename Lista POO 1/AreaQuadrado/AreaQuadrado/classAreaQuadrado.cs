using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    internal class classAreaRetangulo
    {
        internal class Multi
        {
            #region Atributos
            private int a;
            private int resultado;
            #endregion

            #region MetodosInterface
            public void setA(int p) //recebe 
            {
                a = p;
            }
            public int getA()// retorna 
            {
                return a;
            }
            public int getresultado()//retorna resultado
            {
                return resultado;
            }
            #endregion
            #region Método funcional
            public void calcular()
            {
                resultado = a * a;
            }
            #endregion
        }
    }
}
