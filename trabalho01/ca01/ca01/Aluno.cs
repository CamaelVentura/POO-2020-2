using System;
using System.Collections.Generic;
using System.Text;

namespace ca01
{
    class Aluno
    {
        private string nome;
        private int n_matricula;
        private int telefone;

        public Aluno()
        {
            this.nome = "?";
            this.n_matricula = 0;
            this.telefone = 0;
        }

        public Aluno(string _nome, int _n_matricula, int _telefone)
        {
            this.nome = _nome;
            this.n_matricula = _n_matricula;
            this.telefone = _telefone;
        }

        public string getNome()
        {
            return this.nome;
        }

        public int getN_Matricula()
        {
            return this.n_matricula;
        }

        public int getTelefone()
        {
            return this.telefone;
        }

        public void setNome(string _nome)
        {
            this.nome = _nome;
        }

        public void setN_Matricula(int _n_matricula)
        {
            this.n_matricula = _n_matricula;
        }

        public void setTelefone(int _telefone)
        {
            this.telefone = _telefone;
        }

        public void imprimaAluno()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Numero de matricula: " + this.n_matricula);
            Console.WriteLine("Telefone: " + this.telefone);
        }

        public void insiraAluno()
        {
            Console.WriteLine("Insira o nome: ");
            this.nome = Console.ReadLine();
            Console.WriteLine("Insira o numero da matricula: ");
            this.n_matricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o telefone: ");
            this.telefone = Convert.ToInt32(Console.ReadLine());
        }
    }
}
