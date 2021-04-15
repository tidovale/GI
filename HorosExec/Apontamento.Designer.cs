
namespace HorosExec
{
    partial class Apontamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumAtividade = new System.Windows.Forms.TextBox();
            this.btApontar = new System.Windows.Forms.Button();
            this.tbQtde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCodProduto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDescProd = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbPrioridade = new System.Windows.Forms.Label();
            this.lbEstampo = new System.Windows.Forms.Label();
            this.lbMP = new System.Windows.Forms.Label();
            this.lbFabrica = new System.Windows.Forms.Label();
            this.lbQtde = new System.Windows.Forms.Label();
            this.lbObs = new System.Windows.Forms.Label();
            this.btFi = new System.Windows.Forms.Button();
            this.btDesenho = new System.Windows.Forms.Button();
            this.lbJustificativa = new System.Windows.Forms.Label();
            this.cbJustificativa = new System.Windows.Forms.ComboBox();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.lbObsJustificativa = new System.Windows.Forms.Label();
            this.lbAtividade = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbOP = new System.Windows.Forms.Label();
            this.lbPrioridadeCor = new System.Windows.Forms.Label();
            this.lbSequencia = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAviso = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Atividade";
            // 
            // tbNumAtividade
            // 
            this.tbNumAtividade.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumAtividade.Location = new System.Drawing.Point(12, 34);
            this.tbNumAtividade.MaxLength = 8;
            this.tbNumAtividade.Name = "tbNumAtividade";
            this.tbNumAtividade.Size = new System.Drawing.Size(114, 36);
            this.tbNumAtividade.TabIndex = 0;
            this.tbNumAtividade.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNumAtividade_KeyUp);
            // 
            // btApontar
            // 
            this.btApontar.BackColor = System.Drawing.Color.LightGreen;
            this.btApontar.Enabled = false;
            this.btApontar.Location = new System.Drawing.Point(565, 160);
            this.btApontar.Name = "btApontar";
            this.btApontar.Size = new System.Drawing.Size(97, 47);
            this.btApontar.TabIndex = 9;
            this.btApontar.Text = "APONTAR";
            this.btApontar.UseVisualStyleBackColor = false;
            this.btApontar.Click += new System.EventHandler(this.btApontar_Click);
            // 
            // tbQtde
            // 
            this.tbQtde.Enabled = false;
            this.tbQtde.Location = new System.Drawing.Point(336, 39);
            this.tbQtde.MaxLength = 6;
            this.tbQtde.Name = "tbQtde";
            this.tbQtde.Size = new System.Drawing.Size(54, 23);
            this.tbQtde.TabIndex = 5;
            this.tbQtde.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Qtde";
            // 
            // cbMotivo
            // 
            this.cbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotivo.Enabled = false;
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbMotivo.Location = new System.Drawing.Point(11, 39);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(310, 23);
            this.cbMotivo.TabIndex = 4;
            this.cbMotivo.SelectedValueChanged += new System.EventHandler(this.cbMotivo_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Motivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Peso (kg)";
            // 
            // tbPeso
            // 
            this.tbPeso.Enabled = false;
            this.tbPeso.Location = new System.Drawing.Point(411, 39);
            this.tbPeso.MaxLength = 6;
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(56, 23);
            this.tbPeso.TabIndex = 6;
            this.tbPeso.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Código Produto:";
            // 
            // lbCodProduto
            // 
            this.lbCodProduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCodProduto.Location = new System.Drawing.Point(98, 98);
            this.lbCodProduto.Name = "lbCodProduto";
            this.lbCodProduto.Size = new System.Drawing.Size(60, 15);
            this.lbCodProduto.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(200, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Descrição:";
            // 
            // lbDescProd
            // 
            this.lbDescProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescProd.Location = new System.Drawing.Point(261, 98);
            this.lbDescProd.Name = "lbDescProd";
            this.lbDescProd.Size = new System.Drawing.Size(364, 15);
            this.lbDescProd.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(324, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Obs:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(327, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "MP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(205, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Estampo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(225, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Qtde:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(51, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Fábrica:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(35, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Prioridade:";
            // 
            // lbPrioridade
            // 
            this.lbPrioridade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPrioridade.Location = new System.Drawing.Point(98, 125);
            this.lbPrioridade.Name = "lbPrioridade";
            this.lbPrioridade.Size = new System.Drawing.Size(101, 15);
            this.lbPrioridade.TabIndex = 31;
            // 
            // lbEstampo
            // 
            this.lbEstampo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEstampo.Location = new System.Drawing.Point(261, 125);
            this.lbEstampo.Name = "lbEstampo";
            this.lbEstampo.Size = new System.Drawing.Size(60, 15);
            this.lbEstampo.TabIndex = 32;
            // 
            // lbMP
            // 
            this.lbMP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMP.Location = new System.Drawing.Point(369, 125);
            this.lbMP.Name = "lbMP";
            this.lbMP.Size = new System.Drawing.Size(284, 15);
            this.lbMP.TabIndex = 33;
            // 
            // lbFabrica
            // 
            this.lbFabrica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFabrica.Location = new System.Drawing.Point(98, 154);
            this.lbFabrica.Name = "lbFabrica";
            this.lbFabrica.Size = new System.Drawing.Size(60, 15);
            this.lbFabrica.TabIndex = 34;
            // 
            // lbQtde
            // 
            this.lbQtde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQtde.Location = new System.Drawing.Point(261, 154);
            this.lbQtde.Name = "lbQtde";
            this.lbQtde.Size = new System.Drawing.Size(60, 15);
            this.lbQtde.TabIndex = 35;
            // 
            // lbObs
            // 
            this.lbObs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbObs.Location = new System.Drawing.Point(369, 154);
            this.lbObs.Name = "lbObs";
            this.lbObs.Size = new System.Drawing.Size(284, 46);
            this.lbObs.TabIndex = 36;
            // 
            // btFi
            // 
            this.btFi.Enabled = false;
            this.btFi.Location = new System.Drawing.Point(11, 188);
            this.btFi.Name = "btFi";
            this.btFi.Size = new System.Drawing.Size(75, 23);
            this.btFi.TabIndex = 0;
            this.btFi.Text = "FI";
            this.btFi.UseVisualStyleBackColor = true;
            // 
            // btDesenho
            // 
            this.btDesenho.Enabled = false;
            this.btDesenho.Location = new System.Drawing.Point(102, 188);
            this.btDesenho.Name = "btDesenho";
            this.btDesenho.Size = new System.Drawing.Size(75, 23);
            this.btDesenho.TabIndex = 3;
            this.btDesenho.Text = "DESENHO";
            this.btDesenho.UseVisualStyleBackColor = true;
            // 
            // lbJustificativa
            // 
            this.lbJustificativa.AutoSize = true;
            this.lbJustificativa.Enabled = false;
            this.lbJustificativa.Location = new System.Drawing.Point(9, 75);
            this.lbJustificativa.Name = "lbJustificativa";
            this.lbJustificativa.Size = new System.Drawing.Size(68, 15);
            this.lbJustificativa.TabIndex = 40;
            this.lbJustificativa.Text = "Justificativa";
            // 
            // cbJustificativa
            // 
            this.cbJustificativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJustificativa.Enabled = false;
            this.cbJustificativa.FormattingEnabled = true;
            this.cbJustificativa.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbJustificativa.Location = new System.Drawing.Point(11, 93);
            this.cbJustificativa.Name = "cbJustificativa";
            this.cbJustificativa.Size = new System.Drawing.Size(310, 23);
            this.cbJustificativa.TabIndex = 7;
            // 
            // tbObs
            // 
            this.tbObs.Enabled = false;
            this.tbObs.Location = new System.Drawing.Point(336, 93);
            this.tbObs.MaxLength = 300;
            this.tbObs.Multiline = true;
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(326, 61);
            this.tbObs.TabIndex = 8;
            // 
            // lbObsJustificativa
            // 
            this.lbObsJustificativa.AutoSize = true;
            this.lbObsJustificativa.Enabled = false;
            this.lbObsJustificativa.Location = new System.Drawing.Point(336, 75);
            this.lbObsJustificativa.Name = "lbObsJustificativa";
            this.lbObsJustificativa.Size = new System.Drawing.Size(28, 15);
            this.lbObsJustificativa.TabIndex = 42;
            this.lbObsJustificativa.Text = "Obs";
            // 
            // lbAtividade
            // 
            this.lbAtividade.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAtividade.Location = new System.Drawing.Point(153, 10);
            this.lbAtividade.Name = "lbAtividade";
            this.lbAtividade.Size = new System.Drawing.Size(509, 32);
            this.lbAtividade.TabIndex = 43;
            // 
            // lbDescricao
            // 
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescricao.Location = new System.Drawing.Point(102, 42);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(560, 47);
            this.lbDescricao.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbOP);
            this.panel1.Controls.Add(this.lbPrioridadeCor);
            this.panel1.Controls.Add(this.lbSequencia);
            this.panel1.Controls.Add(this.btFi);
            this.panel1.Controls.Add(this.lbDescricao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbAtividade);
            this.panel1.Controls.Add(this.lbCodProduto);
            this.panel1.Controls.Add(this.lbDescProd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btDesenho);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbObs);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbQtde);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbFabrica);
            this.panel1.Controls.Add(this.lbPrioridade);
            this.panel1.Controls.Add(this.lbMP);
            this.panel1.Controls.Add(this.lbEstampo);
            this.panel1.Location = new System.Drawing.Point(15, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 226);
            this.panel1.TabIndex = 45;
            // 
            // lbOP
            // 
            this.lbOP.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOP.Location = new System.Drawing.Point(7, 10);
            this.lbOP.Name = "lbOP";
            this.lbOP.Size = new System.Drawing.Size(82, 32);
            this.lbOP.TabIndex = 46;
            // 
            // lbPrioridadeCor
            // 
            this.lbPrioridadeCor.Location = new System.Drawing.Point(659, -1);
            this.lbPrioridadeCor.Name = "lbPrioridadeCor";
            this.lbPrioridadeCor.Size = new System.Drawing.Size(17, 226);
            this.lbPrioridadeCor.TabIndex = 43;
            // 
            // lbSequencia
            // 
            this.lbSequencia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSequencia.Location = new System.Drawing.Point(102, 10);
            this.lbSequencia.Name = "lbSequencia";
            this.lbSequencia.Size = new System.Drawing.Size(44, 32);
            this.lbSequencia.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(15, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "ORDEM DE PRODUÇÃO";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbMotivo);
            this.panel2.Controls.Add(this.tbQtde);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btApontar);
            this.panel2.Controls.Add(this.lbObsJustificativa);
            this.panel2.Controls.Add(this.tbPeso);
            this.panel2.Controls.Add(this.tbObs);
            this.panel2.Controls.Add(this.lbJustificativa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbJustificativa);
            this.panel2.Location = new System.Drawing.Point(15, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 218);
            this.panel2.TabIndex = 47;
            // 
            // lbAviso
            // 
            this.lbAviso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAviso.Location = new System.Drawing.Point(135, 23);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(556, 47);
            this.lbAviso.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(15, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 48;
            this.label14.Text = "APONTAMENTO";
            // 
            // Apontamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 585);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbNumAtividade);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Apontamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apontamento";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Apontamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumAtividade;
        private System.Windows.Forms.Button btApontar;
        private System.Windows.Forms.TextBox tbQtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMotivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCodProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDescProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbPrioridade;
        private System.Windows.Forms.Label lbEstampo;
        private System.Windows.Forms.Label lbMP;
        private System.Windows.Forms.Label lbFabrica;
        private System.Windows.Forms.Label lbQtde;
        private System.Windows.Forms.Label lbObs;
        private System.Windows.Forms.Button btFi;
        private System.Windows.Forms.Button btDesenho;
        private System.Windows.Forms.Label lbJustificativa;
        private System.Windows.Forms.ComboBox cbJustificativa;
        private System.Windows.Forms.TextBox tbObs;
        private System.Windows.Forms.Label lbObsJustificativa;
        private System.Windows.Forms.Label lbAtividade;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbSequencia;
        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.Label lbPrioridadeCor;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label lbOP;
    }
}