using HorosExec.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HorosExec
{
    public partial class EditarApontamento : Form
    {
        string usuario;
        string idapontamento;
        Log log = new Log();
        RotApontamento rotapontamento = new RotApontamento();
        JustificativaApontamento justificativaapontamento = new JustificativaApontamento();
        List<Log> ListLog = new List<Log>();
        List<MotivoApontamento> ListMotivoApontamento = new List<MotivoApontamento>();
        List<JustificativaApontamento> ListJustificativaApontamento = new List<JustificativaApontamento>();
        List<string> ListResultadoDelete = new List<string>();
        List<string> ListResultadoUpdate = new List<string>();
        List<RotApontamento> ListUpdateApontamento = new List<RotApontamento>();

        public EditarApontamento(string Usuario, string IdApontamento)
        {
            InitializeComponent();
            usuario = Usuario;
            idapontamento = IdApontamento;
        }

        #region EditarApontamento_Load
        private void EditarApontamento_Load(object sender, EventArgs e)
        {
            try
            {
                ListJustificativaApontamento = justificativaapontamento.BuscaJustificativaApontamento(idapontamento);
                if(ListJustificativaApontamento!=null)
                {
                    dgvJustificativas.DataSource = ListJustificativaApontamento;
                    dgvJustificativas.ClearSelection();
                }
                else
                {
                    dgvJustificativas.Visible = false;
                }

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
                RotApontamento rotapontamento = new RotApontamento()
                {
                    IdApontamento = Convert.ToInt32(idapontamento),
                    IdMotivo = Convert.ToInt32(cbMotivo.SelectedValue),
                    DataCadastro = Convert.ToDateTime(tbData.Text),
                    Qtde = Convert.ToInt32(tbQtde.Text),
                    Peso = Convert.ToDouble(tbPeso.Text),
                };
                ListUpdateApontamento.Add(rotapontamento);
                ListResultadoUpdate = rotapontamento.UpDateApontamento(ListUpdateApontamento);

                if (Convert.ToInt32(ListResultadoUpdate[0]) == 0)
                {
                    MessageBox.Show(ListResultadoUpdate[1].ToString(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    #region GravaLog
                    log.Tipo = "Informação";
                    log.Local = this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                    log.Login = usuario;
                    log.Computador = Environment.MachineName.ToString();
                    log.Mensagem = "Alterou Apontamento " + IdApontamento;
                    ListLog.Add(log);
                    log.GravaLog(ListLog);
                    #endregion
                }
                else if (Convert.ToInt32(ListResultadoUpdate[0]) == -1)
                {
                    MessageBox.Show(ListResultadoUpdate[1].ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(ListResultadoUpdate[1].ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
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

        #region btExcluir_Click
        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ListResultadoDelete = rotapontamento.DeletarApontamento(Convert.ToInt32(idapontamento));
                if (Convert.ToInt32(ListResultadoDelete[0]) == 0)
                {
                    MessageBox.Show(ListResultadoDelete[1].ToString(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #region GravaLog Log
                    log.Tipo = "Informação";
                    log.Local = this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                    log.Login = usuario;
                    log.Computador = Environment.MachineName.ToString();
                    log.Mensagem = "Excluiu Apontamento "+ idapontamento.ToString() + " - OP: "+lbOP.Text;
                    ListLog.Add(log);
                    log.GravaLog(ListLog);
                    #endregion
                }
                else if (Convert.ToInt32(ListResultadoDelete[0]) == -1)
                {
                    MessageBox.Show(ListResultadoDelete[1].ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(ListResultadoDelete[1].ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
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
