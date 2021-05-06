using HorosExec.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HorosExec
{
    public partial class Index : Form
    {
        Log log = new Log();
        List<Log> ListLog = new List<Log>();
        string usuario;

        public Index(string Usuario, string Permissao)
        {
            InitializeComponent();
            usuario = Usuario;
        }

        private void Index_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "GI DOVALE - " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
                List<AD> ListUsuario = new List<AD>();
                AD ad = new AD();
                ListUsuario = ad.BuscaUsuario("dovalechaves", usuario);
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
    }
}
