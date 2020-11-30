using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca06
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor3D v1 = new Vetor3D(1.0, 2.0,3.0);
            Vetor3D v2 = new Vetor3D(4.0, 5.0,6.0);

            
            v1.calcularModulo3D();
            v2.calcularModulo3D();

            v1.produtoVetorial(v1,v2);


            Console.ReadLine();
        }
    }
}
