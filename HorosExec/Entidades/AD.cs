using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace HorosExec.Entidades
{
    class AD
    {
        #region Usuario
        [Required(ErrorMessage = "O Nome do Usuário é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Usuário")]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Login do Usuário é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Login do Usuário")]
        [StringLength(30)]
        public string Login { get; set; }

        [Required(ErrorMessage = "O Email do Usuário é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Email do Usuário")]
        [StringLength(30)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Empresa do Usuário é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Empresa do Usuário")]
        [StringLength(30)]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "O Departamento do Usuário é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Departamento do Usuário")]
        [StringLength(30)]
        public string Departamento { get; set; }

        [Required(ErrorMessage = "O Cargo do Usuário é Obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Cargo do Usuário")]
        [StringLength(30)]
        public string Cargo { get; set; }
        #endregion

        #region LoginAutomatico
        public string LoginAutomatico(string Dominio)
        {
            string domainName = System.Environment.UserDomainName;

            if (domainName.ToUpper() == Dominio.ToUpper())
            {
                string Usuario = SystemInformation.UserName;

                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, Dominio))
                {
                    using (var foundUser = UserPrincipal.FindByIdentity(pc, IdentityType.SamAccountName, Usuario))
                    {
                        if (foundUser != null)
                            return Usuario;
                        else
                            return null;
                    }
                }
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Login
        public bool LoginUsuario(string Dominio, string Usuario, string Senha)
        {
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, Dominio))
            {
                bool isValid = pc.ValidateCredentials(Usuario, Senha);
                if (isValid)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //return true;
        }

        #endregion

        #region BuscaUsuarios
        public List<AD> BuscaUsuarios(string Dominio)
        {
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, Dominio))
            {
                List<AD> usuarios = new List<AD>();

                using (var searcher = new PrincipalSearcher(new UserPrincipal(pc)))
                {
                    foreach (var result in searcher.FindAll())
                    {
                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                        int flags = (int)de.Properties["userAccountControl"].Value;
                        if (!Convert.ToBoolean(flags & 0x0002))
                        {
                            string _Email;
                            if (de.Properties["mail"].Value == null)
                                _Email = "";
                            else
                                _Email = de.Properties["mail"].Value.ToString();

                            string _Empresa;
                            if (de.Properties["company"].Value == null)
                                _Empresa = "";
                            else
                                _Empresa = de.Properties["company"].Value.ToString();

                            string _Departamento;
                            if (de.Properties["department"].Value == null)
                                _Departamento = "";
                            else
                                _Departamento = de.Properties["department"].Value.ToString();

                            string _Cargo;
                            if (de.Properties["title"].Value == null)
                                _Cargo = "";
                            else
                                _Cargo = de.Properties["title"].Value.ToString();

                            AD ad = new AD()
                            {
                                Nome = de.Properties["name"].Value.ToString(),
                                Login = de.Properties["sAMAccountName"].Value.ToString(),
                                Email = _Email,
                                Empresa = _Empresa,
                                Departamento = _Departamento,
                                Cargo = _Cargo,
                            };
                            usuarios.Add(ad);
                        }
                    }
                }
                return usuarios;
            }
        }
        #endregion

        #region BuscaUsuario
        public List<AD> BuscaUsuario(string Dominio, string LoginUsuario)
        {
            PrincipalContext pc = new PrincipalContext(ContextType.Domain, Dominio);
            List<AD> usuario = new List<AD>();
            using (UserPrincipal user1 = new UserPrincipal(pc))
            {
                user1.SamAccountName = LoginUsuario;
                using (var searcher = new PrincipalSearcher(user1))
                {
                    foreach (var result in searcher.FindAll())
                    {
                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                        string _Email;
                        if (de.Properties["mail"].Value == null)
                            _Email = "";
                        else
                            _Email = de.Properties["mail"].Value.ToString();

                        string _Empresa;
                        if (de.Properties["company"].Value == null)
                            _Empresa = "";
                        else
                            _Empresa = de.Properties["company"].Value.ToString();

                        string _Departamento;
                        if (de.Properties["department"].Value == null)
                            _Departamento = "";
                        else
                            _Departamento = de.Properties["department"].Value.ToString();

                        string _Cargo;
                        if (de.Properties["title"].Value == null)
                            _Cargo = "";
                        else
                            _Cargo = de.Properties["title"].Value.ToString();

                        AD ad = new AD()
                        {
                            Nome = de.Properties["name"].Value.ToString(),
                            Login = de.Properties["sAMAccountName"].Value.ToString(),
                            Email = _Email,
                            Empresa = _Empresa,
                            Departamento = _Departamento,
                            Cargo = _Cargo,
                        };
                        usuario.Add(ad);
                    }
                }
            }
            return usuario;
        }
        #endregion

        #region Ping
        public bool Ping()
        {
            Ping ping = new Ping();
            PingReply res = ping.Send("192.168.10.7");
            if (res.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
