using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HorosExec.Entidades
{
    class Log
    {

        Conexao conexao = new Conexao();
        public bool Prod = true;

        #region Log
        [Required(ErrorMessage = "O Tipo do Log é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Tipo do Log")]
        [StringLength(10)]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "O Local do Log é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Local do Log")]
        [StringLength(150)]
        public string Local { get; set; }

        [Required(ErrorMessage = "O Loguin é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Login do Log")]
        [StringLength(30)]
        public string Login { get; set; }

        [Required(ErrorMessage = "O Computador é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Computador do Log")]
        [StringLength(30)]
        public string Computador { get; set; }

        [Required(ErrorMessage = "A Mensagem é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Mensagem do Log")]
        [StringLength(300)]
        public string Mensagem { get; set; }
        #endregion

        #region GravaLog
        public void GravaLog(List<Log> Log)
        {
            using (SqlConnection conn = conexao.ConexaoSQL())
            {
                using (SqlCommand cmd = new SqlCommand("Log_Insert", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Tipo", Log[0].Tipo);
                    cmd.Parameters.AddWithValue("@Local", Log[0].Local);
                    cmd.Parameters.AddWithValue("@Usuario", Log[0].Login);
                    cmd.Parameters.AddWithValue("@Computador", Log[0].Computador);
                    cmd.Parameters.AddWithValue("@Mensagem", Log[0].Mensagem);

                    using (SqlDataReader drResultado = cmd.ExecuteReader())
                    {
                    }     
                }
            }
        }
        #endregion
    }
}
