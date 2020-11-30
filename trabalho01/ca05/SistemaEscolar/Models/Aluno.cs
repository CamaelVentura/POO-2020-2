using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaEscolar.Models
{
    class Aluno
    {
        private String nome;
        private String numeroMatricula;
        private String telefone;

        private List<Materia> materias = new List<Materia>();

        public string Nome { get => nome; set => nome = value; }
        public string NumeroMatricula { get => numeroMatricula; set => numeroMatricula = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        internal List<Materia> Materias { get => materias; set => materias = value; }

        public Aluno() { }

        public Aluno(String _nome, String _numeroMatricula, String _telefone)
        {
            Nome = _nome;
            NumeroMatricula = _numeroMatricula;
            Telefone = _telefone;
        }

        public int getNumeroMaterias()
        {
            return Materias.Count;
        }

        public void Matricular(Materia _materia)
        {
            Materias.Add(_materia);
        }
    }
}
