using System;

namespace ca01
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Roberto", 123456789, 123456789);
            Aluno a2 = new Aluno();

            a1.imprimaAluno();
            a2.imprimaAluno();

            a2.insiraAluno();

            a1.imprimaAluno();
            a2.imprimaAluno();


        }
    }
}
