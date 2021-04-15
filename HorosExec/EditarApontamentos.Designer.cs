
namespace HorosExec
{
    partial class EditarApontamentos
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
            this.dgvApontamento = new System.Windows.Forms.DataGridView();
            this.IdRoteiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFabrica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeSetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdApontamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodSetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApontamento)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNumOP
            // 
            this.tbNumOP.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNumOP.Location = new System.Drawing.Point(12, 30);
            this.tbNumOP.MaxLength = 8;
            this.tbNumOP.Name = "tbNumOP";
            this.tbNumOP.Size = new System.Drawing.Size(114, 36);
            this.tbNumOP.TabIndex = 3;
            this.tbNumOP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNumOP_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nº OP";
            // 
            // dgvApontamento
            // 
            this.dgvApontamento.AllowUserToAddRows = false;
            this.dgvApontamento.AllowUserToDeleteRows = false;
            this.dgvApontamento.AllowUserToResizeRows = false;
            this.dgvApontamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApontamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRoteiro,
            this.IdFabrica,
            this.Sequencia,
            this.NomeSetor,
            this.DescricaoAtividade,
            this.DataCadastro,
            this.Motivo,
            this.Qtde,
            this.Peso,
            this.IdOP,
            this.IdApontamento,
            this.IdMotivo,
            this.CodSetor,
            this.CodAtividade,
            this.Usuario});
            this.dgvApontamento.Location = new System.Drawing.Point(12, 82);
            this.dgvApontamento.MultiSelect = false;
            this.dgvApontamento.Name = "dgvApontamento";
            this.dgvApontamento.ReadOnly = true;
            this.dgvApontamento.RowHeadersVisible = false;
            this.dgvApontamento.RowTemplate.Height = 25;
            this.dgvApontamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApontamento.Size = new System.Drawing.Size(1141, 449);
            this.dgvApontamento.TabIndex = 5;
            this.dgvApontamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApontamento_CellDoubleClick);
            // 
            // IdRoteiro
            // 
            this.IdRoteiro.DataPropertyName = "IdRoteiro";
            this.IdRoteiro.HeaderText = "Id";
            this.IdRoteiro.Name = "IdRoteiro";
            this.IdRoteiro.ReadOnly = true;
            this.IdRoteiro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.IdRoteiro.Width = 50;
            // 
            // IdFabrica
            // 
            this.IdFabrica.DataPropertyName = "IdFabrica";
            this.IdFabrica.HeaderText = "Fabrica";
            this.IdFabrica.Name = "IdFabrica";
            this.IdFabrica.ReadOnly = true;
            this.IdFabrica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.IdFabrica.Width = 50;
            // 
            // Sequencia
            // 
            this.Sequencia.DataPropertyName = "Sequencia";
            this.Sequencia.HeaderText = "Sequencia";
            this.Sequencia.Name = "Sequencia";
            this.Sequencia.ReadOnly = true;
            this.Sequencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Sequencia.Width = 70;
            // 
            // NomeSetor
            // 
            this.NomeSetor.DataPropertyName = "NomeSetor";
            this.NomeSetor.HeaderText = "Setor";
            this.NomeSetor.Name = "NomeSetor";
            this.NomeSetor.ReadOnly = true;
            this.NomeSetor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NomeSetor.Width = 200;
            // 
            // DescricaoAtividade
            // 
            this.DescricaoAtividade.DataPropertyName = "DescricaoAtividade";
            this.DescricaoAtividade.HeaderText = "Atividade";
            this.DescricaoAtividade.Name = "DescricaoAtividade";
            this.DescricaoAtividade.ReadOnly = true;
            this.DescricaoAtividade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DescricaoAtividade.Width = 270;
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "DataCadastro";
            this.DataCadastro.HeaderText = "Data";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.ReadOnly = true;
            this.DataCadastro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Motivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Motivo.Width = 180;
            // 
            // Qtde
            // 
            this.Qtde.DataPropertyName = "Qtde";
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            this.Qtde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Qtde.Width = 50;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Peso.Width = 50;
            // 
            // IdOP
            // 
            this.IdOP.DataPropertyName = "IdOP";
            this.IdOP.HeaderText = "IdOP";
            this.IdOP.Name = "IdOP";
            this.IdOP.ReadOnly = true;
            this.IdOP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.IdOP.Visible = false;
            // 
            // IdApontamento
            // 
            this.IdApontamento.DataPropertyName = "IdApontamento";
            this.IdApontamento.HeaderText = "IdApontamento";
            this.IdApontamento.Name = "IdApontamento";
            this.IdApontamento.ReadOnly = true;
            this.IdApontamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.IdApontamento.Visible = false;
            this.IdApontamento.Width = 50;
            // 
            // IdMotivo
            // 
            this.IdMotivo.DataPropertyName = "IdMotivo";
            this.IdMotivo.HeaderText = "IdMotivo";
            this.IdMotivo.Name = "IdMotivo";
            this.IdMotivo.ReadOnly = true;
            this.IdMotivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.IdMotivo.Visible = false;
            // 
            // CodSetor
            // 
            this.CodSetor.DataPropertyName = "CodSetor";
            this.CodSetor.HeaderText = "CodSetor";
            this.CodSetor.Name = "CodSetor";
            this.CodSetor.ReadOnly = true;
            this.CodSetor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CodSetor.Visible = false;
            // 
            // CodAtividade
            // 
            this.CodAtividade.DataPropertyName = "CodAtividade";
            this.CodAtividade.HeaderText = "CodAtividade";
            this.CodAtividade.Name = "CodAtividade";
            this.CodAtividade.ReadOnly = true;
            this.CodAtividade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CodAtividade.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // brAtualizar
            // 
            this.brAtualizar.Location = new System.Drawing.Point(1056, 53);
            this.brAtualizar.Name = "brAtualizar";
            this.brAtualizar.Size = new System.Drawing.Size(97, 23);
            this.brAtualizar.TabIndex = 6;
            this.brAtualizar.Text = "Atualizar Tela";
            this.brAtualizar.UseVisualStyleBackColor = true;
            this.brAtualizar.Click += new System.EventHandler(this.brAtualizar_Click);
            // 
            // EditarApontamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 538);
            this.Controls.Add(this.brAtualizar);
            this.Controls.Add(this.dgvApontamento);
            this.Controls.Add(this.tbNumOP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditarApontamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apontamento";
            this.Load += new System.EventHandler(this.EditarApontamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApontamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumOP;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvApontamento;
        private System.Windows.Forms.Button brAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRoteiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFabrica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSetor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdApontamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSetor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}