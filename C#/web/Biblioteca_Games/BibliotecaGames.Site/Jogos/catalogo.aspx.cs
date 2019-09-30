using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaGames.Entidades;//para o new list<Jogo>
using BibliotecaGames.BLL.Autenticacao;//JogosBo _jogosBo
using BibliotecaGames.BLL;
using System.Web.Security;

namespace BibliotecaGames.Site.Jogos
{
    public partial class catalogo : System.Web.UI.Page
    {
        private JogosBo _jogosBo;
        protected void Page_Load(object sender, EventArgs e)
        {
            /*para não ficar recarregando os dados*/
            if (!Page.IsPostBack)
                CarregarJogosNoRepeater();
            deslogar();
        }
        private void CarregarJogosNoRepeater()
        {
            _jogosBo = new JogosBo();
            /*o repeater serve para repetir algo, como o comando php "echo" da Taverna do Dragão*/
            RepeaterJogos.DataSource = _jogosBo.ObterTodosOsJogos();
            RepeaterJogos.DataBind();
        }
        private void deslogar()
        {
            if (!string.IsNullOrEmpty(Page.Request.QueryString["logout"]))
            {
                FormsAuthentication.SignOut();
                Session.Abandon();
                //FormsAuthentication.RedirectToLoginPage();
                Response.Redirect("/Autenticacao/Site.aspx");
            }
        }
    }
}
