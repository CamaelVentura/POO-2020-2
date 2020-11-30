using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca06
{
    class Vetor3D : Vetor2D
    {
        public double z;

        public Vetor3D() 
        {
            x = 0.0;
            y = 0.0;
            z = 0.0;
        }

        public Vetor3D(double _x, double _y, double _z) : base(_x, _y)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        // getters 
        public double getZ()
        {
            return (z);
        }

        //setters
        public void setZ(double _z)
        {
            z = _z;
        }

        public override void calcularModulo3D()
        {
            Console.WriteLine("O modulo do vetor é: " + Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2))); // Método que retorna o módulo do vetor 3D
        }

        public override void produtoVetorial(Vetor3D v1, Vetor3D v2)
        {

            Vetor3D v3 = new Vetor3D((v1.y * v2.z - v2.y * v1.z), (-1 * (v1.x * v2.z - v2.x * v1.z)), (v1.x * v2.y - v2.x * v1.y));

            Console.WriteLine("O produto vetorial entre v1 e v2 é: (" + v3.getX() + ", " + v3.getY() + ", " + v3.getZ() + ")");

        }

    }
}
