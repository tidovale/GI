
namespace HorosExec
{
    partial class EditarOP
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
            this.tbNumOP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.tbQtde = new System.Windows.Forms.TextBox();
            this.cbFabrica = new System.Windows.Forms.ComboBox();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.lbDescProd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCodProduto = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbEstampo = new System.Windows.Forms.Label();
            this.lbMateriaPrima = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumOP
            // 
            this.tbNumOP.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumOP.Location = new System.Drawing.Point(21, 34);
            this.tbNumOP.MaxLength = 8;
            this.tbNumOP.Name = "tbNumOP";
            this.tbNumOP.Size = new System.Drawing.Size(114, 36);
            this.tbNumOP.TabIndex = 0;
            this.tbNumOP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNumOP_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº OP";
            // 
            // tbObs
            // 
            this.tbObs.Location = new System.Drawing.Point(256, 161);
            this.tbObs.Multiline = true;
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(291, 49);
            this.tbObs.TabIndex = 5;
            // 
            // tbQtde
            // 
            this.tbQtde.Location = new System.Drawing.Point(630, 118);
            this.tbQtde.Name = "tbQtde";
            this.tbQtde.Size = new System.Drawing.Size(54, 23);
            this.tbQtde.TabIndex = 4;
            // 
            // cbFabrica
            // 
            this.cbFabrica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFabrica.FormattingEnabled = true;
            this.cbFabrica.Items.AddRange(new object[] {
            "1",
            "7"});
            this.cbFabrica.Location = new System.Drawing.Point(630, 58);
            this.cbFabrica.Name = "cbFabrica";
            this.cbFabrica.Size = new System.Drawing.Size(121, 23);
            this.cbFabrica.TabIndex = 2;
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Items.AddRange(new object[] {
            "1- Vermelho",
            "2- Amarelo",
            "3- Verde"});
            this.cbPrioridade.Location = new System.Drawing.Point(630, 28);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(121, 23);
            this.cbPrioridade.TabIndex = 1;
            // 
            // lbDescProd
            // 
            this.lbDescProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescProd.Location = new System.Drawing.Point(249, 55);
            this.lbDescProd.Name = "lbDescProd";
            this.lbDescProd.Size = new System.Drawing.Size(298, 15);
            this.lbDescProd.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(187, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Descrição:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(563, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Prioridade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(579, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Fábrica:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(591, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 27;
            this.label10.Text = "Qtde:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(192, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Estampo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(220, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "MP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(221, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "Obs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(153, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Código Produto:";
            // 
            // lbCodProduto
            // 
            this.lbCodProduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCodProduto.Location = new System.Drawing.Point(249, 34);
            this.lbCodProduto.Name = "lbCodProduto";
            this.lbCodProduto.Size = new System.Drawing.Size(60, 15);
            this.lbCodProduto.TabIndex = 20;
            // 
            // btSalvar
            // 
            this.btSalvar.Enabled = false;
            this.btSalvar.Location = new System.Drawing.Point(678, 187);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(597, 187);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // lbEstampo
            // 
            this.lbEstampo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEstampo.Location = new System.Drawing.Point(249, 77);
            this.lbEstampo.Name = "lbEstampo";
            this.lbEstampo.Size = new System.Drawing.Size(60, 15);
            this.lbEstampo.TabIndex = 52;
            // 
            // lbMateriaPrima
            // 
            this.lbMateriaPrima.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMateriaPrima.Location = new System.Drawing.Point(249, 102);
            this.lbMateriaPrima.Name = "lbMateriaPrima";
            this.lbMateriaPrima.Size = new System.Drawing.Size(60, 15);
            this.lbMateriaPrima.TabIndex = 53;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Aberta",
            "Andamento",
            "Cancelada",
            "Fechada"});
            this.cbStatus.Location = new System.Drawing.Point(630, 89);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 23);
            this.cbStatus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(585, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 55;
            this.label2.Text = "Status:";
            // 
            // EditarOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 222);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbObs);
            this.Controls.Add(this.lbMateriaPrima);
            this.Controls.Add(this.tbQtde);
            this.Controls.Add(this.lbEstampo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbFabrica);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbPrioridade);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbNumOP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCodProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbDescProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditarOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar OP";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ApontamentoEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCodProduto;
        private System.Windows.Forms.Label lbDescProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.ComboBox cbFabrica;
        private System.Windows.Forms.TextBox tbObs;
        private System.Windows.Forms.TextBox tbQtde;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbEstampo;
        private System.Windows.Forms.Label lbMateriaPrima;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label2;
    }
}