using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangRetangulo
{
    internal class Class1
    {
            internal class triangulo
            {
                #region Atributos
                private double a;
                private double b;
                private double c;
                #endregion
                #region MetodosInterface
                public void set1(double Um) //recebe 
                {
                    this.a = Um;
                }
                public void set2(double Dois) //recebe 
                {
                    this.b = Dois;
                }
                public void set3(double Tres) //recebe
                {
                    this.c = Tres;
                }
                public double get1()// retorna 
                {
                    return this.a;
                }
                public double get2()//retorna
                {
                    return this.b;
                }
                public double get3()//retorna
                {
                    return this.c;
                }

                #endregion
                #region Método funcional
                public void calcular()
                {
                if (this.c == this.a + this.b)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else
                {
                    Console.WriteLine("Os valores não formam um TRIANGULO RETANGULO");
                }
            }
        }
        #endregion
    }
}
