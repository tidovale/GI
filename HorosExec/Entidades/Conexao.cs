using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HorosExec.Entidades
{
    class Conexao
    {
        private static FbConnectionStringBuilder conn = null;
        private static SqlConnection con = null;

        #region ConexaoSJC
        public FbConnection ConexaoSJC()
        {
            conn = new FbConnectionStringBuilder();
            conn.DataSource = "//192.168.10.9";
            conn.Port = 3050;
            conn.Database = "192.168.10.9:/home/dados/MSYSDADOS.FDB";
            conn.UserID = "sysdba";
            conn.Password = "masterkey";
            conn.ServerType = FbServerType.Default;

            FbConnection db = new FbConnection(conn.ToString());
            return db;
        }
        #endregion

        #region ConexaoSPM
        public FbConnection ConexaoSPM()
        {
            conn = new FbConnectionStringBuilder();
            conn.DataSource = "//192.168.10.9";
            conn.Port = 3050;
            conn.Database = "192.168.10.9:/home/dadosmg/MSYSDADOS.FDB";
            conn.UserID = "sysdba";
            conn.Password = "masterkey";
            conn.ServerType = FbServerType.Default;

            FbConnection db = new FbConnection(conn.ToString());
            return db;
        }
        #endregion

        #region ConexaoSQL
        public SqlConnection ConexaoSQL()
        {
            string BancoServidor;
                //BancoServidor = "192.168.10.12"; //HMG
                BancoServidor = "192.168.10.125"; //PROD
            string BancoNome = "Horus";
            string BancoUsuario = "sa";
            string BancoSenha = "Elavod@2018@";
            con = new SqlConnection(@"Data Source=" + BancoServidor + ";" + "Initial Catalog=" + BancoNome + ";" + "User ID=" + BancoUsuario + ";" + "Password=" + BancoSenha + ";");
            return con;
        }
        #endregion 
    }
}
