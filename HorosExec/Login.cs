using HorosExec.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HorosExec
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        AD ad = new AD();
        Log log = new Log();
        List<Log> ListLog = new List<Log>();

        #region btLogin_Click
        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ad.Ping())
                {
                    if (ad.LoginUsuario("dovalechaves", tbUsuario.Text, tbSenha.Text))
                    {

                        #region GravaLog Login
                        log.Tipo = "Informação";
                        log.Local = this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                        log.Login = tbUsuario.Text;
                        log.Computador = Environment.MachineName.ToString();
                        log.Mensagem = "Login";
                        ListLog.Add(log);
                        log.GravaLog(ListLog);
                        #endregion

                        SQL sql = new SQL();
                        string permissao = sql.BuscaPermissao(tbUsuario.Text);
                        if (permissao == "Administrador")
                        {
                            this.Hide();
                            CadastrodeOP index = new CadastrodeOP(tbUsuario.Text, permissao);
                            index.ShowDialog();

                            //CadastrodeOP cadOp = new CadastrodeOP(tbUsuario.Text, permissao);
                            //cadOp.ShowDialog();
                        }
                        else if (permissao == "Supervisor")
                        {
                            this.Hide();
                            CadastrodeOP cadOp = new CadastrodeOP(tbUsuario.Text, permissao);
                            cadOp.ShowDialog();
                        }
                        else if (permissao == "Operador")
                        {
                            this.Hide();
                            Apontamento apt = new Apontamento(tbUsuario.Text);
                            apt.ShowDialog();
                        }
                        else if (permissao == "Pcp")
                        {
                            this.Hide();
                            CadastrodeOP cadOp = new CadastrodeOP(tbUsuario.Text, permissao);
                            cadOp.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Usuário não está cadastrado no Horus", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            tbUsuario.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha incorreto", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Servidor de Autenticação não encontrado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                log.Tipo = "Erro";
                log.Local = this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                log.Login = tbUsuario.Text;
                log.Computador = Environment.MachineName.ToString();
                log.Mensagem = ex.Message;
                ListLog.Add(log);
                log.GravaLog(ListLog);
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Login_Load
        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "GI DOVALE - " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (log.Prod == false)
            {
                this.BackColor = Color.LightSalmon;
            }
        }
        #endregion

    }
}
