namespace TrabalhoSQL
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
            Salvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textNome = new TextBox();
            textCodigo = new TextBox();
            textColecao = new TextBox();
            textCondicao = new TextBox();
            textLocalizacao = new TextBox();
            label6 = new Label();
            textFuncionario = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBuscaNome = new TextBox();
            label10 = new Label();
            textBuscaCodigo = new TextBox();
            Buscar = new Button();
            listaBusca = new ListView();
            label11 = new Label();
            textBuscaColecao = new TextBox();
            Listar = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textExcluirNome = new TextBox();
            textExcluirCodigo = new TextBox();
            Excluir = new Button();
            Alterar = new Button();
            SuspendLayout();
            // 
            // Salvar
            // 
            Salvar.Location = new Point(163, 395);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(75, 23);
            Salvar.TabIndex = 0;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = true;
            Salvar.Click += Salvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 50);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 111);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 171);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Colecao:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 228);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 4;
            label4.Text = "Condicao:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 287);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 5;
            label5.Text = "Localizacao:";
            // 
            // textNome
            // 
            textNome.Location = new Point(22, 68);
            textNome.Name = "textNome";
            textNome.Size = new Size(216, 23);
            textNome.TabIndex = 6;
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(22, 129);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(216, 23);
            textCodigo.TabIndex = 7;
            // 
            // textColecao
            // 
            textColecao.Location = new Point(22, 189);
            textColecao.Name = "textColecao";
            textColecao.Size = new Size(216, 23);
            textColecao.TabIndex = 8;
            // 
            // textCondicao
            // 
            textCondicao.Location = new Point(22, 246);
            textCondicao.Name = "textCondicao";
            textCondicao.Size = new Size(216, 23);
            textCondicao.TabIndex = 9;
            // 
            // textLocalizacao
            // 
            textLocalizacao.Location = new Point(22, 305);
            textLocalizacao.Name = "textLocalizacao";
            textLocalizacao.Size = new Size(216, 23);
            textLocalizacao.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 348);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 11;
            label6.Text = "Funcionario:";
            // 
            // textFuncionario
            // 
            textFuncionario.Location = new Point(22, 366);
            textFuncionario.Name = "textFuncionario";
            textFuncionario.Size = new Size(216, 23);
            textFuncionario.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(383, 19);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 13;
            label7.Text = "Buscar objetos por:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(383, 41);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 14;
            label8.Text = "Nome:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 67);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 15;
            label9.Text = "Codigo:";
            // 
            // textBuscaNome
            // 
            textBuscaNome.Location = new Point(442, 38);
            textBuscaNome.Name = "textBuscaNome";
            textBuscaNome.Size = new Size(324, 23);
            textBuscaNome.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 19);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 17;
            label10.Text = "Inserir Objeto:";
            // 
            // textBuscaCodigo
            // 
            textBuscaCodigo.Location = new Point(442, 67);
            textBuscaCodigo.Name = "textBuscaCodigo";
            textBuscaCodigo.Size = new Size(324, 23);
            textBuscaCodigo.TabIndex = 18;
            // 
            // Buscar
            // 
            Buscar.Location = new Point(691, 125);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(75, 23);
            Buscar.TabIndex = 19;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            Buscar.Click += Buscar_Click;
            // 
            // listaBusca
            // 
            listaBusca.Location = new Point(301, 154);
            listaBusca.Name = "listaBusca";
            listaBusca.Size = new Size(786, 289);
            listaBusca.TabIndex = 20;
            listaBusca.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(383, 99);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 21;
            label11.Text = "Colecao:";
            // 
            // textBuscaColecao
            // 
            textBuscaColecao.Location = new Point(442, 96);
            textBuscaColecao.Name = "textBuscaColecao";
            textBuscaColecao.Size = new Size(324, 23);
            textBuscaColecao.TabIndex = 22;
            // 
            // Listar
            // 
            Listar.Location = new Point(301, 125);
            Listar.Name = "Listar";
            Listar.Size = new Size(75, 23);
            Listar.TabIndex = 23;
            Listar.Text = "Listar ";
            Listar.UseVisualStyleBackColor = true;
            Listar.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(802, 19);
            label12.Name = "label12";
            label12.Size = new Size(103, 15);
            label12.TabIndex = 24;
            label12.Text = "Excluir objeto por:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(802, 71);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 25;
            label13.Text = "Nome:\r\n";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(802, 99);
            label14.Name = "label14";
            label14.Size = new Size(49, 30);
            label14.TabIndex = 26;
            label14.Text = "Codigo:\r\n\r\n";
            // 
            // textExcluirNome
            // 
            textExcluirNome.Location = new Point(851, 67);
            textExcluirNome.Name = "textExcluirNome";
            textExcluirNome.Size = new Size(236, 23);
            textExcluirNome.TabIndex = 27;
            // 
            // textExcluirCodigo
            // 
            textExcluirCodigo.Location = new Point(851, 96);
            textExcluirCodigo.Name = "textExcluirCodigo";
            textExcluirCodigo.Size = new Size(236, 23);
            textExcluirCodigo.TabIndex = 28;
            // 
            // Excluir
            // 
            Excluir.Location = new Point(1012, 125);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(75, 23);
            Excluir.TabIndex = 29;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += Excluir_Click;
            // 
            // Alterar
            // 
            Alterar.Location = new Point(89, 395);
            Alterar.Name = "Alterar";
            Alterar.Size = new Size(68, 23);
            Alterar.TabIndex = 30;
            Alterar.Text = "Alterar";
            Alterar.UseVisualStyleBackColor = true;
            Alterar.Click += Alterar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 451);
            Controls.Add(Alterar);
            Controls.Add(Excluir);
            Controls.Add(textExcluirCodigo);
            Controls.Add(textExcluirNome);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(Listar);
            Controls.Add(textBuscaColecao);
            Controls.Add(label11);
            Controls.Add(listaBusca);
            Controls.Add(Buscar);
            Controls.Add(textBuscaCodigo);
            Controls.Add(label10);
            Controls.Add(textBuscaNome);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textFuncionario);
            Controls.Add(label6);
            Controls.Add(textLocalizacao);
            Controls.Add(textCondicao);
            Controls.Add(textColecao);
            Controls.Add(textCodigo);
            Controls.Add(textNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Salvar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Salvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textNome;
        private TextBox textCodigo;
        private TextBox textColecao;
        private TextBox textCondicao;
        private TextBox textLocalizacao;
        private Label label6;
        private TextBox textFuncionario;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBuscaNome;
        private Label label10;
        private TextBox textBuscaCodigo;
        private Button Buscar;
        private ListView listaBusca;
        private Label label11;
        private TextBox textBuscaColecao;
        private Button Listar;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textExcluirNome;
        private TextBox textExcluirCodigo;
        private Button Excluir;
        private Button Alterar;
    }
}