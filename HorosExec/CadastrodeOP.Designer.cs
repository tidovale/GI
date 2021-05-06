
namespace HorosExec
{
    partial class CadastrodeOP
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
            this.dgvRoteiro = new System.Windows.Forms.DataGridView();
            this.Sequencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabrica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeSetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodSetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCodProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDescProd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFabrica = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQtde = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiOP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOPImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOPEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmApontamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApontar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditarApontamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsdmConfigImpressoras = new System.Windows.Forms.ToolStripMenuItem();
            this.pbIdRoteiro = new System.Windows.Forms.PictureBox();
            this.pdOpRoteiro = new System.Drawing.Printing.PrintDocument();
            this.pdOpEtiqueta = new System.Drawing.Printing.PrintDocument();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEstampo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMateriaPrima = new System.Windows.Forms.Label();
            this.tbOpObs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tsmiImprimirOP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditarOP = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoteiro)).BeginInit();
            this.ss.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdRoteiro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoteiro
            // 
            this.dgvRoteiro.AllowUserToAddRows = false;
            this.dgvRoteiro.AllowUserToDeleteRows = false;
            this.dgvRoteiro.AllowUserToResizeRows = false;
            this.dgvRoteiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoteiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sequencia,
            this.Fabrica,
            this.NomeSetor,
            this.DescricaoAtividade,
            this.CodSetor,
            this.CodAtividade});
            this.dgvRoteiro.Location = new System.Drawing.Point(12, 162);
            this.dgvRoteiro.MultiSelect = false;
            this.dgvRoteiro.Name = "dgvRoteiro";
            this.dgvRoteiro.ReadOnly = true;
            this.dgvRoteiro.RowHeadersVisible = false;
            this.dgvRoteiro.RowTemplate.Height = 25;
            this.dgvRoteiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoteiro.Size = new System.Drawing.Size(1031, 387);
            this.dgvRoteiro.TabIndex = 15;
            // 
            // Sequencia
            // 
            this.Sequencia.DataPropertyName = "Sequencia";
            this.Sequencia.HeaderText = "Sequência";
            this.Sequencia.Name = "Sequencia";
            this.Sequencia.ReadOnly = true;
            this.Sequencia.Width = 70;
            // 
            // Fabrica
            // 
            this.Fabrica.DataPropertyName = "Fabrica";
            this.Fabrica.HeaderText = "Fabrica";
            this.Fabrica.Name = "Fabrica";
            this.Fabrica.ReadOnly = true;
            this.Fabrica.Width = 55;
            // 
            // NomeSetor
            // 
            this.NomeSetor.DataPropertyName = "NomeSetor";
            this.NomeSetor.HeaderText = "Setor";
            this.NomeSetor.Name = "NomeSetor";
            this.NomeSetor.ReadOnly = true;
            this.NomeSetor.Width = 197;
            // 
            // DescricaoAtividade
            // 
            this.DescricaoAtividade.DataPropertyName = "DescricaoAtividade";
            this.DescricaoAtividade.HeaderText = "Atividade";
            this.DescricaoAtividade.Name = "DescricaoAtividade";
            this.DescricaoAtividade.ReadOnly = true;
            this.DescricaoAtividade.Width = 685;
            // 
            // CodSetor
            // 
            this.CodSetor.DataPropertyName = "CodSetor";
            this.CodSetor.HeaderText = "CodSetor";
            this.CodSetor.Name = "CodSetor";
            this.CodSetor.ReadOnly = true;
            this.CodSetor.Visible = false;
            // 
            // CodAtividade
            // 
            this.CodAtividade.DataPropertyName = "CodAtividade";
            this.CodAtividade.HeaderText = "CodAtividade";
            this.CodAtividade.Name = "CodAtividade";
            this.CodAtividade.ReadOnly = true;
            this.CodAtividade.Visible = false;
            // 
            // tbCodProd
            // 
            this.tbCodProd.Location = new System.Drawing.Point(108, 39);
            this.tbCodProd.Name = "tbCodProd";
            this.tbCodProd.Size = new System.Drawing.Size(76, 23);
            this.tbCodProd.TabIndex = 0;
            this.tbCodProd.Leave += new System.EventHandler(this.tbCodProd_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Produto:";
            // 
            // lbDescProd
            // 
            this.lbDescProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescProd.Location = new System.Drawing.Point(267, 47);
            this.lbDescProd.Name = "lbDescProd";
            this.lbDescProd.Size = new System.Drawing.Size(395, 15);
            this.lbDescProd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prioridade";
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Items.AddRange(new object[] {
            "1- Vermelho",
            "2- Amarelo",
            "3- Verde"});
            this.cbPrioridade.Location = new System.Drawing.Point(16, 113);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(121, 23);
            this.cbPrioridade.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fábrica";
            // 
            // cbFabrica
            // 
            this.cbFabrica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFabrica.FormattingEnabled = true;
            this.cbFabrica.Items.AddRange(new object[] {
            "1",
            "7"});
            this.cbFabrica.Location = new System.Drawing.Point(158, 113);
            this.cbFabrica.Name = "cbFabrica";
            this.cbFabrica.Size = new System.Drawing.Size(189, 23);
            this.cbFabrica.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Qtde";
            // 
            // tbQtde
            // 
            this.tbQtde.Location = new System.Drawing.Point(364, 113);
            this.tbQtde.MaxLength = 6;
            this.tbQtde.Name = "tbQtde";
            this.tbQtde.Size = new System.Drawing.Size(49, 23);
            this.tbQtde.TabIndex = 4;
            this.tbQtde.Text = "0";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(968, 555);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(202, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descrição:";
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl});
            this.ss.Location = new System.Drawing.Point(0, 587);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(1479, 22);
            this.ss.TabIndex = 16;
            this.ss.Text = "statusStrip1";
            // 
            // tssl
            // 
            this.tssl.Name = "tssl";
            this.tssl.Size = new System.Drawing.Size(118, 17);
            this.tssl.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOP,
            this.tsmApontamento,
            this.tsmConfiguracoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1479, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOP
            // 
            this.tsmiOP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOPImprimir,
            this.tsmiOPEditar});
            this.tsmiOP.Name = "tsmiOP";
            this.tsmiOP.Size = new System.Drawing.Size(35, 20);
            this.tsmiOP.Text = "OP";
            // 
            // tsmiOPImprimir
            // 
            this.tsmiOPImprimir.Name = "tsmiOPImprimir";
            this.tsmiOPImprimir.Size = new System.Drawing.Size(120, 22);
            this.tsmiOPImprimir.Text = "Imprimir";
            this.tsmiOPImprimir.Click += new System.EventHandler(this.tsmiOPImprimir_Click);
            // 
            // tsmiOPEditar
            // 
            this.tsmiOPEditar.Name = "tsmiOPEditar";
            this.tsmiOPEditar.Size = new System.Drawing.Size(120, 22);
            this.tsmiOPEditar.Text = "Editar";
            this.tsmiOPEditar.Click += new System.EventHandler(this.tsmiOPEditar_Click);
            // 
            // tsmApontamento
            // 
            this.tsmApontamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiApontar,
            this.tsmiEditarApontamento});
            this.tsmApontamento.Name = "tsmApontamento";
            this.tsmApontamento.Size = new System.Drawing.Size(93, 20);
            this.tsmApontamento.Text = "Apontamento";
            // 
            // tsmiApontar
            // 
            this.tsmiApontar.Name = "tsmiApontar";
            this.tsmiApontar.Size = new System.Drawing.Size(117, 22);
            this.tsmiApontar.Text = "Apontar";
            this.tsmiApontar.Click += new System.EventHandler(this.tsmiApontar_Click);
            // 
            // tsmiEditarApontamento
            // 
            this.tsmiEditarApontamento.Name = "tsmiEditarApontamento";
            this.tsmiEditarApontamento.Size = new System.Drawing.Size(117, 22);
            this.tsmiEditarApontamento.Text = "Editar";
            this.tsmiEditarApontamento.Click += new System.EventHandler(this.tsmiEditarApontamento_Click);
            // 
            // tsmConfiguracoes
            // 
            this.tsmConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdmConfigImpressoras});
            this.tsmConfiguracoes.Name = "tsmConfiguracoes";
            this.tsmConfiguracoes.Size = new System.Drawing.Size(96, 20);
            this.tsmConfiguracoes.Text = "Configurações";
            // 
            // tsdmConfigImpressoras
            // 
            this.tsdmConfigImpressoras.Name = "tsdmConfigImpressoras";
            this.tsdmConfigImpressoras.Size = new System.Drawing.Size(137, 22);
            this.tsdmConfigImpressoras.Text = "Impressoras";
            this.tsdmConfigImpressoras.Click += new System.EventHandler(this.tsdmConfigImpressoras_Click);
            // 
            // pbIdRoteiro
            // 
            this.pbIdRoteiro.Location = new System.Drawing.Point(968, 100);
            this.pbIdRoteiro.Name = "pbIdRoteiro";
            this.pbIdRoteiro.Size = new System.Drawing.Size(43, 41);
            this.pbIdRoteiro.TabIndex = 18;
            this.pbIdRoteiro.TabStop = false;
            this.pbIdRoteiro.Visible = false;
            // 
            // pdOpRoteiro
            // 
            this.pdOpRoteiro.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdOpRoteiro_PrintPage);
            // 
            // pdOpEtiqueta
            // 
            this.pdOpEtiqueta.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdOpEtiqueta_PrintPage);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(672, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estampo:";
            // 
            // lbEstampo
            // 
            this.lbEstampo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEstampo.Location = new System.Drawing.Point(729, 47);
            this.lbEstampo.Name = "lbEstampo";
            this.lbEstampo.Size = new System.Drawing.Size(34, 15);
            this.lbEstampo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(780, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "MP:";
            // 
            // lbMateriaPrima
            // 
            this.lbMateriaPrima.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMateriaPrima.Location = new System.Drawing.Point(808, 47);
            this.lbMateriaPrima.Name = "lbMateriaPrima";
            this.lbMateriaPrima.Size = new System.Drawing.Size(236, 15);
            this.lbMateriaPrima.TabIndex = 21;
            // 
            // tbOpObs
            // 
            this.tbOpObs.Location = new System.Drawing.Point(476, 95);
            this.tbOpObs.MaxLength = 500;
            this.tbOpObs.Multiline = true;
            this.tbOpObs.Name = "tbOpObs";
            this.tbOpObs.Size = new System.Drawing.Size(358, 46);
            this.tbOpObs.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(437, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Obs:";
            // 
            // tsmiImprimirOP
            // 
            this.tsmiImprimirOP.Name = "tsmiImprimirOP";
            this.tsmiImprimirOP.Size = new System.Drawing.Size(32, 19);
            // 
            // tsmiEditarOP
            // 
            this.tsmiEditarOP.Name = "tsmiEditarOP";
            this.tsmiEditarOP.Size = new System.Drawing.Size(120, 22);
            this.tsmiEditarOP.Text = "Editar";
            // 
            // CadastrodeOP
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 609);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbOpObs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbMateriaPrima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbEstampo);
            this.Controls.Add(this.pbIdRoteiro);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvRoteiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbQtde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFabrica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPrioridade);
            this.Controls.Add(this.lbDescProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastrodeOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GI DOVALE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastrodeOP_FormClosed);
            this.Load += new System.EventHandler(this.CadastrodeOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoteiro)).EndInit();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdRoteiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDescProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFabrica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQtde;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRoteiro;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel tssl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem tsdmConfigImpressoras;
        private System.Windows.Forms.PictureBox pbIdRoteiro;
        private System.Drawing.Printing.PrintDocument pdOpRoteiro;
        private System.Drawing.Printing.PrintDocument pdOpEtiqueta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEstampo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMateriaPrima;
        private System.Windows.Forms.TextBox tbOpObs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem tsmApontamento;
        private System.Windows.Forms.ToolStripMenuItem tsmiApontar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarApontamento;
        private System.Windows.Forms.ToolStripMenuItem tsmiImprimirOP;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarOP;
        private System.Windows.Forms.ToolStripMenuItem tsmiOP;
        private System.Windows.Forms.ToolStripMenuItem tsmiOPImprimir;
        private System.Windows.Forms.ToolStripMenuItem tsmiOPEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabrica;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSetor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSetor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodAtividade;
    }
}

