
namespace HorosExec
{
    partial class Imprimir
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
            this.btImpRoteiro = new System.Windows.Forms.Button();
            this.tbOP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btImpEtiqueta = new System.Windows.Forms.Button();
            this.pbIdRoteiro = new System.Windows.Forms.PictureBox();
            this.pdOpRoteiro = new System.Drawing.Printing.PrintDocument();
            this.pdOpEtiqueta = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdRoteiro)).BeginInit();
            this.SuspendLayout();
            // 
            // btImpRoteiro
            // 
            this.btImpRoteiro.Location = new System.Drawing.Point(17, 62);
            this.btImpRoteiro.Name = "btImpRoteiro";
            this.btImpRoteiro.Size = new System.Drawing.Size(75, 23);
            this.btImpRoteiro.TabIndex = 1;
            this.btImpRoteiro.Text = "Roteiro";
            this.btImpRoteiro.UseVisualStyleBackColor = true;
            this.btImpRoteiro.Click += new System.EventHandler(this.btImpRoteiro_Click);
            // 
            // tbOP
            // 
            this.tbOP.Location = new System.Drawing.Point(73, 20);
            this.tbOP.Name = "tbOP";
            this.tbOP.Size = new System.Drawing.Size(69, 23);
            this.tbOP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "N° OP:";
            // 
            // btImpEtiqueta
            // 
            this.btImpEtiqueta.Location = new System.Drawing.Point(98, 62);
            this.btImpEtiqueta.Name = "btImpEtiqueta";
            this.btImpEtiqueta.Size = new System.Drawing.Size(75, 23);
            this.btImpEtiqueta.TabIndex = 2;
            this.btImpEtiqueta.Text = "Etiqueta";
            this.btImpEtiqueta.UseVisualStyleBackColor = true;
            this.btImpEtiqueta.Click += new System.EventHandler(this.btImpEtiqueta_Click);
            // 
            // pbIdRoteiro
            // 
            this.pbIdRoteiro.Location = new System.Drawing.Point(148, 15);
            this.pbIdRoteiro.Name = "pbIdRoteiro";
            this.pbIdRoteiro.Size = new System.Drawing.Size(26, 28);
            this.pbIdRoteiro.TabIndex = 19;
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
            // Imprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 98);
            this.Controls.Add(this.pbIdRoteiro);
            this.Controls.Add(this.btImpEtiqueta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOP);
            this.Controls.Add(this.btImpRoteiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Imprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Imprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIdRoteiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btImpRoteiro;
        private System.Windows.Forms.TextBox tbOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btImpEtiqueta;
        private System.Windows.Forms.PictureBox pbIdRoteiro;
        private System.Drawing.Printing.PrintDocument pdOpRoteiro;
        private System.Drawing.Printing.PrintDocument pdOpEtiqueta;
    }
}