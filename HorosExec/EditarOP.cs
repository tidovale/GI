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
    public partial class EditarOP : Form
    {
        string usuario;
        Log log = new Log();
        OP op = new OP();
        Produto produto = new Produto();
        List<Log> ListLog = new List<Log>();
        List<OP> ListOP = new List<OP>();
        List<Produto> ListProduto = new List<Produto>();
        List<string> ListResultadoDelete = new List<string>();
        List<OP> ListUpdateOP = new List<OP>();
        List<string> ListResultadoUpdate = new List<string>();

        public EditarOP(string Usuario)
        {
            InitializeComponent();
            usuario = Usuario;
        }

        #region ApontamentoEditar_Load
        private void ApontamentoEditar_Load(object sender, EventArgs e)
        {
            try
            {
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

        #region tbNumOP_KeyUp
        private void tbNumOP_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbNumOP.Text))
                {
                    if (tbNumOP.TextLength == 8)
                    {
                        ListOP = op.BuscaOP(tbNumOP.Text);
                        if (ListOP != null)
                        {
                            lbCodProduto.Text = ListOP[0].CodProduto.ToString();
                            ListProduto = produto.ListaProduto(ListOP[0].CodProduto.ToString());
                            lbDescProd.Text = ListProduto[0].Descricao;
                            lbEstampo.Text = ListOP[0].Estampo.ToString();
                            lbMateriaPrima.Text = ListOP[0].MateriaPrima.ToString();
                            cbPrioridade.Text = ListOP[0].Prioridade.ToString();
                            cbFabrica.Text = ListOP[0].IdFabrica.ToString();
                            cbStatus.Text = ListOP[0].Status.ToString();
                            tbQtde.Text = ListOP[0].Qtde.ToString();
                            tbObs.Text = ListOP[0].Obs.ToString();
                            btSalvar.Enabled = true;
                            btExcluir.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Não foi encontrado nenhuma OP com este número", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btSalvar.Enabled = false;
                            btExcluir.Enabled = false;
                            tbNumOP.Focus();
                        }
                    }
                }
                else
                {
                    tbNumOP.Focus();
                    btSalvar.Enabled = false;
                    btExcluir.Enabled = false;
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

        #region btExcluir_Click
        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ListResultadoDelete = op.DeleteOP(Convert.ToInt32(tbNumOP.Text));
                if(Convert.ToInt32(ListResultadoDelete[0])==0)
                {
                    MessageBox.Show(ListResultadoDelete[1].ToString(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    #region GravaLog Log
                    log.Tipo = "Informação";
                    log.Local = this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                    log.Login = usuario;
                    log.Computador = Environment.MachineName.ToString();
                    log.Mensagem = "Excluiu OP "+ tbNumOP.Text;
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
                LimpaCampos();
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

        #region btSalvar_Click
        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                OP opUpdate = new OP()
                {
                    IdOP = Convert.ToInt32(tbNumOP.Text),
                    Prioridade = cbPrioridade.SelectedItem.ToString(),
                    IdFabrica = Convert.ToInt32(cbFabrica.SelectedItem.ToString()),
                    Status = cbStatus.SelectedItem.ToString(),
                    Qtde = Convert.ToInt32(tbQtde.Text),
                    Obs = tbObs.Text,
                    Usuario = usuario,
                };
                ListUpdateOP.Add(opUpdate);
                ListResultadoUpdate = op.UpDateOP(ListUpdateOP);

                if (Convert.ToInt32(ListResultadoUpdate[0]) == 0)
                {
                    MessageBox.Show(ListResultadoUpdate[1].ToString(), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    #region GravaLog
                    log.Tipo = "Informação";
                    log.Local = this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                    log.Login = usuario;
                    log.Computador = Environment.MachineName.ToString();
                    log.Mensagem = "Alterou OP " + tbNumOP.Text;
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
                LimpaCampos();
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

        #region LimpaCampos
        private void LimpaCampos()
        {
            tbNumOP.Text = "";
            lbCodProduto.Text = "";
            lbDescProd.Text = "";
            lbEstampo.Text = "";
            lbMateriaPrima.Text = "";
            cbPrioridade.Text = ListOP[0].Prioridade.ToString();
            cbFabrica.Text = ListOP[0].IdFabrica.ToString();
            cbStatus.Text = ListOP[0].Status.ToString();
            tbQtde.Text = "";
            tbObs.Text = "";
            btSalvar.Enabled = false;
            btExcluir.Enabled = false;
        }
        #endregion
    }
}
