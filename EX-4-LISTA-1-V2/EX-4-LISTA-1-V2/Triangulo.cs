using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4_lista_1_V2
{
    class Triangulo
    {
        #region atributos
        private double basE;
        private double altura;
        private double area;
        #endregion
        #region construtor
        public Triangulo() 
        {
            basE = 0;
            altura = 0;
            calcularArea();
        }
        #endregion
        #region set e gets
        public void setBase(double basE)
        {
            this.basE = basE;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public double getBase()
        {
            return basE;
        }
        public double getAltura()
        {
            return altura;
        }
        public double getArea()
        {
            return area;
        }
        #endregion
        #region metodos
        public void calcularArea()
        {
            area = (basE * altura) / 2;
        }
        #endregion
    }
}
