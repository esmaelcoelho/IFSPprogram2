using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadradoComDiagonal
{
    internal class ClassQuadradoComDiagonal
    {
        internal class classAreaRetangulo
        {
            internal class Multi
            {
                #region Atributos
                private double diagonal;
                private double resultado;
                #endregion

                #region MetodosInterface
                public void setA(int p) //recebe 
                {
                    diagonal = p;
                }
                public double getA()// retorna 
                {
                    return diagonal;
                }
                public double getresultado()//retorna resultado
                {
                    return resultado;
                }
                #endregion
                #region Método funcional
                public void calcular()
                {
                    resultado = diagonal * diagonal / 2;
                }
                #endregion
            }
        }
    }
}