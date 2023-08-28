using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Class1
    {
        internal class IMC
        {
            #region Atributos
            private double peso;
            private double altura;
            private double imc;
            #endregion
            #region MetodosInterface
            public void setPeso(double peso) //recebe 
            {
                this.peso = peso;
            }
            public void setAltura(double altura) //recebe 
            {
                this.altura = altura;
            }
            public double getPeso()// retorna 
            {
                return this.peso;
            }
            public double getAltura()
            {
                return this.altura;
            }
            public double getImc()//retorna resultado
            {
                return this.imc;
            }
            #endregion
            #region Método funcional
            public void calculo()
            {
                this.imc =  (this.peso/(this.altura * this.altura));

                if (imc < 20)
                {
                    Console.WriteLine("Abaixo do Peso");
                }
                else if (imc >= 20 && imc < 25)
                {
                    Console.WriteLine("Peso Ideal");
                }
                else if (imc >= 25)
                {
                    Console.WriteLine("Acima do Peso");
                }
            }
            #endregion
        }
    }
}
