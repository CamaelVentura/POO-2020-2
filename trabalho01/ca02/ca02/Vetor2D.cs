using System;
using System.Collections.Generic;
using System.Text;

namespace ca02
{
    class Vetor2D
    {
        private double x;
        private double y;

        public Vetor2D()
        {
            this.x = 0.0;
            this.y = 0.0;
        }

        public Vetor2D(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public double getX()
        {
            return this.x;
        }

        public double getY()
        {
            return this.y;
        }

        public void setX(double _x)
        {
            this.x = _x;
        }

        public void setY(double _y)
        {
            this.y = _y;
        }

        public double calcularProdutoEscalar(Vetor2D v1, Vetor2D v2)
        {
            double produtoEscalar = (v1.x * v2.x) + (v1.y * v2.y);
            return produtoEscalar;
        }

        public double calcularModulo()
        {
            double modulo = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            return modulo;
        }

        public double calcularAngulo(Vetor2D v1, Vetor2D v2)
        {
            double angulo = Math.Cos(((v1.x*v2.x)+(v1.y*v2.y))/(v1.calcularModulo()*v2.calcularModulo()));
            return angulo;
        }
    }
}
