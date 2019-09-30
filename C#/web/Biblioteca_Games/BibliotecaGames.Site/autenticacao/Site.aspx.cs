using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//adicionados
using BibliotecaGames.BLL.Autenticacao;//LoginBo
using BibliotecaGames.BLL.Exceptions;//UsuarioNaoCadastradoException
using System.Web.Security;//FormsAuthentication
using System.Threading;//TimeOut

namespace BibliotecaGames.Site.autenticacao
{
    public partial class Site : System.Web.UI.Page
    {
        private LoginBo _loginBo;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bntLogin_Click(object sender, EventArgs e)
        {
            _loginBo = new LoginBo();

            var nomeusuario = txtUsuario.Text;
            var senha = txtSenha.Text;
            /*quando loga*/try
            {
                var usuario = _loginBo.ObterUsuarioParaLogar(nomeusuario, senha);
                /*faz com que o usuário vá para  alogin page, definida no webConfig*/FormsAuthentication.RedirectFromLoginPage(nomeusuario, false);
                Session.Timeout = 30;//Isso é para definir o tempo que sessão vai durar, coloca o mesmo que  ado site no webConfig
                Session["Perfil"] = usuario.Perfil;//Isso é para passar o valor "Perfil" para a página catalogo.aspx, tipo o qe você fez para definir o id do usuário no mangaDatabase


            }
            /*não tem o usuário no banco de dados*/catch (UsuarioNaoCadastradoException)
            {
                lblStatus.Text = "Usuário não cadastrado.";
            }
            /*erro desconhecido*/catch (Exception)
            {

                lblStatus.Text = "Ocorreu um erro inesperado, consulte o adiminstrador do sistema.";
            }
        }
    }
}