using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca06
{
    class Vetor2D
    {
        protected double x;
        protected double y;

        public Vetor2D () // construtor default
        {
            x = 0.0;
            y = 0.0;
        }

        public Vetor2D (double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        // getters 
        public double getX()
        {
            return (x);
        }

        public double getY()
        {
            return (y);
        }


        //setters
        public void setX(double _x)
        {
            x = _x;
        }

        public void setY(double _y)
        {
            y = _y;
        }


        public double calcularProdutoEscalar(Vetor2D v1, Vetor2D v2) // Método que retorna o produto escalar entre dois vetores
        {

            double produtoEscalar = (v1.x * v2.x) + (v1.y * v2.y);
            return (produtoEscalar);

        }

        public double calcularModulo()
        {
            double modulo = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)); // Método que retorna o módulo do vetor
            return (modulo);
        }

        public double calcularAngulo(Vetor2D v1, Vetor2D v2)
        {
            double angulo = (Math.Acos(((v1.x * v2.x) + (v1.y * v2.y)) / (v1.calcularModulo() * v2.calcularModulo())) * 57.2958);// Método que retorna o angulo entre dois vetores
            return (angulo);
        }


        public virtual void calcularModulo3D() { }

        public virtual void produtoVetorial(Vetor3D v1, Vetor3D v2) { }
    }
} 
