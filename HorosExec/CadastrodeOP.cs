using FirebirdSql.Data.FirebirdClient;
using HorosExec.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenCode128;
using System.IO;
using System.Threading;
using System.Reflection;

namespace HorosExec
{
    public partial class CadastrodeOP : Form
    {
        string usuario;
        string Msg;
        int LoteIdeal;
        bool Imprimir;
        bool ImprimirAviso;
        Log log = new Log();
        List<Log> ListLog = new List<Log>();
        List<OP> ListCadastrarOP = new List<OP>();
        List<Produto> ListProduto = new List<Produto>();
        List<RoteiroSQL> ListRoteiroSQL = new List<RoteiroSQL>();
        List<RoteiroFireBird> ListRoteiroFireBird = new List<RoteiroFireBird>();

        public CadastrodeOP(string Usuario, string Permissao)
        {
            InitializeComponent();
            usuario = Usuario;

            if(Permissao =="Pcp")
            {
                tsmiEditarApontamento.Visible = false;
                tsmiOPEditar.Visible = false;
            }
        }

        #region CadastrodeOP_Load
        private void CadastrodeOP_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "GI DOVALE - " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
                List<AD> ListUsuario = new List<AD>();
                AD ad = new AD();
                btCadastrar.Enabled = false;
                ListUsuario = ad.BuscaUsuario("dovalechaves", usuario);
                tssl.Text = ListUsuario[0].Nome;
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

        #region PopulaFabrica
        //private void PopulaFabrica()
        //{
        //    try
        //    {
        //        Fabrica fabrica = new Fabrica();
        //        List<Fabrica> fab = new List<Fabrica>();
        //        fab = fabrica.ListaEmpresa();

        //        foreach (var item in fab)
        //        {
        //            cbFabrica.DisplayMember = item.Empresa;
        //            cbFabrica.ValueMember = item.CodEmpresa.ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Tipo = "Erro";
        //        log.Local = this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        log.Login = usuario;
        //        log.Computador = Environment.MachineName.ToString();
        //        log.Mensagem = ex.Message;
        //        ListLog.Add(log);
        //        log.GravaLog(ListLog);
        //        MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        #endregion

