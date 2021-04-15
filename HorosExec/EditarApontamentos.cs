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
    public partial class EditarApontamentos : Form
    {
        string usuario;
        Log log = new Log();
        Apontamentos apontamentos = new Apontamentos();
        List<Log> ListLog = new List<Log>();
        List<Apontamentos> ListApontamento = new List<Apontamentos>();
        List<MotivoApontamento> ListMotivoApontamento = new List<MotivoApontamento>();

        public EditarApontamentos(string Usuario)
        {
            InitializeComponent();
            usuario = Usuario;
        }

        #region EditarApontamento_Load
        private void EditarApontamento_Load(object sender, EventArgs e)
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
                        BuscaApontamentos();
                    }
                }
                else
                {
                    tbNumOP.Focus();
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

        #region dgvApontamento_CellDoubleClick
        private void dgvApontamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EditarApontamento editarapontamento = new EditarApontamento(usuario, dgvApontamento.CurrentRow.Cells[0].Value.ToString());

                MotivoApontamento motivoApontamento = new MotivoApontamento();
                ListMotivoApontamento = motivoApontamento.ListaMotivoApontamento();
                editarapontamento.cbMotivo.DataSource = ListMotivoApontamento;
                editarapontamento.cbMotivo.ValueMember = "CodMotivo";
                editarapontamento.cbMotivo.DisplayMember = "Motivo";

                editarapontamento.lbOP.Text = tbNumOP.Text.TrimStart('0');
                editarapontamento.lbFabrica.Text = dgvApontamento.CurrentRow.Cells[9].Value.ToString();
                editarapontamento.lbSeq.Text = dgvApontamento.CurrentRow.Cells[14].Value.ToString();
                editarapontamento.lbSetor.Text = dgvApontamento.CurrentRow.Cells[11].Value.ToString();
                editarapontamento.lbAtividade.Text = dgvApontamento.CurrentRow.Cells[13].Value.ToString();
                editarapontamento.lbUsuario.Text = dgvApontamento.CurrentRow.Cells[4].Value.ToString();
                editarapontamento.tbData.Text = dgvApontamento.CurrentRow.Cells[5].Value.ToString();
                editarapontamento.cbMotivo.Text = dgvApontamento.CurrentRow.Cells[3].Value.ToString();
                editarapontamento.tbQtde.Text = dgvApontamento.CurrentRow.Cells[6].Value.ToString();
                editarapontamento.tbPeso.Text = dgvApontamento.CurrentRow.Cells[7].Value.ToString();
                editarapontamento.ShowDialog();
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

        #region BuscaApontamentos
        public void BuscaApontamentos()
        {
            try
            {
                {
                    ListApontamento = apontamentos.BuscaApontamentoIdOP(tbNumOP.Text);
                    if (ListApontamento != null)
                    {
                        dgvApontamento.DataSource = ListApontamento;
                        dgvApontamento.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Não foi encontrado nenhuma OP com este número", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbNumOP.Focus();
                    }
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

        #region brAtualizar_Click
        private void brAtualizar_Click(object sender, EventArgs e)
        {
            BuscaApontamentos();
        }
        #endregion
    }
}
