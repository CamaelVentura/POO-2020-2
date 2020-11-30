using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscolar.Models;

namespace SistemaEscolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //PopulateMateriasAlunoList();
        }

        private void alunoSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectAluno = alunoSelect.SelectedItem.ToString();

            Aluno alunoObj = Program.Alunos.Find(delegate (Aluno aluno)
            {
                string __compare = aluno.Nome + " - " + aluno.NumeroMatricula;
                return __compare == selectAluno;
            });

            materiaAlunoList.Items.Clear();
            alunoObj.Materias.ForEach(materia => {
                materiaAlunoList.Items.Add(materia.Nome);
            });
        }

        private void mainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabName = mainTab.SelectedTab.Name;

            if(tabName == "relatorioTab")
            {
                refreshListAlunos(alunoSelect);
            }
        }

        private void refreshListAlunos(ListBox alunoList)
        {
            alunoList.Items.Clear();

            if (Program.Alunos.Count > 0)
            {
                Program.Alunos.ForEach(aluno => {
                    alunoList.Items.Add(aluno.Nome + " - " + aluno.NumeroMatricula);
                });
                alunoList.Text = "Selecione um aluno!";
            }
            else
            {
                alunoList.Items.Add("0 alunos cadastrados!");
            }
        }

        private void refreshListAlunos(ComboBox alunoList)
        {
            alunoList.Items.Clear();

            if (Program.Alunos.Count > 0)
            {
                Program.Alunos.ForEach(aluno => {
                    alunoList.Items.Add(aluno.Nome + " - " + aluno.NumeroMatricula);
                });
                alunoList.Text = "Selecione um aluno!";
            }
            else
            {
                alunoList.Text = "0 alunos cadastrados!";
            }
        }

        private void refreshListMaterias(ListBox materiaList)
        {
            materiaList.Items.Clear();

            if (Program.Materias.Count > 0)
            {
                Program.Materias.ForEach(materia => {
                    if(materia.Vagas > 0)
                        materiaList.Items.Add(materia.Nome + " - Vagas: " + materia.Vagas);
                });
            }
            else
            {
                materiaList.Items.Add("0 materias cadastradas!");
            }
        }

        private void refreshListMaterias(ComboBox materiaList)
        {
            materiaList.Items.Clear();
            if (Program.Materias.Count > 0)
            {
                Program.Materias.ForEach(materia => {
                    if (materia.Vagas > 0)
                        materiaList.Items.Add(materia.Nome + " - Vagas: " + materia.Vagas);
                });
                materiaList.Text = "Selecione uma materia!";
            }
            else
            {
                materiaList.Text = "0 materias cadastradas!";
            }
            materiaList.Refresh();
        }

        private void refreshListMaterias(ComboBox materiaList, ListBox materiaListExclude)
        {
            materiaList.Items.Clear();
            if (Program.Materias.Count > 0)
            {
                if(Program.Materias.Count == materiaListExclude.Items.Count)
                    materiaList.Text = "0 materias cadastradas!";
                else
                    Program.Materias.ForEach(materia => {                    
                        if (materia.Vagas > 0 && !materiaListExclude.Items.Contains(materia.Nome))
                            materiaList.Items.Add(materia.Nome + " - Vagas: " + materia.Vagas);
                    });

                materiaList.Text = "Selecione uma materia!";
            }
            else
            {
                materiaList.Text = "0 materias cadastradas!";
            }
            materiasList.Refresh();
        }

        private void addMateria_Click(object sender, EventArgs e)
        {
            String nome = nomeMateriaText.Text;
            int vagas = System.Convert.ToInt32(vagasMateriaText.Text);

            if (nome == "" || vagas == 0)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            Materia materia = new Materia(nome, vagas);

            Program.Materias.Add(materia);

            MessageBox.Show("Materia " + materia.Nome + " adicionada!");

            nomeMateriaText.Text = "";
            vagasMateriaText.Text = "0";

            refreshListMaterias(materiasList);
        }

        

        private void addAluno_Click(object sender, EventArgs e)
        {
            String nome = nomeAlunoText.Text;
            String matricula = matriculaAlunoText.Text;
            String telefone = telefoneAlunoText.Text;

            if(nome == "" || matricula == "" || telefone == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            Aluno aluno = new Aluno(nome, matricula, telefone);

            Program.Alunos.Add(aluno);

            MessageBox.Show("Aluno " + aluno.Nome + " adicionado!");

            nomeAlunoText.Text = "";
            matriculaAlunoText.Text = "";
            telefoneAlunoText.Text = "";

            refreshListAlunos(alunosList);
        }

        private void selectMateria_Click(object sender, EventArgs e)
        {
            if(materiasMatriculaList.SelectedItem == null)
            {
                refreshListMaterias(materiasMatriculaList, materiasSelMatriculaList);
                return;
            }
            string materiaName = materiasMatriculaList.SelectedItem.ToString();            

            Materia materiaObj = Program.Materias.Find(delegate (Materia materia)
            {
                string __compare = materia.Nome + " - Vagas: " + materia.Vagas;
                return __compare == materiaName;
            });

            List<Materia> materiasSelect = new List<Materia>();

            materiasSelect.Add(materiaObj);

            materiasSelMatriculaList.Items.Add(materiaObj.Nome);

            refreshListMaterias(materiasMatriculaList, materiasSelMatriculaList);
        }

        private void alunosSubTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabName = alunosSubTab.SelectedTab.Name;

            if (tabName == "matriculaTab")
            {
                refreshListAlunos(alunoMatriculaList);
                refreshListMaterias(materiasMatriculaList);
            }
        }

        private void addMatricula_Click(object sender, EventArgs e)
        {
            if (alunoMatriculaList.SelectedItem == null)
            {
                MessageBox.Show("Selecione um aluno, para realizar a matricula!");
                return;
            }

            if (materiasSelMatriculaList.Items.Count == 0)
            {
                MessageBox.Show("Selecione ao menos uma materia!");
                return;
            }            

            string alunoName = alunoMatriculaList.SelectedItem.ToString();
            Aluno alunoObj = Program.Alunos.Find(delegate (Aluno aluno)
            {
                string __compare = aluno.Nome + " - " + aluno.NumeroMatricula;
                return __compare == alunoName;
            });

            foreach (var item in materiasSelMatriculaList.Items)
            {
                Materia _materia = Program.Materias.Find(delegate (Materia _mat)
                {
                    return _mat.Nome == item.ToString();
                });

                alunoObj.Matricular(_materia);
            }


            MessageBox.Show("Matricula realizada!");
        }
    }
}
