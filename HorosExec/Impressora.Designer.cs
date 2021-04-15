
namespace HorosExec
{
    partial class Impressora
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
            this.label2 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.cbImpRoteiro = new System.Windows.Forms.ComboBox();
            this.cbImpEtiqueta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Impressora do Roteiro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Impressora da Etiqueta:";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(279, 88);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // cbImpRoteiro
            // 
            this.cbImpRoteiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImpRoteiro.FormattingEnabled = true;
            this.cbImpRoteiro.Location = new System.Drawing.Point(144, 11);
            this.cbImpRoteiro.Name = "cbImpRoteiro";
            this.cbImpRoteiro.Size = new System.Drawing.Size(210, 23);
            this.cbImpRoteiro.TabIndex = 7;
            // 
            // cbImpEtiqueta
            // 
            this.cbImpEtiqueta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImpEtiqueta.FormattingEnabled = true;
            this.cbImpEtiqueta.Location = new System.Drawing.Point(144, 49);
            this.cbImpEtiqueta.Name = "cbImpEtiqueta";
            this.cbImpEtiqueta.Size = new System.Drawing.Size(210, 23);
            this.cbImpEtiqueta.TabIndex = 8;
            // 
            // Impressora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 122);
            this.Controls.Add(this.cbImpEtiqueta);
            this.Controls.Add(this.cbImpRoteiro);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Impressora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressoras";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Impressora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ComboBox cbImpRoteiro;
        private System.Windows.Forms.ComboBox cbImpEtiqueta;
    }
}