        #region tbCodProd_Leave
        private void tbCodProd_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbCodProd.Text))
                {
                    Produto produto = new Produto();
                    ListProduto = produto.ListaProduto(tbCodProd.Text);
                    if (ListProduto.Count > 0)
                    {
                        if (ListProduto[0].LoteIdeal <= 0)
                        {
                            MessageBox.Show("O Produto " + tbCodProd.Text + " não tem lote mínimo cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbCodProd.Text = "";
                            tbCodProd.Focus();
                        }
                        else
                        {
                            lbDescProd.Text = ListProduto[0].Descricao;
                            LoteIdeal = ListProduto[0].LoteIdeal;
                            lbEstampo.Text = ListProduto[0].Estampo.ToString();
                            lbMateriaPrima.Text = ListProduto[0].MateriaPrima;
                            btCadastrar.Enabled = true;
                            PopulaRoteiro();
                        }
                    }
                    else
                    {
                        lbDescProd.Text = "Produto não encontrado";
                        tbCodProd.Text = "";
                        tbCodProd.Focus();
                        btCadastrar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o Código do Produto","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    tbCodProd.Focus();
                    btCadastrar.Enabled = false;
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

        #region PopulaRoteiro
        private void PopulaRoteiro()
        {
            try
            {
                RoteiroFireBird roteiroFireBird = new RoteiroFireBird();
                ListRoteiroFireBird = roteiroFireBird.BuscaRoteiro(tbCodProd.Text);
                if (ListRoteiroFireBird.Count == 0)
                {
                    dgvRoteiro.DataSource = null;
                    MessageBox.Show("O Produto " + tbCodProd.Text + " não tem Roteiro de Produção cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbCodProd.Text = "";
                    tbCodProd.Focus();
                    btCadastrar.Enabled = false;
                }
                else
                {
                    dgvRoteiro.DataSource = ListRoteiroFireBird;
                    btCadastrar.Enabled = true;
                    dgvRoteiro.ClearSelection();
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

        #region btCadastrar_Click
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbPrioridade.SelectedItem==null)
                {
                    MessageBox.Show("Escolha uma Prioridade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbPrioridade.Focus();
                }
                else if (cbFabrica.SelectedItem == null)
                {
                    MessageBox.Show("Escolha uma Fábrica", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbFabrica.Focus();
                }
                else if(Properties.Settings.Default.ImpressoraRoteiro == "" && Properties.Settings.Default.ImpressoraRoteiro == "")
                {
                    MessageBox.Show("Por favor, configure as impressoras", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!string.IsNullOrEmpty(tbQtde.Text) && Convert.ToInt32(tbQtde.Text) > 0)
                {
                    float LoteFabResto = 0;
                    int LoteFabDiv = 0;

                    LoteFabResto = Convert.ToInt32(tbQtde.Text) % LoteIdeal;
                    LoteFabDiv = Convert.ToInt32(tbQtde.Text) / LoteIdeal;

                    OP op = new OP()
                    {
                        CodProduto = Convert.ToInt32(tbCodProd.Text),
                        Prioridade = cbPrioridade.SelectedItem.ToString(),
                        IdFabrica = Convert.ToInt32(cbFabrica.SelectedItem.ToString()),
                        Qtde = LoteIdeal,
                        Estampo = ListProduto[0].Estampo,
                        MateriaPrima = ListProduto[0].MateriaPrima,
                        Obs = tbOpObs.Text,
                        Usuario = usuario
                    };

                    if (LoteFabDiv > 0)
                    {
                        for (int i = 0; i < LoteFabDiv; i++)
                        {
                            GravaOP(op);
                            DeletaImagens();
                        }
                    }

                    if (LoteFabResto > 0)
                    {
                        op.Qtde = (int)LoteFabResto;
                        GravaOP(op);
                        DeletaImagens();
                    }

                    MessageBox.Show(Msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Msg = "";
                    btCadastrar.Enabled = false;
                    Imprimir = false;
                    ImprimirAviso = false;
                }
                else
                {
                    MessageBox.Show("Preencha o campo quantidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbQtde.Focus();
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

        #region GravaOP
        private void GravaOP(OP op)
        {
            try
            {
                List<string> ListResultadoRoteiro = new List<string>();
                List<string> ListResultadoOP = new List<string>();
                List<RoteiroSQL> ListRoteiro = new List<RoteiroSQL>();
                RoteiroSQL roteiroSQL = new RoteiroSQL();

                ListRoteiroSQL.Clear();
                ListCadastrarOP.Clear();
                ListCadastrarOP.Add(op);
                ListResultadoOP = op.CadastrarOP(ListCadastrarOP);

                #region GravaLog
                log.Tipo = "Informação";
                log.Local = this.GetType().Name + " - " + System.Reflection.MethodBase.GetCurrentMethod().Name;
                log.Login = usuario;
                log.Computador = Environment.MachineName.ToString();
                log.Mensagem = "Criou OP " + ListResultadoOP[0];
                ListLog.Add(log);
                log.GravaLog(ListLog);
                #endregion

                if (Convert.ToInt32(ListResultadoOP[0]) > 0)
                {
                    GeraEtiquetaOP(Convert.ToInt32(ListResultadoOP[0]));

                    for (var i = 0; i < ListRoteiroFireBird.Count; i++)
                    {
                        RoteiroSQL rot = new RoteiroSQL()
                        {
                            IdOP = Convert.ToInt32(ListResultadoOP[0]),
                            IdFabrica = Convert.ToInt32(ListRoteiroFireBird[i].Fabrica),
                            CodSetor = ListRoteiroFireBird[i].CodSetor,
                            NomeSetor = ListRoteiroFireBird[i].NomeSetor,
                            CodAtividade = ListRoteiroFireBird[i].CodAtividade,
                            DescricaoAtividade = ListRoteiroFireBird[i].DescricaoAtividade,
                            Sequencia = ListRoteiroFireBird[i].Sequencia
                        };
                        ListRoteiroSQL.Add(rot);
                        ListRoteiro.Add(rot);
                        ListResultadoRoteiro = roteiroSQL.CadastrarRoteiro(ListRoteiro, Convert.ToInt32(ListResultadoOP[0]));

                        if (Convert.ToInt32(ListResultadoRoteiro[0]) > 0)
                        {
                            ListRoteiroSQL[i].IdRoteiro = Convert.ToInt32(ListResultadoRoteiro[0]);
                            GeraEtiquetaRoteiro(Convert.ToInt32(ListResultadoRoteiro[0]));
                        }
                        else
                        {
                            MessageBox.Show(ListResultadoOP[0].ToString() + " - " + ListResultadoOP[1].ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        ListRoteiro.Clear();
                    }

                    if(Imprimir)
                    {
                        pdOpRoteiro.PrinterSettings.PrinterName = Properties.Settings.Default.ImpressoraRoteiro;
                        pdOpRoteiro.PrintPage += pdOpRoteiro_PrintPage;
                        pdOpRoteiro.Print();

                        pdOpEtiqueta.PrinterSettings.PrinterName = Properties.Settings.Default.ImpressoraEtiqueta;
                        pdOpEtiqueta.PrintPage += pdOpEtiqueta_PrintPage;
                        pdOpEtiqueta.Print();
                    }
                    else
                    {
                        if (!ImprimirAviso)
                        {
                            DialogResult dialogResultOp = MessageBox.Show("Deseja imprimir a OP agora?", "Impressão da OP", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogResultOp == DialogResult.Yes)
                            {
                                pdOpRoteiro.PrinterSettings.PrinterName = Properties.Settings.Default.ImpressoraRoteiro;
                                pdOpRoteiro.PrintPage += pdOpRoteiro_PrintPage;
                                pdOpRoteiro.Print();
                                Imprimir = true;
                            }
                            else
                            {
                                Imprimir = false;
                                ImprimirAviso = true;
                            }

                            DialogResult dialogResultEtiqueta = MessageBox.Show("Deseja imprimir a Etiqueta agora?", "Impressão da Etiqueta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dialogResultEtiqueta == DialogResult.Yes)
                            {
                                pdOpEtiqueta.PrinterSettings.PrinterName = Properties.Settings.Default.ImpressoraEtiqueta;
                                pdOpEtiqueta.PrintPage += pdOpEtiqueta_PrintPage;
                                pdOpEtiqueta.Print();
                                Imprimir = true;
                            }
                            else
                            {
                                Imprimir = false;
                                ImprimirAviso = true;
                            }
                        }
                    }

                    Msg = Msg + "OP: " + ListResultadoOP[0].ToString() + " (Qtde: " +op.Qtde + ") - " + ListResultadoOP[1].ToString() + "\n";
                    tbCodProd.Text = "";
                    tbCodProd.Focus();
                    lbDescProd.Text = "";
                    tbQtde.Text = "";
                    lbEstampo.Text = "";
                    lbMateriaPrima.Text = "";
                    tbOpObs.Text = "";
                    ListResultadoOP.Clear();
                }
                else
                {
                    MessageBox.Show(ListResultadoOP[0].ToString() + " - " + ListResultadoOP[1].ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                pbIdRoteiro.Image.Save(@"C:\Windows\Temp\"+ Numero + ".jpg");
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

        #region CadastrodeOP_FormClosed
        private void CadastrodeOP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

                Image imgLogo = Image.FromFile(@"LogoDovale.jpg");
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
                e.Graphics.DrawString(ListCadastrarOP[0].CodProduto.ToString(), font14B, Brushes.Black, new Rectangle(145, 80, 800, 70));
                e.Graphics.DrawString("Descrição:", font14, Brushes.Black, new Rectangle(220, 80, 800, 70));
                e.Graphics.DrawString(ListProduto[0].Descricao, font14B, Brushes.Black, new Rectangle(315, 80, 800, 70));
                e.Graphics.DrawString("Qtde:", font14, Brushes.Black, new Rectangle(20, 110, 800, 70));
                e.Graphics.DrawString(ListCadastrarOP[0].Qtde.ToString(), font14B, Brushes.Black, new Rectangle(70, 110, 800, 70));
                e.Graphics.DrawString("Data:", font14, Brushes.Black, new Rectangle(180, 110, 800, 70));
                e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy"), font14B, Brushes.Black, new Rectangle(230, 110, 800, 70));
                e.Graphics.DrawString("Estampo:", font14, Brushes.Black, new Rectangle(395, 110, 800, 70));
                e.Graphics.DrawString(ListCadastrarOP[0].Estampo.ToString(), font14B, Brushes.Black, new Rectangle(485, 110, 800, 70));
                e.Graphics.DrawString("Prioridade:", font14, Brushes.Black, new Rectangle(560, 110, 800, 70));
                e.Graphics.DrawString(ListCadastrarOP[0].Prioridade.ToString(), font14B, Brushes.Black, new Rectangle(660, 110, 800, 70));
                e.Graphics.DrawString("MP:", font14, Brushes.Black, new Rectangle(20, 140, 800, 70));
                e.Graphics.DrawString(ListCadastrarOP[0].MateriaPrima.ToString(), font14B, Brushes.Black, new Rectangle(60, 140, 800, 70));

                e.Graphics.DrawString("OBS:", font14, Brushes.Black, new Rectangle(20, 170, 800, 70));
                e.Graphics.DrawString(ListCadastrarOP[0].Obs.ToString(), font14B, Brushes.Black, new Rectangle(70, 170, 800, 70));

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
                    Image imgIdRoteiro = Image.FromFile(@"C:\Windows\Temp\"+ NumeroRoteiro + ".jpg");

                    if(cont==0)
                    {
                        e.Graphics.DrawString(ListRoteiroSQL[i].DescricaoAtividade.ToString(), font10, Brushes.Black, new Rectangle(340, d, 335, 35));
                        e.Graphics.DrawImage(imgIdRoteiro, 654, b, 110, 35);
                        e.Graphics.DrawString(NumeroRoteiro, font7, Brushes.Black, new Rectangle(685, b+37, 335, 35));
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

                Image imgLogo = Image.FromFile(@"LogoDovale.jpg");
                e.Graphics.DrawImage(imgLogo, 20, 25, 125, 25);

                e.Graphics.DrawString("I. R. - IDENTIFICAÇÃO DE RASTREABILIDADE", font12B, Brushes.Black, new Rectangle(160, 30, height, width));
                e.Graphics.DrawString("OP N°", font14, Brushes.Black, new Rectangle(20, 65, height, width));
                e.Graphics.DrawString(ListRoteiroSQL[0].IdOP.ToString(), font16B, Brushes.Black, new Rectangle(20, 90, height, width));
                e.Graphics.DrawString("Qtde", font14, Brushes.Black, new Rectangle(120, 65, 800, 70));
                e.Graphics.DrawString(ListCadastrarOP[0].Qtde.ToString(), font16B, Brushes.Black, new Rectangle(120, 90, height, width));
                e.Graphics.DrawString("Data", font14, Brushes.Black, new Rectangle(250, 65, height, width));
                e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy"), font16B, Brushes.Black, new Rectangle(250, 90, height, width));
                e.Graphics.DrawString("Prioridade", font14, Brushes.Black, new Rectangle(420, 65, height, width));
                e.Graphics.DrawString(ListCadastrarOP[0].Prioridade.ToString(), font14B, Brushes.Black, new Rectangle(420, 90, height, width));
                e.Graphics.DrawString("Cód. Produto", font20, Brushes.Black, new Rectangle(20, 130, height, width));
                e.Graphics.DrawString(ListCadastrarOP[0].CodProduto.ToString(), font20B, Brushes.Black, new Rectangle(20, 160, height, width));
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

        #region tsdmConfigImpressoras_Click
        private void tsdmConfigImpressoras_Click(object sender, EventArgs e)
        {
            Impressora impressora = new Impressora(usuario);
            impressora.Show();
        }
        #endregion

        #region smiApontar_Click
        private void tsmiApontar_Click(object sender, EventArgs e)
        {
            try
            {
                Apontamento apontamento = new Apontamento(usuario);
                apontamento.ShowDialog();
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

        #region tsmiEditarApontamento_Click
        private void tsmiEditarApontamento_Click(object sender, EventArgs e)
        {
            try
            {
                EditarApontamentos editarapontamentos = new EditarApontamentos(usuario);
                editarapontamentos.ShowDialog();
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

        #region tsmiOPImprimir_Click
        private void tsmiOPImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir imprimir = new Imprimir(usuario);
                imprimir.Show();
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

        #region tsmiOPEditar_Click
        private void tsmiOPEditar_Click(object sender, EventArgs e)
        {
            try
            {
                EditarOP apontamentoeditar = new EditarOP(usuario);
                apontamentoeditar.Show();
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
