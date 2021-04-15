using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HorosExec.Entidades
{
    class Microsys
    {
        
    }

    #region class Produto
    class Produto
    {
        Conexao bd = new Conexao();
        double res;
        string resultado;

        #region Produto
        [Required(ErrorMessage = "O Código do Produto é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Código do Produto", Description = "Selecione o Produto.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int CodProduto { get; set; }

        [Required(ErrorMessage = "A Descrição do Produto é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Descrição do Produto")]
        [StringLength(9)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Lote ideal é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Lote Ideal", Description = "Selecione o Lote Ideal.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int LoteIdeal { get; set; }

        [Required(ErrorMessage = "O Estampo é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Estampo", Description = "Selecione o Estampo.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int Estampo { get; set; }

        [Required(ErrorMessage = "A Materia Prima do Produto é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Materia Prima do Produto")]
        [StringLength(9)]
        public string MateriaPrima { get; set; }
        #endregion

        #region ListaProduto
        public List<Produto> ListaProduto(string Cod)
        {
            List<Produto> produto = new List<Produto>();
            using (FbConnection con = bd.ConexaoSJC())
            {
                con.Open();
                string Consulta = "SELECT PRO_RESUMO, PRO_ESTAMPO_NUMERO FROM PRODUTOS WHERE PRO_CODIGO='" + Cod + "'";
                using (FbCommand cmd = new FbCommand(Consulta, con))
                {
                    using (FbDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                int Est;
                                if(rd["PRO_ESTAMPO_NUMERO"].ToString()=="")
                                {
                                    Est = 0;
                                }
                                else
                                {
                                    Est = Convert.ToInt32(rd["PRO_ESTAMPO_NUMERO"].ToString());
                                }

                                string MP = BuscaMateriaPrima(Cod);
                                if (MP==null)
                                {
                                    MP = "Não cadastrado";
                                }
 
                                Produto prod = new Produto()
                                {
                                    Descricao = rd["PRO_RESUMO"].ToString(),
                                    LoteIdeal = (int)BuscaLoteIdeal(Cod),
                                    Estampo = Est,
                                    MateriaPrima = MP
                                };
                                produto.Add(prod);
                            }
                        }
                    }
                }
                return produto;
            }
        }
        #endregion

        #region BuscaLoteIdeal
        public double BuscaLoteIdeal(string Cod)
        {
            using (FbConnection con = bd.ConexaoSJC())
            {
                con.Open();
                string Consulta = "select PCF_LOTE_MAXIMO from PRODUTOS_CFG_FILIAL prod WHERE pcf_fil_codigo=1 and pcf_pro_codigo='" + Cod + "'";
                using (FbCommand cmd = new FbCommand(Consulta, con))
                {
                    using (FbDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                if (rd["PCF_LOTE_MAXIMO"].ToString() == "")
                                {
                                    res = 0;
                                }
                                else
                                {
                                    res = Convert.ToDouble(rd["PCF_LOTE_MAXIMO"]);
                                }
                            }
                        }
                    }
                }
            }
            return res;
        }
        #endregion

        #region BuscaMateriaPrima
        public string BuscaMateriaPrima(string Cod)
        {
            using (FbConnection con = bd.ConexaoSJC())
            {
                con.Open();
                string Consulta = "select mp.pro_resumo from produtos pro  "+
                                  "inner join produtos_ficha ficha on ficha.pft_pro_codigo = pro.pro_codigo "+
                                  "inner join produtos mp on mp.pro_codigo = ficha.pft_codigo "+
                                  "where pro.pro_codigo = '" + Cod + "'";
                using (FbCommand cmd = new FbCommand(Consulta, con))
                {
                    using (FbDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                if (rd["pro_resumo"].ToString() == "")
                                {
                                    resultado = "Não cadastrado";
                                }
                                else
                                {
                                    resultado = rd["pro_resumo"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            return resultado;
        }
        #endregion
    }
    #endregion

    #region class Fabrica
    class Fabrica
    {
        Conexao bd = new Conexao();

        #region Empresa
        [Required(ErrorMessage = "O Código do Empresa é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Código da Empresa", Description = "Selecione o Produto.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int CodEmpresa { get; set; }

        [Required(ErrorMessage = "A Descrição da Empresa é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Descrição da Empresa")]
        [StringLength(9)]
        public string Empresa { get; set; }
        #endregion

        #region ListaEmpresa
        //public List<Fabrica> ListaEmpresa()
        //{
        //    List<Fabrica> fabrica = new List<Fabrica>();
        //    using (FbConnection con = bd.ConexaoSJC())
        //    {
        //        con.Open();
        //        string Consulta = "SELECT FIL_CODIGO, FIL_NOME FROM FILIAIS";
        //        using (FbCommand cmd = new FbCommand(Consulta, con))
        //        {
        //            using (FbDataReader rd = cmd.ExecuteReader())
        //            {
        //                if (rd.HasRows)
        //                {
        //                    while (rd.Read())
        //                    {
        //                        Fabrica fab = new Fabrica()
        //                        {
        //                            CodEmpresa = (int)rd["FIL_CODIGO"],
        //                            Empresa = rd["FIL_NOME"].ToString(),
        //                        };
        //                        fabrica.Add(fab);
        //                    }
        //                }
        //            }
        //        }
        //        return fabrica;
        //    }
        //}
        #endregion
    }
    #endregion

    #region class Roteiro
    class RoteiroFireBird
    {
        Conexao bd = new Conexao();

        #region Roteiro
        [Required(ErrorMessage = "O Nome da Fábrica é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Fábrica")]
        [StringLength(3)]
        public string Fabrica { get; set; }

        [Required(ErrorMessage = "O Código da atividade é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Código da Atividade", Description = "Selecione o Cód da Atividade.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int CodAtividade { get; set; }

        [Required(ErrorMessage = "A descrição da atividade é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Descrição da Atividade")]
        [StringLength(20)]
        public string DescricaoAtividade { get; set; }

        [Required(ErrorMessage = "O Código do setor é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Código do Setor", Description = "Selecione o Cód do Setor.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int CodSetor { get; set; }

        [Required(ErrorMessage = "O Descrição do setor é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Descrição do Setor")]
        [StringLength(20)]
        public string NomeSetor { get; set; }

        [Required(ErrorMessage = "A Sequencia é Obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Sequencia", Description = "Selecione a Sequencia.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int Sequencia { get; set; }
        #endregion

        #region BuscaRoteiro
        public List<RoteiroFireBird> BuscaRoteiro(string Cod)
        {
            List<RoteiroFireBird> ListRoteiro = new List<RoteiroFireBird>();
            using (FbConnection con = bd.ConexaoSJC())
            {
                con.Open();
                string Consulta = "select '1' fabrica, a.pea_nm_prioridade prioridade, a.pea_atv_codigo cod_atividade, d.set_nome nome_setor, b.atv_descricao descricao_atividade,d.set_codigo codigo_setor " +
                                  "from pcp_estrutura_atividade a " +
                                  "inner join produtos p on p.pro_codigo = a.pea_pro_codigo " +
                                  "inner join pcp_atividade b on b.atv_id = a.pea_atv_codigo " +
                                  "inner join pcp_atividade_setor c on c.ats_atv_id = b.atv_id " +
                                  "inner join pcp_setores d on d.set_codigo = c.ats_set_codigo WHERE p.PRO_CODIGO = '" + Cod + "'";
                using (FbCommand cmd = new FbCommand(Consulta, con))
                {
                    using (FbDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                             while (rd.Read())
                            {
                                RoteiroFireBird roteiro = new RoteiroFireBird()
                                {
                                    Fabrica = rd["fabrica"].ToString(),
                                    CodSetor = Convert.ToInt32(rd["codigo_setor"].ToString()),
                                    NomeSetor = rd["nome_setor"].ToString(),
                                    CodAtividade = Convert.ToInt32(rd["cod_atividade"].ToString()),
                                    DescricaoAtividade = rd["descricao_atividade"].ToString(),
                                    Sequencia = Convert.ToInt32(rd["prioridade"].ToString()),
                                };
                                ListRoteiro.Add(roteiro);
                            }
                        }
                    }
                }
            }

            using (FbConnection con = bd.ConexaoSPM())
            {
                con.Open();
                string Consulta = "select '7' fabrica, a.pea_nm_prioridade prioridade, a.pea_atv_codigo cod_atividade, d.set_nome nome_setor, b.atv_descricao descricao_atividade,d.set_codigo codigo_setor " +
                                  "from pcp_estrutura_atividade a " +
                                  "inner join produtos p on p.pro_codigo = a.pea_pro_codigo " +
                                  "inner join pcp_atividade b on b.atv_id = a.pea_atv_codigo " +
                                  "inner join pcp_atividade_setor c on c.ats_atv_id = b.atv_id " +
                                  "inner join pcp_setores d on d.set_codigo = c.ats_set_codigo WHERE p.PRO_CODIGO = '" + Cod + "'";
                using (FbCommand cmd = new FbCommand(Consulta, con))
                {
                    using (FbDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                RoteiroFireBird roteiro = new RoteiroFireBird()
                                {
                                    Fabrica = rd["fabrica"].ToString(),
                                    CodSetor = Convert.ToInt32(rd["codigo_setor"].ToString()),
                                    NomeSetor = rd["nome_setor"].ToString(),
                                    CodAtividade = Convert.ToInt32(rd["cod_atividade"].ToString()),
                                    DescricaoAtividade = rd["descricao_atividade"].ToString(),
                                    Sequencia = Convert.ToInt32(rd["prioridade"].ToString()),
                                };
                                ListRoteiro.Add(roteiro);
                            }
                        }
                    }
                }
            }

            List<RoteiroFireBird> listaOrigem = new List<RoteiroFireBird>();
            List<RoteiroFireBird> listaOrdenada = ListRoteiro.OrderBy(c => c.Sequencia).ToList();
            return listaOrdenada;
        }
        #endregion
    }
    #endregion

    #region class MotivoApontamento
    class MotivoApontamento
    {
        Conexao bd = new Conexao();

        #region MotivoApontamento
        [Required(ErrorMessage = "O Código do Motivo é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Motivo", Description = "Selecione o Motivo.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int CodMotivo { get; set; }

        [Required(ErrorMessage = "A Descrição do Motivo é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Motivo")]
        [StringLength(150)]
        public string Motivo { get; set; }
        #endregion

        #region ListaMotivo
        public List<MotivoApontamento> ListaMotivoApontamento()
        {
            List<MotivoApontamento> ListMotivo = new List<MotivoApontamento>();
            using (FbConnection con = bd.ConexaoSJC())
            {
                con.Open();
                string Consulta = "SELECT pat_codigo, pat_codigo|| ' - ' ||pat_nome AS Motivo FROM pcp_apto_tipo";
                using (FbCommand cmd = new FbCommand(Consulta, con))
                {
                    using (FbDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                MotivoApontamento motivoApontamento = new MotivoApontamento()
                                {
                                    CodMotivo = (int)rd["pat_codigo"],
                                    Motivo = rd["Motivo"].ToString(),
                                };
                                ListMotivo.Add(motivoApontamento);
                            }
                        }
                    }
                }
                return ListMotivo;
            }
        }
        #endregion

        #region BuscaMotivo
        public string BuscaMotivo(int IdMotivo)
        {
            using (FbConnection con = bd.ConexaoSJC())
            {
                con.Open();
                string Consulta = "SELECT pat_codigo, pat_codigo|| ' - ' ||pat_nome AS Motivo FROM pcp_apto_tipo where pat_codigo='" + IdMotivo + "'";
                using (FbCommand cmd = new FbCommand(Consulta, con))
                {
                    using (FbDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            rd.Read();
                            return rd["Motivo"].ToString();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region class TipoParada
    class TipoParada
    {
        Conexao bd = new Conexao();

        #region TipoParada
        [Required(ErrorMessage = "O Código da Parada é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Codigo", Description = "Selecione o Codigo.")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true, NullDisplayText = "Digite Apenas Números")]
        public int CodTipo { get; set; }

        [Required(ErrorMessage = "A Descrição do Tipo é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Tipo")]
        [StringLength(150)]
        public string Tipo { get; set; }
        #endregion

        #region ListaTipoParada
        public List<TipoParada> ListaTipoParada()
        {
            List<TipoParada> ListTipoParada = new List<TipoParada>();
            using (FbConnection con = bd.ConexaoSJC())
            {
                con.Open();
                string Consulta = "SELECT pmp_codigo, pmp_codigo|| ' - ' ||pmp_nome AS Tipo FROM pcp_motivo_parada";
                using (FbCommand cmd = new FbCommand(Consulta, con))
                {
                    using (FbDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                TipoParada tipoParada = new TipoParada()
                                {
                                    CodTipo = (int)rd["pmp_codigo"],
                                    Tipo = rd["Tipo"].ToString(),
                                };
                                ListTipoParada.Add(tipoParada);
                            }
                        }
                    }
                }
                return ListTipoParada;
            }
        }
        #endregion

        #region BuscaParada
        public string BuscaParada(int IdParada)
        {
            List<TipoParada> ListBuscaParada = new List<TipoParada>();
            using (FbConnection con = bd.ConexaoSJC())
            {
                con.Open();
                string Consulta = "SELECT pmp_codigo, pmp_codigo|| ' - ' ||pmp_nome AS Tipo FROM pcp_motivo_parada where pmp_codigo='" + IdParada + "'";
                using (FbCommand cmd = new FbCommand(Consulta, con))
                {
                    using (FbDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            rd.Read();
                            return rd["Tipo"].ToString();
                        }
                    }
                }
                return null;
            }
        }
        #endregion
    }
    #endregion
}
