using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SistemaEscolar.Models
{
    class Materia
    {
        private String nome;
        private int vagas;

        public String Nome { get => nome; set => nome = value; }
        public int Vagas { get => vagas; set => vagas = value; }

        public Materia() { }

        public Materia(String _nome, int _vagas)
        {
            Nome = _nome;
            Vagas = _vagas;
        }
    }
}
