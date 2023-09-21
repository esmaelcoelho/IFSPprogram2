using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formAreaTriangulo
{
    internal class Class1
    {
        #region Atributos
        private int b;
        private int a;
        private int resultado;
        #endregion

        #region MetodosInterface
        public void setB(int p) //recebe 
        {
            b = p;
        }
        public void setA(int o) //recebe 
        {
            a = o;
        }
        public int getB()// retorna 
        {
            return b;
        }
        public int getA()
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
            resultado = a * b / 2;
        }
        #endregion
    }
}