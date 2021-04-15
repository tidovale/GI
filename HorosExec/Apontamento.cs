using HorosExec.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HorosExec
{
    public partial class Apontamento : Form
    {
        string usuario;
        bool Obs=true;
        Log log = new Log();
        OP op = new OP();
        Produto produto = new Produto();
        RoteiroSQL roteiroSQL = new RoteiroSQL();
        RotApontamento apontamento = new RotApontamento();
        List<Log> ListLog = new List<Log>();
        List<OP> ListOP = new List<OP>();
        List<Produto> ListProduto = new List<Produto>();
        List<RoteiroSQL> ListRoteiroSQL = new List<RoteiroSQL>();
        List<RotApontamento> ListApontamento = new List<RotApontamento>();
        List<MotivoApontamento> ListMotivoApontamento = new List<MotivoApontamento>();
        List<TipoParada> ListTipoParada = new List<TipoParada>();
        List<string> ListResultadoApontamento = new List<string>();
        List<string> ListResultadoJustificativaApontamento = new List<string>();

        public Apontamento(string Usuario)
        {
            InitializeComponent();
            usuario = Usuario;
        }

        #region Apontamento_Load
        private void Apontamento_Load(object sender, EventArgs e)
        {
            MotivoApontamento motivoApontamento = new MotivoApontamento();
            ListMotivoApontamento = motivoApontamento.ListaMotivoApontamento();
            cbMotivo.DataSource = ListMotivoApontamento;
            cbMotivo.ValueMember = "CodMotivo";
            cbMotivo.DisplayMember = "Motivo";

            TipoParada tipoParada = new TipoParada();
            ListTipoParada = tipoParada.ListaTipoParada();
            cbJustificativa.DataSource = ListTipoParada;
            cbJustificativa.ValueMember = "CodTipo";
            cbJustificativa.DisplayMember = "Tipo";

            if (log.Prod == false)
            {
                this.BackColor = Color.LightSalmon;
            }
        }
        #endregion

        #region tbNumAtividade_KeyUp
        private void tbNumAtividade_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbNumAtividade.Text))
                {
                    if (tbNumAtividade.TextLength == 8)
                    {
                        cbMotivo.Focus();
                        
                        ListRoteiroSQL = roteiroSQL.BuscaAtividade(tbNumAtividade.Text);
                        if(ListRoteiroSQL==null)
                        {
                            MessageBox.Show("Não foi encontrado nenhuma atividade com este número", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbNumAtividade.SelectionStart = 0;
                            btApontar.Enabled = false;
                        }
                        else
                        {
                            lbOP.Text = ListRoteiroSQL[0].IdOP.ToString();
                            lbSequencia.Text = ListRoteiroSQL[0].Sequencia.ToString() +"-";
                            lbAtividade.Text = ListRoteiroSQL[0].NomeSetor;
                            lbDescricao.Text = ListRoteiroSQL[0].DescricaoAtividade;
                            ListOP = op.BuscaOP(ListRoteiroSQL[0].IdOP.ToString());
                            ListProduto = produto.ListaProduto(ListOP[0].CodProduto.ToString());
                            lbCodProduto.Text = ListOP[0].CodProduto.ToString();
                            lbDescProd.Text = ListProduto[0].Descricao;
                            lbPrioridade.Text = ListOP[0].Prioridade.ToString();
                            if(ListOP[0].Prioridade.ToString()== "1- Vermelho")
                            {
                                lbPrioridadeCor.BackColor = Color.Red;
                            }
                            else if (ListOP[0].Prioridade.ToString() == "2- Amarelo")
                            {
                                lbPrioridadeCor.BackColor = Color.Yellow;
                            }
                            else
                            {
                                lbPrioridadeCor.BackColor = Color.Green;
                            }
                            lbEstampo.Text = ListOP[0].Estampo.ToString();
                            lbMP.Text = ListOP[0].MateriaPrima;
                            lbFabrica.Text = ListOP[0].IdFabrica.ToString();
                            lbQtde.Text = ListOP[0].Qtde.ToString();
                            lbObs.Text = ListOP[0].Obs;

                            List<string> ListResultadoJaApontado = new List<string>();

                            if (ListRoteiroSQL[0].Sequencia > 1)
                            {
                                if (roteiroSQL.BuscaAtividadeAnterior(ListRoteiroSQL[0].IdRoteiro) == 0)
                                {
                                    lbAviso.Text = "Não é possível apontar esta atividade, pois o setor anterior ainda não finalizou sua atividade!";
                                    btApontar.Enabled = false;
                                    tbNumAtividade.SelectionStart = 0;
                                    tbNumAtividade.SelectionLength = tbNumAtividade.Text.Length;
                                    tbNumAtividade.Focus();
                                }
                                else
                                {
                                    if (cbMotivo.SelectedValue.ToString() == "1")
                                    {
                                        ListResultadoJaApontado = roteiroSQL.BuscaQtdeAtividadeAnteriorApontada(ListRoteiroSQL[0].IdOP);
                                        if (ListResultadoJaApontado != null)
                                        {
                                            tbQtde.Text = ListResultadoJaApontado[1];
                                        }
                                    }

                                    lbAviso.Text = "";
                                    btApontar.Enabled = true;
                                    btFi.Enabled = true;
                                    btDesenho.Enabled = true;
                                    tbQtde.Enabled = true;
                                    tbPeso.Enabled = true;
                                    cbMotivo.Enabled = true;
                                    tbNumAtividade.SelectionStart = 0;
                                    tbNumAtividade.SelectionLength = tbNumAtividade.Text.Length;
                                    tbNumAtividade.Focus();
                                }
                            }
                            else
                            {
                                if (cbMotivo.SelectedValue.ToString() == "1")
                                {
                                    ListResultadoJaApontado = roteiroSQL.BuscaQtdeAtividadeAnteriorApontada(ListRoteiroSQL[0].IdOP);
                                    if (ListResultadoJaApontado != null)
                                    {
                                        tbQtde.Text = ListResultadoJaApontado[1];
                                    }
                                    else
                                    {
                                        tbQtde.Text = ListOP[0].Qtde.ToString();
                                    }
                                }
   
                                lbAviso.Text = "";
                                tbQtde.Enabled = true;
                                tbPeso.Enabled = true;
                                cbMotivo.Enabled = true;
                                btApontar.Enabled = true;
                                btFi.Enabled = true;
                                btDesenho.Enabled = true;
                                tbNumAtividade.SelectionStart = 0;
                                tbNumAtividade.SelectionLength = tbNumAtividade.Text.Length;
                                tbNumAtividade.Focus();
                            }

                            if(ListOP[0].Status=="Fechada")
                            {
                                btApontar.Enabled = false;
                                lbAviso.Text = "Esta OP já foi fechada!";
                            }
                            else if (ListOP[0].Status == "Cancelada")
                            {
                                btApontar.Enabled = false;
                                lbAviso.Text = "Esta OP foi cancelada!";
                            }
                            else
                            {
                                btApontar.Enabled = true;
                            }
                        }
                    }
                }
                else
                {
                    tbNumAtividade.Focus();
                    btApontar.Enabled = false;
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

        #region btApontar_Click
        private void btApontar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbNumAtividade.Text))
                {
                    MessageBox.Show("Preencha o Código da Atividade", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbNumAtividade.Focus();
                }
                else if (cbMotivo.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Preencha o Motivo da Atividade", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbMotivo.Focus();
                }
                else if ((string.IsNullOrEmpty(tbQtde.Text)) || (tbQtde.Text == "0"))
                {
                    MessageBox.Show("Preencha a Quantidade", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbQtde.Focus();
                }
                else if (string.IsNullOrEmpty(tbPeso.Text))
                {
                    MessageBox.Show("Preencha o Peso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbPeso.Focus();
                }
                else
                {
                    if (cbMotivo.SelectedValue.ToString() == "1")
                    {
                        int Res = apontamento.BuscaApontamentoRepetido(ListRoteiroSQL[0].IdRoteiro, cbMotivo.SelectedValue.ToString());
                        if (Res == 0)
                        {
                            if (ListRoteiroSQL[0].Sequencia == 1)
                            {
                                if (Convert.ToInt32(tbQtde.Text) != ListOP[0].Qtde)
                                {
                                    if (Obs)
                                    {
                                        lbAviso.Text = "Você está apontando uma quantidade diferente da OP, por favor justifique!";
                                        lbJustificativa.Enabled = true;
                                        lbObsJustificativa.Enabled = true;
                                        tbObs.Enabled = true;
                                        cbJustificativa.Enabled = true;
                                        Obs = false;
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(tbObs.Text))
                                        {
                                            MessageBox.Show("Preencha a Observação", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            tbObs.Focus();
                                        }
                                        else
                                        {
                                            GravaApontamento();
                                            GravaJustificativaApontamento();
                                            op.OPUpdateStatus(ListRoteiroSQL[0].IdOP, "Andamento");
                                            LimpaCampos();
                                        }
                                    }
                                }
                                else
                                {
                                    GravaApontamento();
                                    op.OPUpdateStatus(ListRoteiroSQL[0].IdOP, "Andamento");
                                    LimpaCampos();
                                }
                            }
                            else
                            {
                                int Qtde = roteiroSQL.BuscaQtdeAtividadeAnterior(ListRoteiroSQL[0].IdRoteiro-1, 2);
                                if (Convert.ToInt32(tbQtde.Text) != Qtde)
                                {
                                    if (Obs)
                                    {
                                        lbAviso.Text = "Você está apontando uma quantidade diferente que já produzida, por favor justifique!";
                                        lbJustificativa.Enabled = true;
                                        lbObsJustificativa.Enabled = true;
                                        tbObs.Enabled = true;
                                        cbJustificativa.Enabled = true;
                                        Obs = false;
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(tbObs.Text))
                                        {
                                            MessageBox.Show("Preencha a Observação", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            tbObs.Focus();
                                        }
                                        else
                                        {
                                            GravaApontamento();
                                            GravaJustificativaApontamento();
                                            LimpaCampos();
                                        }
                                    }
                                }
                                else
                                {
                                    GravaApontamento();
                                    LimpaCampos();
                                }
                            }
                        }
                        else
                        {
                            lbAviso.Text = "Já existe um apontamento de (1-Início de Produção) para esta atividade";
                            tbNumAtividade.SelectionStart = 0;
                            tbNumAtividade.SelectionLength = tbNumAtividade.Text.Length;
                            tbNumAtividade.Focus();
                        }
                    }
                    else if (cbMotivo.SelectedValue.ToString() == "2")
                    {
                        int Res = apontamento.BuscaApontamentoRepetido(ListRoteiroSQL[0].IdRoteiro, cbMotivo.SelectedValue.ToString());
                        if (Res == 0)
                        {
                            int Qtde = roteiroSQL.BuscaQtdeAtividadeAnterior(ListRoteiroSQL[0].IdRoteiro, 1);
                            if(Qtde>0)
                            {
                                if (Convert.ToInt32(tbQtde.Text) != Qtde)
                                {
                                    if (Obs)
                                    {
                                        lbAviso.Text = "Você está apontando uma quantidade diferente que já produzida, por favor justifique!";
                                        lbJustificativa.Enabled = true;
                                        lbObsJustificativa.Enabled = true;
                                        tbObs.Enabled = true;
                                        cbJustificativa.Enabled = true;
                                        Obs = false;
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(tbObs.Text))
                                        {
                                            MessageBox.Show("Preencha a Observação", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            tbObs.Focus();
                                        }
                                        else
                                        {
                                            //Se for ultima atividade da OP atualiza seu status "Fechada"
                                            int UltimaAtividade = roteiroSQL.BuscaUltimaAtividadeApontada(ListRoteiroSQL[0].IdOP);
                                            if (ListRoteiroSQL[0].IdRoteiro == UltimaAtividade)
                                            {
                                                op.OPUpdateStatus(ListRoteiroSQL[0].IdOP, "Fechada");
                                            }
                                            GravaApontamento();
                                            GravaJustificativaApontamento();
                                            LimpaCampos();
                                        }
                                    }
                                }
                                else
                                {
                                    //Se for ultima atividade da OP atualiza seu status "Fechada"
                                    int UltimaAtividade = roteiroSQL.BuscaUltimaAtividadeApontada(ListRoteiroSQL[0].IdOP);
                                    if(ListRoteiroSQL[0].IdRoteiro == UltimaAtividade)
                                    {
                                        op.OPUpdateStatus(ListRoteiroSQL[0].IdOP, "Fechada");
                                    }
                                    GravaApontamento();
                                    LimpaCampos();
                                }
                            }
                            else
                            {
                                lbAviso.Text = "Esta atividade ainda não foi apontado o (1-Início de Produção)";
                                tbNumAtividade.SelectionStart = 0;
                                tbNumAtividade.SelectionLength = tbNumAtividade.Text.Length;
                                tbNumAtividade.Focus();
                            }
                        }
                        else
                        {
                            lbAviso.Text = "Já existe um apontamento de (2 -Fim de Produção) para esta atividade";
                            tbNumAtividade.SelectionStart = 0;
                            tbNumAtividade.SelectionLength = tbNumAtividade.Text.Length;
                            tbNumAtividade.Focus();
                        }
                    }
                    else
                    {
                        GravaApontamento();
                        LimpaCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                log.Tipo = "Erro";
                log.Local = this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                log.Login = usuario;
                log.Computador = Environment.MachineName.ToString();
                log.Mensagem = ex.Message + "("+ ListRoteiroSQL[0].IdOP + ")";
                ListLog.Add(log);
                log.GravaLog(ListLog);
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GravaApontamento
        private void GravaApontamento()
        {
            try
            {
                ListApontamento.Clear();

                RotApontamento apont = new RotApontamento()
                {
                    IdRoteiro = Convert.ToInt32(ListRoteiroSQL[0].IdRoteiro),
                    IdMotivo = Convert.ToInt32(cbMotivo.SelectedValue.ToString()),
                    Usuario = usuario,
                    Qtde = Convert.ToInt32(tbQtde.Text),
                    Peso = Convert.ToDouble(tbPeso.Text.Replace(".", ","))
                };
                ListApontamento.Add(apont);
                ListResultadoApontamento = apontamento.CadastrarApontamento(ListApontamento);
                MessageBox.Show(ListRoteiroSQL[0].NomeSetor.ToString() + "\n Apontada com sucesso!", "Apontamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lbOP.Text = "";
            lbAviso.Text = "";
            tbNumAtividade.Text = "";
            tbNumAtividade.Focus();

            lbSequencia.Text = "";
            lbAtividade.Text = "";
            lbDescricao.Text = "";
            lbCodProduto.Text = "";
            lbDescProd.Text = "";
            lbPrioridade.Text = "";
            lbEstampo.Text = "";
            lbMP.Text = "";
            lbFabrica.Text = "";
            lbQtde.Text = "";
            lbObs.Text = "";

            tbQtde.Text = "0";
            tbPeso.Text = "0";
            btFi.Enabled = false;
            cbMotivo.Enabled = false;
            tbQtde.Enabled = false;
            tbPeso.Enabled = false;
            btDesenho.Enabled = false;
            btApontar.Enabled = false;

            tbObs.Text = "";
            lbJustificativa.Enabled = false;
            cbJustificativa.Enabled = false;
            lbObsJustificativa.Enabled = false;
            tbObs.Enabled = false;
            Obs = true;
        }
        #endregion

        #region GravaJustificativaApontamento
        private void GravaJustificativaApontamento()
        {
            try
            {
                    ListResultadoJustificativaApontamento = apontamento.CadastrarJustificativaApontamento(Convert.ToInt32(ListResultadoApontamento[0]), Convert.ToInt32(cbJustificativa.SelectedValue),tbObs.Text);
                    tbQtde.Text = "0";
                    tbPeso.Text = "0";
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

        #region cbMotivo_SelectedValueChanged
        private void cbMotivo_SelectedValueChanged(object sender, EventArgs e)
        {
            btApontar.Enabled = true;

            if (cbMotivo.SelectedValue.ToString() == "1")
            {
                if(ListRoteiroSQL.Count!=0)
                {
                    List<string> ListResultadoJaApontado = new List<string>();
                    ListResultadoJaApontado = roteiroSQL.BuscaQtdeAtividadeAnteriorApontada(ListRoteiroSQL[0].IdOP);
                    if (ListResultadoJaApontado != null)
                    {
                        tbQtde.Text = ListResultadoJaApontado[1];
                    }
                    else
                    {
                        tbQtde.Text = ListOP[0].Qtde.ToString();
                    }
                    ListResultadoJaApontado.Clear();
                }
            }
            else if (cbMotivo.SelectedValue.ToString() == "2")
            {
                tbQtde.Text = "0";
            }
        }
        #endregion

    }
}