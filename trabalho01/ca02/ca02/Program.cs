using System;

namespace ca02
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor2D v1 = new Vetor2D(2.0, 2.0);
            Vetor2D v2 = new Vetor2D(2.0, 2.0);

            Console.WriteLine(v1.calcularAngulo(v1, v2));
        }
    }
}
