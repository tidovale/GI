using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HorosExec.Entidades
{

    class SQL
    {
        Conexao conexao = new Conexao();

        #region BuscaPermissao
        public string BuscaPermissao(string Usuario)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("Permissao_Select_Id", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        if(drResultado.HasRows)
                        {
                            while (drResultado.Read())
                            {
                                return drResultado.GetString(0);
                            }
                        }
                        return null;
                    }
                }
            }
        }
        #endregion

    }

    #region Class OP
    class OP
    {
        Conexao conexao = new Conexao();

        #region OP
        [Required(ErrorMessage = "O Id da OP é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Id da OP", Description = "Selecione o Id da OP.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdOP { get; set; }

        [Required(ErrorMessage = "O Código do Produto é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Código do Produto", Description = "Selecione o Produto.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int CodProduto { get; set; }

        [Required(ErrorMessage = "A Prioridade é Obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Prioridade")]
        [StringLength(11)]
        public string Prioridade { get; set; }

        [Required(ErrorMessage = "O ID da Fábrica é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Fábrica", Description = "Selecione uma Fábrica.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdFabrica { get; set; }

        [Required(ErrorMessage = "A Quantidade é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Quantidade", Description = "Digite uma Quantidade.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int Qtde { get; set; }

        [Required(ErrorMessage = "O Estampo é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Estampo", Description = "Digite o Estampo.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int Estampo { get; set; }

        [Required(ErrorMessage = "A Data de Cadastro é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "O Status da Ordem de Produção é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Status da Ordem de Produção")]
        [StringLength(9)]
        public string Status { get; set; }

        [Required(ErrorMessage = "A Matéria Prima é Obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Matéria Prima")]
        [StringLength(300)]
        public string MateriaPrima { get; set; }

        [Display(Name = "Observações")]
        [StringLength(500)]
        public string Obs { get; set; }

        [Required(ErrorMessage = "O Login do Usuário de Cadastro é Obrigatório", AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "É permitido somente caractéres válidos.")]
        [Display(Name = "Login do Usuário")]
        [StringLength(30)]
        public string Usuario { get; set; }
        #endregion

        #region CadastrarOP
        public List<string> CadastrarOP(List<OP> OP)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("OP_Insert", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CodProduto", OP[0].CodProduto);
                    cmd.Parameters.AddWithValue("@Prioridade", OP[0].Prioridade);
                    cmd.Parameters.AddWithValue("@IdFabrica", OP[0].IdFabrica);
                    cmd.Parameters.AddWithValue("@Qtde", OP[0].Qtde);
                    cmd.Parameters.AddWithValue("@Estampo", OP[0].Estampo);
                    cmd.Parameters.AddWithValue("@MateriaPrima", OP[0].MateriaPrima);
                    cmd.Parameters.AddWithValue("@Obs", OP[0].Obs);
                    cmd.Parameters.AddWithValue("@Usuario", OP[0].Usuario);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        List<string> Retorno = new List<string>();
                        drResultado.Read();
                        Retorno.Add(drResultado.GetInt32(0).ToString());
                        Retorno.Add(drResultado.GetString(1));
                        return Retorno;
                    }
                }
            }
        }
        #endregion

        #region UpDateOP
        public List<string> UpDateOP(List<OP> OP)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("OP_Update", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOP", OP[0].IdOP);
                    cmd.Parameters.AddWithValue("@Prioridade", OP[0].Prioridade);
                    cmd.Parameters.AddWithValue("@IdFabrica", OP[0].IdFabrica);
                    cmd.Parameters.AddWithValue("@Status", OP[0].Status);
                    cmd.Parameters.AddWithValue("@Qtde", OP[0].Qtde);
                    cmd.Parameters.AddWithValue("@Obs", OP[0].Obs);
                    cmd.Parameters.AddWithValue("@Usuario", OP[0].Usuario);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        List<string> Retorno = new List<string>();
                        drResultado.Read();
                        Retorno.Add(drResultado.GetInt32(0).ToString());
                        Retorno.Add(drResultado.GetString(1));
                        return Retorno;
                    }
                }
            }
        }
        #endregion

        #region BuscaOP
        public List<OP> BuscaOP(string CodOP)
        {
            List<OP> ListOP = new List<OP>();

            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("OP_Select_Id", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOP", CodOP);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        if (drResultado.HasRows)
                        {
                            while (drResultado.Read())
                            {
                                OP op = new OP()
                                {
                                    IdOP = Convert.ToInt32(drResultado["IdOP"]),
                                    CodProduto = Convert.ToInt32(drResultado["CodProduto"]),
                                    Prioridade = drResultado["Prioridade"].ToString(),
                                    IdFabrica = Convert.ToInt32(drResultado["IdFabrica"]),
                                    Qtde = Convert.ToInt32(drResultado["Qtde"]),
                                    Estampo = Convert.ToInt32(drResultado["Estampo"]),
                                    MateriaPrima = drResultado["MateriaPrima"].ToString(),
                                    Obs = drResultado["Obs"].ToString(),
                                    DataCadastro = Convert.ToDateTime(drResultado["DataCadastro"]),
                                    Status = drResultado["Status"].ToString(),
                                    Usuario = drResultado["Usuario"].ToString()
                                };
                                ListOP.Add(op);
                            }
                            return ListOP;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        #endregion

        #region OPUpdateStatus
        public List<string> OPUpdateStatus(int IdOP, string Status)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("SP_OP_Update_Status", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOP", IdOP);
                    cmd.Parameters.AddWithValue("@Status", Status);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        List<string> Retorno = new List<string>();
                        drResultado.Read();
                        Retorno.Add(drResultado.GetInt32(0).ToString());
                        Retorno.Add(drResultado.GetString(1));
                        return Retorno;
                    }
                }
            }
        }
        #endregion

        #region DeleteOP
        public List<string> DeleteOP(int IdOP)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("OP_Delete", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOP", IdOP);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        List<string> Retorno = new List<string>();
                        drResultado.Read();
                        Retorno.Add(drResultado.GetInt32(0).ToString());
                        Retorno.Add(drResultado.GetString(1));
                        return Retorno;
                    }
                }
            }

        }
        #endregion
    }
    #endregion

    #region Class Roteiro
    class RoteiroSQL
    {
        Conexao conexao = new Conexao();

        #region Roteiro
        [Required(ErrorMessage = "O Id do Roteiro é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Id Roteiro", Description = "Selecione o Id do Roteiro.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdRoteiro { get; set; }

        [Required(ErrorMessage = "O Id da OP é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Id OP", Description = "Selecione o Id da OP.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdOP { get; set; }

        [Required(ErrorMessage = "O ID da Fábrica é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Fábrica", Description = "Selecione uma Fábrica.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdFabrica { get; set; }

        [Required(ErrorMessage = "O Código do Setor é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Código do Setor", Description = "Digite o Código do Setor.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int CodSetor { get; set; }

        [Required(ErrorMessage = "O Nome do Setor é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Setor")]
        [StringLength(100)]
        public string NomeSetor { get; set; }

        [Required(ErrorMessage = "O Código da Atividade é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Código da Atividade", Description = "Digite o Código da Atividade.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int CodAtividade { get; set; }

        [Required(ErrorMessage = "A Descrição da Atividade é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Descrição da Atividade")]
        [StringLength(100)]
        public string DescricaoAtividade { get; set; }

        [Required(ErrorMessage = "A Sequencia é Obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Prioridade", Description = "Digite a Sequencia da Prioridade.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int Sequencia { get; set; }
        #endregion

        #region CadastrarRoteiro
        public List<string> CadastrarRoteiro(List<RoteiroSQL> Roteiro, int IdOP)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Roteiro_Insert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOP", IdOP);
                    cmd.Parameters.AddWithValue("@IdFabrica", Convert.ToInt32(Roteiro[0].IdFabrica));
                    cmd.Parameters.AddWithValue("@CodSetor", Roteiro[0].CodSetor);
                    cmd.Parameters.AddWithValue("@NomeSetor", Roteiro[0].NomeSetor);
                    cmd.Parameters.AddWithValue("@CodAtividade", Roteiro[0].CodAtividade);
                    cmd.Parameters.AddWithValue("@DescricaoAtividade", Roteiro[0].DescricaoAtividade);
                    cmd.Parameters.AddWithValue("@Sequencia", Roteiro[0].Sequencia);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        List<string> Retorno = new List<string>();
                        drResultado.Read();
                        Retorno.Add(drResultado.GetInt32(0).ToString());
                        Retorno.Add(drResultado.GetString(1));
                        return Retorno;
                    }
                }
            }
        }
        #endregion

        #region BuscaAtividade
        public List<RoteiroSQL> BuscaAtividade(string IdRoteiro)
        {
            List<RoteiroSQL> ListRoteiroSQL = new List<RoteiroSQL>();

            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("SP_Roteiro_Select_IdAtividade", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdRoteiro", IdRoteiro.TrimStart('0'));

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        if (drResultado.HasRows)
                        {
                            while (drResultado.Read())
                            {
                                RoteiroSQL roteirosql = new RoteiroSQL()
                                {
                                    IdRoteiro = Convert.ToInt32(drResultado["IdRoteiro"]),
                                    IdOP = Convert.ToInt32(drResultado["IdOP"]),
                                    IdFabrica = Convert.ToInt32(drResultado["IdFabrica"]),
                                    NomeSetor = drResultado["NomeSetor"].ToString(),
                                    DescricaoAtividade = drResultado["DescricaoAtividade"].ToString(),
                                    Sequencia = Convert.ToInt32(drResultado["Sequencia"])
                                };
                                ListRoteiroSQL.Add(roteirosql);
                            }
                            return ListRoteiroSQL;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        #endregion

        #region BuscaRoteiro
        public List<RoteiroSQL> BuscaRoteiro(string IdOP)
        {
            List<RoteiroSQL> ListRoteiroSQL = new List<RoteiroSQL>();

            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("SP_Roteiro_Select_Roteiro", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOP", IdOP);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        if (drResultado.HasRows)
                        {
                            while (drResultado.Read())
                            {
                                RoteiroSQL roteirosql = new RoteiroSQL()
                                {
                                    IdRoteiro = Convert.ToInt32(drResultado["IdRoteiro"]),
                                    IdOP = Convert.ToInt32(drResultado["IdOP"]),
                                    IdFabrica = Convert.ToInt32(drResultado["IdFabrica"]),
                                    NomeSetor = drResultado["NomeSetor"].ToString(),
                                    DescricaoAtividade = drResultado["DescricaoAtividade"].ToString(),
                                    Sequencia = Convert.ToInt32(drResultado["Sequencia"])
                                };
                                ListRoteiroSQL.Add(roteirosql);
                            }
                            return ListRoteiroSQL;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        #endregion

        #region BuscaAtividadeAnterior
        public int BuscaAtividadeAnterior(int IdRoteiro)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("SP_Roteiro_Select_VerificaAtividadeAnterior", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdRoteiro", IdRoteiro);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        #endregion

        #region BuscaQtdeAtividadeAnterior
        public int BuscaQtdeAtividadeAnterior(int IdRoteiro, int IdMotivo)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("SP_Roteiro_Select_QtdeAtividadeAnterior", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdRoteiro", IdRoteiro);
                    cmd.Parameters.AddWithValue("@IdMotivo", IdMotivo);
                    var res = cmd.ExecuteScalar();
                    if (res != null)
                    { 
                        return (int)res;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        #endregion

        #region BuscaQtdeAtividadeAnteriorApontada
        public List<string> BuscaQtdeAtividadeAnteriorApontada(int IdOp)
        {
            List<RoteiroSQL> ListRoteiroSQL = new List<RoteiroSQL>();

            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("SP_Roteiro_Select_QtdeAtividadeAnteriorApontada", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOp", IdOp);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        if (drResultado.HasRows)
                        {
                            List<string> Retorno = new List<string>();
                            drResultado.Read();
                            Retorno.Add(drResultado.GetString(1));
                            Retorno.Add(drResultado.GetInt32(2).ToString());
                            return Retorno;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }

        }
        #endregion

        #region BuscaQtdeAtividadeAnteriorApontada
        public int BuscaUltimaAtividadeApontada(int IdOp)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("SP_Roteiro_Select_VerificaUltimaAtividade", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOP", IdOp);
                    var res = cmd.ExecuteScalar();
                    if (res != null)
                    {
                        return (int)res;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }
        #endregion
    }
    #endregion

    #region Class RotApontamento
    class RotApontamento
    {
        Conexao conexao = new Conexao();

        #region Apontamento
        [Required(ErrorMessage = "O Id do Apontamento é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Id Apontamento", Description = "Selecione o Id do Apontamento.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdApontamento { get; set; }

        [Required(ErrorMessage = "O Id do Roteiro é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Id do Roteiro", Description = "Selecione o Id do Roteiro.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdRoteiro { get; set; }

        [Required(ErrorMessage = "O ID do Motivo é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Id do Motivo", Description = "Selecione um Motivo.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdMotivo { get; set; }

        [Required(ErrorMessage = "O Motivo é Obrigatório", AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "É permitido somente caractéres válidos.")]
        [Display(Name = "Motivo")]
        [StringLength(50)]
        public string Motivo { get; set; }

        [Required(ErrorMessage = "O Login do Usuário de Cadastro é Obrigatório", AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "É permitido somente caractéres válidos.")]
        [Display(Name = "Login do Usuário")]
        [StringLength(30)]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "A Data de Cadastro é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "A Quantidade é Obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Qtde", Description = "Selecione uma Qtde.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int Qtde { get; set; }

        [Required(ErrorMessage = "O Peso é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Peso", Description = "Selecione um Peso.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public Double Peso { get; set; }
        #endregion

        #region CadastrarApontamento
        public List<string> CadastrarApontamento(List<RotApontamento> Apontamento)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("OP_Apontamento_Insert", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdRoteiro", Apontamento[0].IdRoteiro);
                    cmd.Parameters.AddWithValue("@IdMotivo", Apontamento[0].IdMotivo);
                    cmd.Parameters.AddWithValue("@Usuario", Apontamento[0].Usuario);
                    cmd.Parameters.AddWithValue("@Qtde", Apontamento[0].Qtde);
                    cmd.Parameters.AddWithValue("@Peso", Apontamento[0].Peso);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        List<string> Retorno = new List<string>();
                        drResultado.Read();
                        Retorno.Add(drResultado.GetInt32(0).ToString());
                        Retorno.Add(drResultado.GetString(1));
                        return Retorno;
                    }
                }
            }
        }
        #endregion

        #region CadastrarJustificativaApontamento
        public List<string> CadastrarJustificativaApontamento(int IdApontamento, int IdJustificativa, string Mensagem)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("SP_OP_Apontamento_Justificativa_Insert", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdApontamento", IdApontamento);
                    cmd.Parameters.AddWithValue("@IdJustificativa", IdJustificativa);
                    cmd.Parameters.AddWithValue("@Mensagem", Mensagem);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        List<string> Retorno = new List<string>();
                        drResultado.Read();
                        Retorno.Add(drResultado.GetInt32(0).ToString());
                        Retorno.Add(drResultado.GetString(1));
                        return Retorno;
                    }
                }
            }
        }
        #endregion

        #region BuscaApontamentoRepetido
        public int BuscaApontamentoRepetido(int IdRoteiro, string IdMotivo)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("SP_Apontamento_Select_ApontamentoRepetido", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdRoteiro", IdRoteiro);
                    cmd.Parameters.AddWithValue("@IdMotivo", IdMotivo);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        #endregion

        #region DeletarApontamento
        public List<string> DeletarApontamento(int IdApontamento)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("OP_Apontamento_Delete", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdApontamento", IdApontamento);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        List<string> Retorno = new List<string>();
                        drResultado.Read();
                        Retorno.Add(drResultado.GetInt32(0).ToString());
                        Retorno.Add(drResultado.GetString(1));
                        return Retorno;
                    }
                }
            }
        }
        #endregion

        #region UpDateApontamento
        public List<string> UpDateApontamento(List<RotApontamento> Apontamento)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("OP_Apontamento_Update", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdApontamento", Apontamento[0].IdApontamento);
                    cmd.Parameters.AddWithValue("@IdMotivo", Apontamento[0].IdMotivo);
                    cmd.Parameters.AddWithValue("@DataCadastro", Apontamento[0].DataCadastro);
                    cmd.Parameters.AddWithValue("@Qtde", Apontamento[0].Qtde);
                    cmd.Parameters.AddWithValue("@Peso", Apontamento[0].Peso);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        List<string> Retorno = new List<string>();
                        drResultado.Read();
                        Retorno.Add(drResultado.GetInt32(0).ToString());
                        Retorno.Add(drResultado.GetString(1));
                        return Retorno;
                    }
                }
            }
        }
        #endregion

    }
    #endregion

    #region Class Apontamentos
    class Apontamentos: RoteiroSQL
    {
        Conexao conexao = new Conexao();

        #region Apontamento
        [Required(ErrorMessage = "O Id do Apontamento é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Id Apontamento", Description = "Selecione o Id do Apontamento.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdApontamento { get; set; }

        [Required(ErrorMessage = "O Id do Roteiro é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Id do Roteiro", Description = "Selecione o Id do Roteiro.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdRoteiro { get; set; }

        [Required(ErrorMessage = "O ID do Motivo é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Id do Motivo", Description = "Selecione um Motivo.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdMotivo { get; set; }

        [Required(ErrorMessage = "O Motivo é Obrigatório", AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "É permitido somente caractéres válidos.")]
        [Display(Name = "Motivo")]
        [StringLength(50)]
        public string Motivo { get; set; }

        [Required(ErrorMessage = "O Login do Usuário de Cadastro é Obrigatório", AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "É permitido somente caractéres válidos.")]
        [Display(Name = "Login do Usuário")]
        [StringLength(30)]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "A Data de Cadastro é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "A Quantidade é Obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Qtde", Description = "Selecione uma Qtde.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int Qtde { get; set; }

        [Required(ErrorMessage = "O Peso é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Peso", Description = "Selecione um Peso.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public Double Peso { get; set; }
        #endregion

        #region BuscaApontamentoIdOP
        public List<Apontamentos> BuscaApontamentoIdOP(string IdOP)
        {
            MotivoApontamento motivoapontamento = new MotivoApontamento();
            List<Apontamentos> ListApontamentos = new List<Apontamentos>();
            string Res;
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("SP_Apontamento_Select_IdOP", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOP", IdOP.TrimStart('0'));

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        if (drResultado.HasRows)
                        {
                            while (drResultado.Read())
                            {

                                Res = motivoapontamento.BuscaMotivo(Convert.ToInt32(drResultado["IdMotivo"]));

                                Apontamentos apontamentos = new Apontamentos()
                                {
                                    IdFabrica = Convert.ToInt32(drResultado["IdFabrica"]),
                                    CodSetor = Convert.ToInt32(drResultado["CodSetor"]),
                                    NomeSetor = drResultado["NomeSetor"].ToString(),
                                    CodAtividade = Convert.ToInt32(drResultado["CodAtividade"]),
                                    DescricaoAtividade = drResultado["DescricaoAtividade"].ToString(),
                                    Sequencia = Convert.ToInt32(drResultado["Sequencia"]),
                                    IdApontamento = Convert.ToInt32(drResultado["IdApontamento"]),
                                    IdRoteiro = Convert.ToInt32(drResultado["IdRoteiro"]),
                                    IdMotivo = Convert.ToInt32(drResultado["IdMotivo"]),
                                    Motivo = Res,
                                    Usuario = drResultado["Usuario"].ToString(),
                                    DataCadastro = Convert.ToDateTime(drResultado["DataCadastro"]),
                                    Qtde = Convert.ToInt32(drResultado["Qtde"]),
                                    Peso = Convert.ToDouble(drResultado["Peso"])
                                };
                                ListApontamentos.Add(apontamentos);
                            }

                            return ListApontamentos;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        #endregion
    }
    #endregion

    #region Class JustificativaApontamento
    class JustificativaApontamento
    {
        Conexao conexao = new Conexao();

        #region JustificativaApontamento
        [Required(ErrorMessage = "O ID é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Id", Description = "Selecione um ID.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Id do Apontamento é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Id Apontamento", Description = "Selecione o Id do Apontamento.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdApontamento { get; set; }

        [Required(ErrorMessage = "O Id do Justificativa é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "IdJustificativa", Description = "Selecione o IdJustificativa.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int IdJustificativa { get; set; }

        [Required(ErrorMessage = "Justificativa é Obrigatório", AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "É permitido somente caractéres válidos.")]
        [Display(Name = "Justificativa")]
        [StringLength(300)]
        public string Justificativa { get; set; }

        [Required(ErrorMessage = "A Data de Cadastro é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Mensagem é Obrigatório", AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "É permitido somente caractéres válidos.")]
        [Display(Name = "Mensagem")]
        [StringLength(300)]
        public string Mensagem { get; set; }


        #endregion

        #region BuscaJustificativaApontamento
        public List<JustificativaApontamento> BuscaJustificativaApontamento(string IdApontamento)
        {
            TipoParada tipoparada = new TipoParada();
            List<JustificativaApontamento> ListJustificativaApontamento = new List<JustificativaApontamento>();
            string Res;
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("SP_OP_Apontamento_Justificativa_Select_Id", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdApontamento", IdApontamento);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                        if (drResultado.HasRows)
                        {
                            while (drResultado.Read())
                            {
                                Res = tipoparada.BuscaParada(Convert.ToInt32(drResultado["IdJustificativa"]));

                                JustificativaApontamento justificativaapontamento = new JustificativaApontamento()
                                {
                                    Id = Convert.ToInt32(drResultado["Id"]),
                                    IdJustificativa = Convert.ToInt32(drResultado["IdJustificativa"]),
                                    Justificativa = Res,
                                    DataCadastro = Convert.ToDateTime(drResultado["DataCadastro"]),
                                    Mensagem = drResultado["Mensagem"].ToString()
                                };
                                ListJustificativaApontamento.Add(justificativaapontamento);
                            }
                            return ListJustificativaApontamento;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        #endregion
    }
    #endregion

}
