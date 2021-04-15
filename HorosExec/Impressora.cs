using HorosExec.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace HorosExec
{
    public partial class Impressora : Form
    {
        string usuario;
        Log log = new Log();
        List<Log> ListLog = new List<Log>();

        public Impressora(string Usuario)
        {
            InitializeComponent();
            usuario = Usuario;
        }

        #region Impressora_Load
        private void Impressora_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string pr in PrinterSettings.InstalledPrinters)
                {
                    cbImpRoteiro.Items.Add(pr.ToString());
                    cbImpEtiqueta.Items.Add(pr.ToString());
                }
                cbImpRoteiro.SelectedItem = Properties.Settings.Default.ImpressoraRoteiro;
                cbImpEtiqueta.SelectedItem = Properties.Settings.Default.ImpressoraEtiqueta;
                if (log.Prod == false)
                {
                    this.BackColor = Color.LightSalmon;
                }
            }
            catch (Exception ex)
            {
                log.Tipo = "Erro";
                log.Local = this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                log.Login = usuario;
                log.Computador = Environment.MachineName.ToString();
                log.Mensagem = ex.Message;
                ListLog.Add(log);
                log.GravaLog(ListLog);
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region btSalvar_Click
        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(cbImpRoteiro.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Escolha uma impressora para impressão do Roteiro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbImpRoteiro.Focus();
                    }
                else if (string.IsNullOrEmpty(cbImpEtiqueta.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Escolha uma impressora para impressão da Etiqueta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbImpEtiqueta.Focus();
                }
                else
                {
                    Properties.Settings.Default.ImpressoraRoteiro = cbImpRoteiro.SelectedItem.ToString();
                    Properties.Settings.Default.ImpressoraEtiqueta = cbImpEtiqueta.SelectedItem.ToString();
                    Properties.Settings.Default.Save();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                log.Tipo = "Erro";
                log.Local = this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                log.Login = usuario;
                log.Computador = Environment.MachineName.ToString();
                log.Mensagem = ex.Message;
                ListLog.Add(log);
                log.GravaLog(ListLog);
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
