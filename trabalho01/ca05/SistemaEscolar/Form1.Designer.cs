
namespace SistemaEscolar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTab = new System.Windows.Forms.TabControl();
            this.alunosTab = new System.Windows.Forms.TabPage();
            this.alunosSubTab = new System.Windows.Forms.TabControl();
            this.addAlunoTab = new System.Windows.Forms.TabPage();
            this.telefoneAlunoText = new System.Windows.Forms.MaskedTextBox();
            this.addAluno = new System.Windows.Forms.Button();
            this.telefoneAlunoLabel = new System.Windows.Forms.Label();
            this.matriculaAlunoText = new System.Windows.Forms.TextBox();
            this.matriculaAlunoLabel = new System.Windows.Forms.Label();
            this.nomeAlunoText = new System.Windows.Forms.TextBox();
            this.nomeAlunoLabel = new System.Windows.Forms.Label();
            this.matriculaTab = new System.Windows.Forms.TabPage();
            this.alunoMatriculaList = new System.Windows.Forms.ComboBox();
            this.selectMateria = new System.Windows.Forms.Button();
            this.materiasSelMatriculaList = new System.Windows.Forms.ListBox();
            this.materiasSeleMatriculaLabel = new System.Windows.Forms.Label();
            this.materiasMatriculaList = new System.Windows.Forms.ComboBox();
            this.materiasMatriculaLabel = new System.Windows.Forms.Label();
            this.alunoMatriculaLabel = new System.Windows.Forms.Label();
            this.alunosList = new System.Windows.Forms.ListBox();
            this.materiasTab = new System.Windows.Forms.TabPage();
            this.materiasList = new System.Windows.Forms.ListBox();
            this.addMateriaNotification = new System.Windows.Forms.Label();
            this.addMateria = new System.Windows.Forms.Button();
            this.vagasMateriaText = new System.Windows.Forms.NumericUpDown();
            this.vagasMateriaLabel = new System.Windows.Forms.Label();
            this.nomeMateriaText = new System.Windows.Forms.TextBox();
            this.nomeMateriaLabel = new System.Windows.Forms.Label();
            this.relatorioTab = new System.Windows.Forms.TabPage();
            this.materiaAlunoLabel = new System.Windows.Forms.Label();
            this.materiaAlunoList = new System.Windows.Forms.ListBox();
            this.alunoSelectLabel = new System.Windows.Forms.Label();
            this.alunoSelect = new System.Windows.Forms.ComboBox();
            this.addMatricula = new System.Windows.Forms.Button();
            this.mainTab.SuspendLayout();
            this.alunosTab.SuspendLayout();
            this.alunosSubTab.SuspendLayout();
            this.addAlunoTab.SuspendLayout();
            this.matriculaTab.SuspendLayout();
            this.materiasTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vagasMateriaText)).BeginInit();
            this.relatorioTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.alunosTab);
            this.mainTab.Controls.Add(this.materiasTab);
            this.mainTab.Controls.Add(this.relatorioTab);
            this.mainTab.Location = new System.Drawing.Point(12, 12);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(776, 437);
            this.mainTab.TabIndex = 0;
            this.mainTab.SelectedIndexChanged += new System.EventHandler(this.mainTab_SelectedIndexChanged);
            // 
            // alunosTab
            // 
            this.alunosTab.Controls.Add(this.alunosSubTab);
            this.alunosTab.Controls.Add(this.alunosList);
            this.alunosTab.Location = new System.Drawing.Point(4, 24);
            this.alunosTab.Name = "alunosTab";
            this.alunosTab.Padding = new System.Windows.Forms.Padding(3);
            this.alunosTab.Size = new System.Drawing.Size(768, 409);
            this.alunosTab.TabIndex = 0;
            this.alunosTab.Text = "Alunos";
            this.alunosTab.UseVisualStyleBackColor = true;
            // 
            // alunosSubTab
            // 
            this.alunosSubTab.Controls.Add(this.addAlunoTab);
            this.alunosSubTab.Controls.Add(this.matriculaTab);
            this.alunosSubTab.Location = new System.Drawing.Point(212, 14);
            this.alunosSubTab.Name = "alunosSubTab";
            this.alunosSubTab.SelectedIndex = 0;
            this.alunosSubTab.Size = new System.Drawing.Size(538, 388);
            this.alunosSubTab.TabIndex = 1;
            this.alunosSubTab.SelectedIndexChanged += new System.EventHandler(this.alunosSubTab_SelectedIndexChanged);
            // 
            // addAlunoTab
            // 
            this.addAlunoTab.Controls.Add(this.telefoneAlunoText);
            this.addAlunoTab.Controls.Add(this.addAluno);
            this.addAlunoTab.Controls.Add(this.telefoneAlunoLabel);
            this.addAlunoTab.Controls.Add(this.matriculaAlunoText);
            this.addAlunoTab.Controls.Add(this.matriculaAlunoLabel);
            this.addAlunoTab.Controls.Add(this.nomeAlunoText);
            this.addAlunoTab.Controls.Add(this.nomeAlunoLabel);
            this.addAlunoTab.Location = new System.Drawing.Point(4, 24);
            this.addAlunoTab.Name = "addAlunoTab";
            this.addAlunoTab.Padding = new System.Windows.Forms.Padding(3);
            this.addAlunoTab.Size = new System.Drawing.Size(530, 360);
            this.addAlunoTab.TabIndex = 0;
            this.addAlunoTab.Text = "Cadastrar";
            this.addAlunoTab.UseVisualStyleBackColor = true;
            // 
            // telefoneAlunoText
            // 
            this.telefoneAlunoText.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.telefoneAlunoText.Location = new System.Drawing.Point(90, 103);
            this.telefoneAlunoText.Mask = "(00) 0 0000-0000";
            this.telefoneAlunoText.Name = "telefoneAlunoText";
            this.telefoneAlunoText.Size = new System.Drawing.Size(220, 23);
            this.telefoneAlunoText.TabIndex = 7;
            this.telefoneAlunoText.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // addAluno
            // 
            this.addAluno.Location = new System.Drawing.Point(210, 169);
            this.addAluno.Name = "addAluno";
            this.addAluno.Size = new System.Drawing.Size(100, 40);
            this.addAluno.TabIndex = 6;
            this.addAluno.Text = "Cadastrar";
            this.addAluno.UseVisualStyleBackColor = true;
            this.addAluno.Click += new System.EventHandler(this.addAluno_Click);
            // 
            // telefoneAlunoLabel
            // 
            this.telefoneAlunoLabel.AutoSize = true;
            this.telefoneAlunoLabel.Location = new System.Drawing.Point(30, 106);
            this.telefoneAlunoLabel.Name = "telefoneAlunoLabel";
            this.telefoneAlunoLabel.Size = new System.Drawing.Size(54, 15);
            this.telefoneAlunoLabel.TabIndex = 4;
            this.telefoneAlunoLabel.Text = "Telefone:";
            // 
            // matriculaAlunoText
            // 
            this.matriculaAlunoText.Location = new System.Drawing.Point(96, 65);
            this.matriculaAlunoText.Name = "matriculaAlunoText";
            this.matriculaAlunoText.Size = new System.Drawing.Size(214, 23);
            this.matriculaAlunoText.TabIndex = 3;
            // 
            // matriculaAlunoLabel
            // 
            this.matriculaAlunoLabel.AutoSize = true;
            this.matriculaAlunoLabel.Location = new System.Drawing.Point(30, 68);
            this.matriculaAlunoLabel.Name = "matriculaAlunoLabel";
            this.matriculaAlunoLabel.Size = new System.Drawing.Size(60, 15);
            this.matriculaAlunoLabel.TabIndex = 2;
            this.matriculaAlunoLabel.Text = "Matricula:";
            // 
            // nomeAlunoText
            // 
            this.nomeAlunoText.Location = new System.Drawing.Point(79, 26);
            this.nomeAlunoText.Name = "nomeAlunoText";
            this.nomeAlunoText.Size = new System.Drawing.Size(231, 23);
            this.nomeAlunoText.TabIndex = 1;
            // 
            // nomeAlunoLabel
            // 
            this.nomeAlunoLabel.AutoSize = true;
            this.nomeAlunoLabel.Location = new System.Drawing.Point(30, 29);
            this.nomeAlunoLabel.Name = "nomeAlunoLabel";
            this.nomeAlunoLabel.Size = new System.Drawing.Size(43, 15);
            this.nomeAlunoLabel.TabIndex = 0;
            this.nomeAlunoLabel.Text = "Nome:";
            // 
            // matriculaTab
            // 
            this.matriculaTab.Controls.Add(this.addMatricula);
            this.matriculaTab.Controls.Add(this.alunoMatriculaList);
            this.matriculaTab.Controls.Add(this.selectMateria);
            this.matriculaTab.Controls.Add(this.materiasSelMatriculaList);
            this.matriculaTab.Controls.Add(this.materiasSeleMatriculaLabel);
            this.matriculaTab.Controls.Add(this.materiasMatriculaList);
            this.matriculaTab.Controls.Add(this.materiasMatriculaLabel);
            this.matriculaTab.Controls.Add(this.alunoMatriculaLabel);
            this.matriculaTab.Location = new System.Drawing.Point(4, 24);
            this.matriculaTab.Name = "matriculaTab";
            this.matriculaTab.Padding = new System.Windows.Forms.Padding(3);
            this.matriculaTab.Size = new System.Drawing.Size(530, 360);
            this.matriculaTab.TabIndex = 1;
            this.matriculaTab.Text = "Matricula";
            this.matriculaTab.UseVisualStyleBackColor = true;
            // 
            // alunoMatriculaList
            // 
            this.alunoMatriculaList.FormattingEnabled = true;
            this.alunoMatriculaList.Location = new System.Drawing.Point(96, 32);
            this.alunoMatriculaList.Name = "alunoMatriculaList";
            this.alunoMatriculaList.Size = new System.Drawing.Size(281, 23);
            this.alunoMatriculaList.TabIndex = 0;
            // 
            // selectMateria
            // 
            this.selectMateria.Location = new System.Drawing.Point(383, 74);
            this.selectMateria.Name = "selectMateria";
            this.selectMateria.Size = new System.Drawing.Size(75, 23);
            this.selectMateria.TabIndex = 6;
            this.selectMateria.Text = "Adicionar";
            this.selectMateria.UseVisualStyleBackColor = true;
            this.selectMateria.Click += new System.EventHandler(this.selectMateria_Click);
            // 
            // materiasSelMatriculaList
            // 
            this.materiasSelMatriculaList.FormattingEnabled = true;
            this.materiasSelMatriculaList.ItemHeight = 15;
            this.materiasSelMatriculaList.Location = new System.Drawing.Point(58, 156);
            this.materiasSelMatriculaList.Name = "materiasSelMatriculaList";
            this.materiasSelMatriculaList.Size = new System.Drawing.Size(319, 139);
            this.materiasSelMatriculaList.TabIndex = 5;
            // 
            // materiasSeleMatriculaLabel
            // 
            this.materiasSeleMatriculaLabel.AutoSize = true;
            this.materiasSeleMatriculaLabel.Location = new System.Drawing.Point(48, 131);
            this.materiasSeleMatriculaLabel.Name = "materiasSeleMatriculaLabel";
            this.materiasSeleMatriculaLabel.Size = new System.Drawing.Size(126, 15);
            this.materiasSeleMatriculaLabel.TabIndex = 4;
            this.materiasSeleMatriculaLabel.Text = "Materias Selecionadas:";
            // 
            // materiasMatriculaList
            // 
            this.materiasMatriculaList.FormattingEnabled = true;
            this.materiasMatriculaList.Location = new System.Drawing.Point(109, 75);
            this.materiasMatriculaList.Name = "materiasMatriculaList";
            this.materiasMatriculaList.Size = new System.Drawing.Size(268, 23);
            this.materiasMatriculaList.TabIndex = 3;
            // 
            // materiasMatriculaLabel
            // 
            this.materiasMatriculaLabel.AutoSize = true;
            this.materiasMatriculaLabel.Location = new System.Drawing.Point(48, 78);
            this.materiasMatriculaLabel.Name = "materiasMatriculaLabel";
            this.materiasMatriculaLabel.Size = new System.Drawing.Size(55, 15);
            this.materiasMatriculaLabel.TabIndex = 2;
            this.materiasMatriculaLabel.Text = "Materias:";
            // 
            // alunoMatriculaLabel
            // 
            this.alunoMatriculaLabel.AutoSize = true;
            this.alunoMatriculaLabel.Location = new System.Drawing.Point(48, 35);
            this.alunoMatriculaLabel.Name = "alunoMatriculaLabel";
            this.alunoMatriculaLabel.Size = new System.Drawing.Size(42, 15);
            this.alunoMatriculaLabel.TabIndex = 1;
            this.alunoMatriculaLabel.Text = "Aluno:";
            // 
            // alunosList
            // 
            this.alunosList.FormattingEnabled = true;
            this.alunosList.ItemHeight = 15;
            this.alunosList.Location = new System.Drawing.Point(9, 14);
            this.alunosList.Name = "alunosList";
            this.alunosList.Size = new System.Drawing.Size(188, 379);
            this.alunosList.TabIndex = 0;
            // 
            // materiasTab
            // 
            this.materiasTab.Controls.Add(this.materiasList);
            this.materiasTab.Controls.Add(this.addMateriaNotification);
            this.materiasTab.Controls.Add(this.addMateria);
            this.materiasTab.Controls.Add(this.vagasMateriaText);
            this.materiasTab.Controls.Add(this.vagasMateriaLabel);
            this.materiasTab.Controls.Add(this.nomeMateriaText);
            this.materiasTab.Controls.Add(this.nomeMateriaLabel);
            this.materiasTab.Location = new System.Drawing.Point(4, 24);
            this.materiasTab.Name = "materiasTab";
            this.materiasTab.Padding = new System.Windows.Forms.Padding(3);
            this.materiasTab.Size = new System.Drawing.Size(768, 409);
            this.materiasTab.TabIndex = 1;
            this.materiasTab.Text = "Materias";
            this.materiasTab.UseVisualStyleBackColor = true;
            // 
            // materiasList
            // 
            this.materiasList.FormattingEnabled = true;
            this.materiasList.ItemHeight = 15;
            this.materiasList.Location = new System.Drawing.Point(559, 6);
            this.materiasList.Name = "materiasList";
            this.materiasList.Size = new System.Drawing.Size(206, 394);
            this.materiasList.TabIndex = 6;
            // 
            // addMateriaNotification
            // 
            this.addMateriaNotification.AutoSize = true;
            this.addMateriaNotification.Location = new System.Drawing.Point(384, 25);
            this.addMateriaNotification.Name = "addMateriaNotification";
            this.addMateriaNotification.Size = new System.Drawing.Size(0, 15);
            this.addMateriaNotification.TabIndex = 5;
            // 
            // addMateria
            // 
            this.addMateria.Location = new System.Drawing.Point(206, 63);
            this.addMateria.Name = "addMateria";
            this.addMateria.Size = new System.Drawing.Size(130, 27);
            this.addMateria.TabIndex = 4;
            this.addMateria.Text = "Cadastrar!";
            this.addMateria.UseVisualStyleBackColor = true;
            this.addMateria.Click += new System.EventHandler(this.addMateria_Click);
            // 
            // vagasMateriaText
            // 
            this.vagasMateriaText.Location = new System.Drawing.Point(71, 67);
            this.vagasMateriaText.Name = "vagasMateriaText";
            this.vagasMateriaText.Size = new System.Drawing.Size(120, 23);
            this.vagasMateriaText.TabIndex = 3;
            // 
            // vagasMateriaLabel
            // 
            this.vagasMateriaLabel.AutoSize = true;
            this.vagasMateriaLabel.Location = new System.Drawing.Point(22, 75);
            this.vagasMateriaLabel.Name = "vagasMateriaLabel";
            this.vagasMateriaLabel.Size = new System.Drawing.Size(40, 15);
            this.vagasMateriaLabel.TabIndex = 2;
            this.vagasMateriaLabel.Text = "Vagas:";
            // 
            // nomeMateriaText
            // 
            this.nomeMateriaText.Location = new System.Drawing.Point(71, 25);
            this.nomeMateriaText.Name = "nomeMateriaText";
            this.nomeMateriaText.Size = new System.Drawing.Size(265, 23);
            this.nomeMateriaText.TabIndex = 1;
            // 
            // nomeMateriaLabel
            // 
            this.nomeMateriaLabel.AutoSize = true;
            this.nomeMateriaLabel.Location = new System.Drawing.Point(22, 28);
            this.nomeMateriaLabel.Name = "nomeMateriaLabel";
            this.nomeMateriaLabel.Size = new System.Drawing.Size(43, 15);
            this.nomeMateriaLabel.TabIndex = 0;
            this.nomeMateriaLabel.Text = "Nome:";
            // 
            // relatorioTab
            // 
            this.relatorioTab.Controls.Add(this.materiaAlunoLabel);
            this.relatorioTab.Controls.Add(this.materiaAlunoList);
            this.relatorioTab.Controls.Add(this.alunoSelectLabel);
            this.relatorioTab.Controls.Add(this.alunoSelect);
            this.relatorioTab.Location = new System.Drawing.Point(4, 24);
            this.relatorioTab.Name = "relatorioTab";
            this.relatorioTab.Size = new System.Drawing.Size(768, 409);
            this.relatorioTab.TabIndex = 2;
            this.relatorioTab.Text = "Relatorios";
            this.relatorioTab.UseVisualStyleBackColor = true;
            // 
            // materiaAlunoLabel
            // 
            this.materiaAlunoLabel.AutoSize = true;
            this.materiaAlunoLabel.Location = new System.Drawing.Point(13, 172);
            this.materiaAlunoLabel.Name = "materiaAlunoLabel";
            this.materiaAlunoLabel.Size = new System.Drawing.Size(55, 15);
            this.materiaAlunoLabel.TabIndex = 3;
            this.materiaAlunoLabel.Text = "Materias:";
            // 
            // materiaAlunoList
            // 
            this.materiaAlunoList.FormattingEnabled = true;
            this.materiaAlunoList.ItemHeight = 15;
            this.materiaAlunoList.Location = new System.Drawing.Point(74, 101);
            this.materiaAlunoList.Name = "materiaAlunoList";
            this.materiaAlunoList.Size = new System.Drawing.Size(272, 154);
            this.materiaAlunoList.TabIndex = 2;
            // 
            // alunoSelectLabel
            // 
            this.alunoSelectLabel.AutoSize = true;
            this.alunoSelectLabel.Location = new System.Drawing.Point(26, 48);
            this.alunoSelectLabel.Name = "alunoSelectLabel";
            this.alunoSelectLabel.Size = new System.Drawing.Size(42, 15);
            this.alunoSelectLabel.TabIndex = 1;
            this.alunoSelectLabel.Text = "Aluno:";
            // 
            // alunoSelect
            // 
            this.alunoSelect.FormattingEnabled = true;
            this.alunoSelect.Location = new System.Drawing.Point(74, 45);
            this.alunoSelect.Name = "alunoSelect";
            this.alunoSelect.Size = new System.Drawing.Size(272, 23);
            this.alunoSelect.TabIndex = 0;
            this.alunoSelect.SelectedIndexChanged += new System.EventHandler(this.alunoSelect_SelectedIndexChanged);
            // 
            // addMatricula
            // 
            this.addMatricula.Location = new System.Drawing.Point(403, 222);
            this.addMatricula.Name = "addMatricula";
            this.addMatricula.Size = new System.Drawing.Size(100, 46);
            this.addMatricula.TabIndex = 7;
            this.addMatricula.Text = "Matricular";
            this.addMatricula.UseVisualStyleBackColor = true;
            this.addMatricula.Click += new System.EventHandler(this.addMatricula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTab);
            this.Name = "Form1";
            this.Text = "Sistema Escolar";
            this.mainTab.ResumeLayout(false);
            this.alunosTab.ResumeLayout(false);
            this.alunosSubTab.ResumeLayout(false);
            this.addAlunoTab.ResumeLayout(false);
            this.addAlunoTab.PerformLayout();
            this.matriculaTab.ResumeLayout(false);
            this.matriculaTab.PerformLayout();
            this.materiasTab.ResumeLayout(false);
            this.materiasTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vagasMateriaText)).EndInit();
            this.relatorioTab.ResumeLayout(false);
            this.relatorioTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage alunosTab;
        private System.Windows.Forms.TabPage materiasTab;
        private System.Windows.Forms.TabPage relatorioTab;
        private System.Windows.Forms.Label alunoSelectLabel;
        private System.Windows.Forms.ComboBox alunoSelect;
        private System.Windows.Forms.Label materiaAlunoLabel;
        private System.Windows.Forms.ListBox materiaAlunoList;
        private System.Windows.Forms.NumericUpDown vagasMateriaText;
        private System.Windows.Forms.Label vagasMateriaLabel;
        private System.Windows.Forms.TextBox nomeMateriaText;
        private System.Windows.Forms.Label nomeMateriaLabel;
        private System.Windows.Forms.Label addMateriaNotification;
        private System.Windows.Forms.Button addMateria;
        private System.Windows.Forms.ListBox materiasList;
        private System.Windows.Forms.ListBox alunosList;
        private System.Windows.Forms.TabControl alunosSubTab;
        private System.Windows.Forms.TabPage addAlunoTab;
        private System.Windows.Forms.Button addAluno;
        private System.Windows.Forms.Label telefoneAlunoLabel;
        private System.Windows.Forms.MaskedTextBox telefoneAlunoText;
        private System.Windows.Forms.TextBox matriculaAlunoText;
        private System.Windows.Forms.Label matriculaAlunoLabel;
        private System.Windows.Forms.TextBox nomeAlunoText;
        private System.Windows.Forms.Label nomeAlunoLabel;
        private System.Windows.Forms.TabPage matriculaTab;
        private System.Windows.Forms.ComboBox materiasMatriculaList;
        private System.Windows.Forms.Label materiasMatriculaLabel;
        private System.Windows.Forms.Label alunoMatriculaLabel;
        private System.Windows.Forms.ComboBox alunoMatriculaList;
        private System.Windows.Forms.Button selectMateria;
        private System.Windows.Forms.ListBox materiasSelMatriculaList;
        private System.Windows.Forms.Label materiasSeleMatriculaLabel;
        private System.Windows.Forms.Button addMatricula;
    }
}

