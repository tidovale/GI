using HorosExec.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GenCode128;
using System.IO;

namespace HorosExec
{
    public partial class Imprimir : Form
    {
        string usuario;
        Log log = new Log();
        List<OP> ListOP = new List<OP>();
        List<Log> ListLog = new List<Log>();
        List<Produto> ListProduto = new List<Produto>();
        List<RoteiroSQL> ListRoteiroSQL = new List<RoteiroSQL>();
        OP op = new OP();
        Produto produto = new Produto();
        RoteiroSQL roteiroSQL = new RoteiroSQL();

        public Imprimir(string Usuario)
        {
            InitializeComponent();
            usuario = Usuario;
        }

        #region Imprimir_Load
        private void Imprimir_Load(object sender, EventArgs e)
        {
            tbOP.Focus();
            if (log.Prod == false)
            {
                this.BackColor = Color.LightSalmon;
            }
        }
        #endregion

        #region btImpRoteiro_Click
        private void btImpRoteiro_Click(object sender, EventArgs e)
        { 
             try
            {
                if(Properties.Settings.Default.ImpressoraRoteiro=="" && Properties.Settings.Default.ImpressoraRoteiro == "")
                {
                    MessageBox.Show("Por favor, configure as impressoras", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ListOP = op.BuscaOP(tbOP.Text);
                    if(ListOP!=null)
                    {
                        GeraEtiquetaOP(Convert.ToInt32(tbOP.Text));
                        ListRoteiroSQL = roteiroSQL.BuscaRoteiro(tbOP.Text);
                        ListProduto = produto.ListaProduto(ListOP[0].CodProduto.ToString());

                        for (var i = 0; i < ListRoteiroSQL.Count; i++)
                        {
                            GeraEtiquetaRoteiro(Convert.ToInt32(ListRoteiroSQL[i].IdRoteiro));
                        }

                        pdOpRoteiro.PrinterSettings.PrinterName = Properties.Settings.Default.ImpressoraRoteiro;
                        pdOpRoteiro.PrintPage += pdOpRoteiro_PrintPage;
                        pdOpRoteiro.Print();

                        DeletaImagens();
                    }
                    else
                    {
                        MessageBox.Show("OP não encontrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbOP.Focus();
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

        #region btImpEtiqueta_Click
        private void btImpEtiqueta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.ImpressoraRoteiro == "" && Properties.Settings.Default.ImpressoraRoteiro == "")
                {
                    MessageBox.Show("Por favor, configure as impressoras", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ListOP = op.BuscaOP(tbOP.Text);
                    if (ListOP != null)
                    {
                        GeraEtiquetaOP(Convert.ToInt32(tbOP.Text));
                        ListRoteiroSQL = roteiroSQL.BuscaRoteiro(tbOP.Text);
                        ListProduto = produto.ListaProduto(ListOP[0].CodProduto.ToString());

                        pdOpEtiqueta.PrinterSettings.PrinterName = Properties.Settings.Default.ImpressoraEtiqueta;
                        pdOpEtiqueta.PrintPage += pdOpEtiqueta_PrintPage;
                        pdOpEtiqueta.Print();

                        DeletaImagens();
                    }
                    else
                    {
                        MessageBox.Show("OP não encontrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbOP.Focus();
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

        #region GeraEtiquetaOP
        private void GeraEtiquetaOP(int IdOP)
        {
            try
            {
                string Numero = IdOP.ToString();
                Numero = Numero.PadLeft(8, '0');
                Image codbarrasCod = Code128Rendering.MakeBarcodeImage(Numero, 2, false);
                pbIdRoteiro.Image = codbarrasCod;
                pbIdRoteiro.Image.Save(@"C:\Windows\Temp\" + Numero + ".jpg");
                codbarrasCod.Dispose();
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

        #region GeraEtiquetaRoteiro
        private void GeraEtiquetaRoteiro(int IdRoteiro)
        {
            try
            {
                string Numero = IdRoteiro.ToString();
                Numero = Numero.PadLeft(8, '0');
                Image codbarrasCod = Code128Rendering.MakeBarcodeImage(Numero, 2, false);
                pbIdRoteiro.Image = codbarrasCod;
                pbIdRoteiro.Image.Save(@"C:\Windows\Temp\" + Numero + ".jpg");
                codbarrasCod.Dispose();
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

        #region pdOpRoteiro_PrintPage
        private void pdOpRoteiro_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font16 = new Font("Arial", 16, FontStyle.Regular);
                Font font16B = new Font("Arial", 16, FontStyle.Bold);
                Font font14 = new Font("Arial", 14, FontStyle.Regular);
                Font font14B = new Font("Arial", 14, FontStyle.Bold);
                Font font12B = new Font("Arial", 12, FontStyle.Bold);
                Font font10 = new Font("Arial", 10, FontStyle.Regular);
                Font font10B = new Font("Arial", 10, FontStyle.Bold);
                Font font7 = new Font("Arial", 7, FontStyle.Regular);

                Image imgLogo = Image.FromFile(@"C:\Windows\LogoDovale.jpg");
                e.Graphics.DrawImage(imgLogo, 30, 25, 200, 40);
                e.Graphics.DrawString("ORDEM DE PRODUÇÃO", font16, Brushes.Black, new Rectangle(240, 35, 800, 700));
                e.Graphics.DrawString("N°", font16B, Brushes.Black, new Rectangle(520, 35, 800, 700));
                e.Graphics.DrawString(ListRoteiroSQL[0].IdOP.ToString(), font16B, Brushes.Black, new Rectangle(550, 35, 800, 700));

                string NumeroOP = ListRoteiroSQL[0].IdOP.ToString();
                NumeroOP = NumeroOP.PadLeft(8, '0');
                Image imgCodOP = Image.FromFile(@"C:\Windows\Temp\" + NumeroOP + ".jpg");
                e.Graphics.DrawImage(imgCodOP, 670, 30, 110, 35);
                imgCodOP.Dispose();

                e.Graphics.DrawString("Cód. Produto:", font14, Brushes.Black, new Rectangle(20, 80, 800, 70));
                e.Graphics.DrawString(ListOP[0].CodProduto.ToString(), font14B, Brushes.Black, new Rectangle(145, 80, 800, 70));
                e.Graphics.DrawString("Descrição:", font14, Brushes.Black, new Rectangle(220, 80, 800, 70));
                e.Graphics.DrawString(ListProduto[0].Descricao, font14B, Brushes.Black, new Rectangle(315, 80, 800, 70));
                e.Graphics.DrawString("Qtde:", font14, Brushes.Black, new Rectangle(20, 110, 800, 70));
                e.Graphics.DrawString(ListOP[0].Qtde.ToString(), font14B, Brushes.Black, new Rectangle(70, 110, 800, 70));
                e.Graphics.DrawString("Data:", font14, Brushes.Black, new Rectangle(180, 110, 800, 70));
                e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy"), font14B, Brushes.Black, new Rectangle(230, 110, 800, 70));
                e.Graphics.DrawString("Estampo:", font14, Brushes.Black, new Rectangle(395, 110, 800, 70));
                e.Graphics.DrawString(ListOP[0].Estampo.ToString(), font14B, Brushes.Black, new Rectangle(485, 110, 800, 70));
                e.Graphics.DrawString("Prioridade:", font14, Brushes.Black, new Rectangle(560, 110, 800, 70));
                e.Graphics.DrawString(ListOP[0].Prioridade.ToString(), font14B, Brushes.Black, new Rectangle(660, 110, 800, 70));
                e.Graphics.DrawString("MP:", font14, Brushes.Black, new Rectangle(20, 140, 800, 70));
                e.Graphics.DrawString(ListOP[0].MateriaPrima.ToString(), font14B, Brushes.Black, new Rectangle(60, 140, 800, 70));

                e.Graphics.DrawString("OBS:", font14, Brushes.Black, new Rectangle(20, 170, 800, 70));
                e.Graphics.DrawString(ListOP[0].Obs.ToString(), font14B, Brushes.Black, new Rectangle(70, 170, 800, 70));

                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(20, 200, 750, 55));
                e.Graphics.DrawString("ROTEIRO DE PRODUÇÃO", font12B, Brushes.Black, new Rectangle(280, 210, 800, 700));

                e.Graphics.DrawString("Seq.", font10B, Brushes.Black, new Rectangle(25, 237, 750, 100));
                e.Graphics.DrawString("Fáb.", font10B, Brushes.Black, new Rectangle(60, 237, 750, 100));
                e.Graphics.DrawString("Setor", font10B, Brushes.Black, new Rectangle(100, 237, 750, 100));
                e.Graphics.DrawString("Atividade", font10B, Brushes.Black, new Rectangle(340, 237, 750, 100));

                int a = 260;
                int b = 265;
                int c = 265;
                int d = 265;
                int cont = 0;

                for (var i = 0; i < ListRoteiroSQL.Count; i++)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(20, a, 750, 54));
                    e.Graphics.DrawString(ListRoteiroSQL[i].Sequencia.ToString(), font10, Brushes.Black, new Rectangle(30, c, 750, 100));
                    e.Graphics.DrawString(ListRoteiroSQL[i].IdFabrica.ToString(), font10, Brushes.Black, new Rectangle(65, c, 750, 100));
                    e.Graphics.DrawString(ListRoteiroSQL[i].NomeSetor.ToString(), font10, Brushes.Black, new Rectangle(100, d, 240, 35));
                    string NumeroRoteiro = ListRoteiroSQL[i].IdRoteiro.ToString();
                    NumeroRoteiro = NumeroRoteiro.PadLeft(8, '0');
                    Image imgIdRoteiro = Image.FromFile(@"C:\Windows\Temp\" + NumeroRoteiro + ".jpg");

                    if (cont == 0)
                    {
                        e.Graphics.DrawString(ListRoteiroSQL[i].DescricaoAtividade.ToString(), font10, Brushes.Black, new Rectangle(340, d, 335, 35));
                        e.Graphics.DrawImage(imgIdRoteiro, 654, b, 110, 35);
                        e.Graphics.DrawString(NumeroRoteiro, font7, Brushes.Black, new Rectangle(685, b + 37, 335, 35));
                        cont = 1;
                    }
                    else
                    {
                        e.Graphics.DrawString(ListRoteiroSQL[i].DescricaoAtividade.ToString(), font10, Brushes.Black, new Rectangle(450, d, 335, 35));
                        e.Graphics.DrawImage(imgIdRoteiro, 338, b, 110, 35);
                        e.Graphics.DrawString(NumeroRoteiro, font7, Brushes.Black, new Rectangle(375, b + 37, 335, 35));
                        cont = 0;
                    }

                    imgIdRoteiro.Dispose();
                    a = a + 80;
                    b = b + 80;
                    c = c + 80;
                    d = d + 80;
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

        #region pdOpEtiqueta_PrintPage
        private void pdOpEtiqueta_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int height = 550;
                int width = 350;

                Font font16 = new Font("Arial", 16, FontStyle.Regular);
                Font font16B = new Font("Arial", 16, FontStyle.Bold);
                Font font14 = new Font("Arial", 14, FontStyle.Regular);
                Font font14B = new Font("Arial", 14, FontStyle.Bold);
                Font font12B = new Font("Arial", 12, FontStyle.Bold);
                Font font18B = new Font("Arial", 18, FontStyle.Bold);
                Font font20 = new Font("Arial", 20, FontStyle.Regular);
                Font font20B = new Font("Arial", 20, FontStyle.Bold);

                //e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(4,4, height, width));

                Image imgLogo = Image.FromFile(@"C:\Windows\LogoDovale.jpg");
                e.Graphics.DrawImage(imgLogo, 20, 25, 125, 25);

                e.Graphics.DrawString("I. R. - IDENTIFICAÇÃO DE RASTREABILIDADE", font12B, Brushes.Black, new Rectangle(160, 30, height, width));
                e.Graphics.DrawString("OP N°", font14, Brushes.Black, new Rectangle(20, 65, height, width));
                e.Graphics.DrawString(ListRoteiroSQL[0].IdOP.ToString(), font16B, Brushes.Black, new Rectangle(20, 90, height, width));
                e.Graphics.DrawString("Qtde", font14, Brushes.Black, new Rectangle(120, 65, 800, 70));
                e.Graphics.DrawString(ListOP[0].Qtde.ToString(), font16B, Brushes.Black, new Rectangle(120, 90, height, width));
                e.Graphics.DrawString("Data", font14, Brushes.Black, new Rectangle(250, 65, height, width));
                e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy"), font16B, Brushes.Black, new Rectangle(250, 90, height, width));
                e.Graphics.DrawString("Prioridade", font14, Brushes.Black, new Rectangle(420, 65, height, width));
                e.Graphics.DrawString(ListOP[0].Prioridade.ToString(), font14B, Brushes.Black, new Rectangle(420, 90, height, width));
                e.Graphics.DrawString("Cód. Produto", font20, Brushes.Black, new Rectangle(20, 130, height, width));
                e.Graphics.DrawString(ListOP[0].CodProduto.ToString(), font20B, Brushes.Black, new Rectangle(20, 160, height, width));
                e.Graphics.DrawString("Descrição", font20, Brushes.Black, new Rectangle(20, 200, height, width));
                e.Graphics.DrawString(ListProduto[0].Descricao, font18B, Brushes.Black, new Rectangle(20, 230, height, width));
                string NumeroOP = ListRoteiroSQL[0].IdOP.ToString();
                NumeroOP = NumeroOP.PadLeft(8, '0');
                Image imgCodOP = Image.FromFile(@"C:\Windows\Temp\" + NumeroOP + ".jpg");
                e.Graphics.DrawImage(imgCodOP, 430, 300, 100, 35);
                imgCodOP.Dispose();
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

        #region DeletaImagens
        private void DeletaImagens()
        {
            try
            {
                string NumeroOP = ListRoteiroSQL[0].IdOP.ToString();
                NumeroOP = NumeroOP.PadLeft(8, '0');
                FileInfo fileOP = new FileInfo(@"C:\Windows\Temp\" + NumeroOP + ".jpg");
                fileOP.Delete();

                for (var ii = 0; ii < ListRoteiroSQL.Count; ii++)
                {
                    string NumeroRoteiro = ListRoteiroSQL[ii].IdRoteiro.ToString();
                    NumeroRoteiro = NumeroRoteiro.PadLeft(8, '0');
                    FileInfo fileOP1 = new FileInfo(@"C:\Windows\Temp\" + NumeroRoteiro + ".jpg");
                    fileOP1.Delete();
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
