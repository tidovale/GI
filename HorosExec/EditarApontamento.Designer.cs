
namespace HorosExec
{
    partial class EditarApontamento
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
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            this.tbQtde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.dgvJustificativas = new System.Windows.Forms.DataGridView();
            this.Justificativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdApontamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdJustificativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.lbFabrica = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSequencia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAtividade = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSetor = new System.Windows.Forms.Label();
            this.lbSeq = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.MaskedTextBox();
            this.lbOP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJustificativas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // cbMotivo
            // 
            this.cbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbMotivo.Location = new System.Drawing.Point(178, 182);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(234, 23);
            this.cbMotivo.TabIndex = 1;
            // 
            // tbQtde
            // 
            this.tbQtde.Location = new System.Drawing.Point(452, 182);
            this.tbQtde.MaxLength = 6;
            this.tbQtde.Name = "tbQtde";
            this.tbQtde.Size = new System.Drawing.Size(54, 23);
            this.tbQtde.TabIndex = 2;
            this.tbQtde.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Qtde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Motivo";
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(527, 182);
            this.tbPeso.MaxLength = 6;
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(56, 23);
            this.tbPeso.TabIndex = 3;
            this.tbPeso.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Peso (kg)";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(427, 338);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 4;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(508, 338);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // dgvJustificativas
            // 
            this.dgvJustificativas.AllowUserToAddRows = false;
            this.dgvJustificativas.AllowUserToDeleteRows = false;
            this.dgvJustificativas.AllowUserToResizeRows = false;
            this.dgvJustificativas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJustificativas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Justificativa,
            this.DataCadastro,
            this.Mensagem,
            this.id,
            this.IdApontamento,
            this.IdJustificativa});
            this.dgvJustificativas.Enabled = false;
            this.dgvJustificativas.Location = new System.Drawing.Point(12, 221);
            this.dgvJustificativas.MultiSelect = false;
            this.dgvJustificativas.Name = "dgvJustificativas";
            this.dgvJustificativas.ReadOnly = true;
            this.dgvJustificativas.RowHeadersVisible = false;
            this.dgvJustificativas.RowTemplate.Height = 25;
            this.dgvJustificativas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJustificativas.Size = new System.Drawing.Size(571, 109);
            this.dgvJustificativas.TabIndex = 21;
            // 
            // Justificativa
            // 
            this.Justificativa.DataPropertyName = "Justificativa";
            this.Justificativa.HeaderText = "Justificativa";
            this.Justificativa.Name = "Justificativa";
            this.Justificativa.ReadOnly = true;
            this.Justificativa.Width = 200;
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "DataCadastro";
            this.DataCadastro.HeaderText = "Data";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.ReadOnly = true;
            // 
            // Mensagem
            // 
            this.Mensagem.DataPropertyName = "Mensagem";
            this.Mensagem.HeaderText = "Mensagem";
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.ReadOnly = true;
            this.Mensagem.Width = 250;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // IdApontamento
            // 
            this.IdApontamento.DataPropertyName = "IdApontamento";
            this.IdApontamento.HeaderText = "IdApontamento";
            this.IdApontamento.Name = "IdApontamento";
            this.IdApontamento.ReadOnly = true;
            this.IdApontamento.Visible = false;
            // 
            // IdJustificativa
            // 
            this.IdJustificativa.DataPropertyName = "IdJustificativa";
            this.IdJustificativa.HeaderText = "IdJustificativa";
            this.IdJustificativa.Name = "IdJustificativa";
            this.IdJustificativa.ReadOnly = true;
            this.IdJustificativa.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(18, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 35;
            this.label11.Text = "Fábrica:";
            // 
            // lbFabrica
            // 
            this.lbFabrica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFabrica.Location = new System.Drawing.Point(68, 33);
            this.lbFabrica.Name = "lbFabrica";
            this.lbFabrica.Size = new System.Drawing.Size(124, 15);
            this.lbFabrica.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Sequência:";
            // 
            // lbSequencia
            // 
            this.lbSequencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSequencia.Location = new System.Drawing.Point(-37, -87);
            this.lbSequencia.Name = "lbSequencia";
            this.lbSequencia.Size = new System.Drawing.Size(60, 15);
            this.lbSequencia.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Setor:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(-37, -62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "Atividade:";
            // 
            // lbAtividade
            // 
            this.lbAtividade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAtividade.Location = new System.Drawing.Point(68, 108);
            this.lbAtividade.Name = "lbAtividade";
            this.lbAtividade.Size = new System.Drawing.Size(340, 15);
            this.lbAtividade.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(16, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 43;
            this.label12.Text = "Usuário:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsuario.Location = new System.Drawing.Point(68, 135);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(124, 15);
            this.lbUsuario.TabIndex = 44;
            // 
            // lbSetor
            // 
            this.lbSetor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSetor.Location = new System.Drawing.Point(68, 82);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(340, 15);
            this.lbSetor.TabIndex = 45;
            // 
            // lbSeq
            // 
            this.lbSeq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSeq.Location = new System.Drawing.Point(68, 57);
            this.lbSeq.Name = "lbSeq";
            this.lbSeq.Size = new System.Drawing.Size(124, 15);
            this.lbSeq.TabIndex = 46;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(16, 182);
            this.tbData.Mask = "00/00/0000 90:00";
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 23);
            this.tbData.TabIndex = 47;
            this.tbData.ValidatingType = typeof(System.DateTime);
            // 
            // lbOP
            // 
            this.lbOP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOP.Location = new System.Drawing.Point(68, 9);
            this.lbOP.Name = "lbOP";
            this.lbOP.Size = new System.Drawing.Size(82, 15);
            this.lbOP.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "OP:";
            // 
            // EditarApontamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 369);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbOP);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.lbSeq);
            this.Controls.Add(this.lbSetor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbAtividade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSequencia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbFabrica);
            this.Controls.Add(this.dgvJustificativas);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.cbMotivo);
            this.Controls.Add(this.tbQtde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditarApontamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarApontamento";
            this.Load += new System.EventHandler(this.EditarApontamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJustificativas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.DataGridView dgvJustificativas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSequencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label uen;
        public System.Windows.Forms.Label lbFabrica;
        public System.Windows.Forms.Label lbSeq;
        public System.Windows.Forms.Label lbSetor;
        public System.Windows.Forms.Label lbAtividade;
        public System.Windows.Forms.Label lbUsuario;
        public System.Windows.Forms.ComboBox cbMotivo;
        public System.Windows.Forms.TextBox tbQtde;
        public System.Windows.Forms.TextBox tbPeso;
        public System.Windows.Forms.MaskedTextBox tbData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Justificativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdApontamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdJustificativa;
        public System.Windows.Forms.Label lbOP;
        private System.Windows.Forms.Label label6;
    }
}