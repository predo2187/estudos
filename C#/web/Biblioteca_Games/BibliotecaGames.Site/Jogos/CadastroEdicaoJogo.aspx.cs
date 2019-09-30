using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//adicioandos
using BibliotecaGames.BLL;
using BibliotecaGames.BLL.Autenticacao;
using BibliotecaGames.Entidades;
using System.Data.SqlClient;
using BibliotecaGames.DAL;

namespace BibliotecaGames.Site.Jogos
{
    public partial class CadastroEdicaoJogo : Page
    {
        private EditoraBo _editorBo;
        private GeneroBo _generoBo;
        private JogosBo _jogosBo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                CarregarEditoresNaCombo();
                CarregarGenerosNaCombo();

                if (EstaEmModoEdicao())
                {
                    CarregarDadosParaEdicao();

                }

            }
        }
        protected void btnGravar_Click(object sender, EventArgs e)
        {
            _jogosBo = new JogosBo();
            //como tem o "ObterModeloPreechido" esse não é mais necessáriovar jogo = new Jogo();

            var jogo = ObterModeloPreechido();

            var menssagemdeSucesso = "";


            /*esse try é para ver se vai dar erro ao salvar a imagem*/
                                                                      try
            {
                jogo.Imagem = GravarImagemNoDisco();//vai pegar o valor retornado pelo método, que no caso é a váriavel "fileName"
            }
            catch(Exception erro)
            {
                lblMensagem.Text = "Ocorreu um erro ao salvar:\n" + erro;

            }
            try
            {
                if (EstaEmModoEdicao())
                {
                    _jogosBo.AlterarJogo(jogo);
                    menssagemdeSucesso = "Jogo alterado com sucesso.";
                }else
                {
                    _jogosBo.InserirNovoJogo(/*vai pegar os parametros declarados a cima*/jogo);
                    menssagemdeSucesso = "Jogo cadastrado com sucesso.";
                }
                lblMensagem.ForeColor = System.Drawing.Color.Green;
                lblMensagem.Text = menssagemdeSucesso;
                btnGravar.Enabled = false;
            }catch(Exception erro)
            {
                lblMensagem.ForeColor = System.Drawing.Color.Red;
                lblMensagem.Text = "ocorreu um erro ao cadastrar o jogo:\n" + erro;
            }

        }
        private /*private "Jogo" pois ele retorna um objeto jogo*/Jogo ObterModeloPreechido()
        {
            var jogo = new Jogo();
            jogo.Titulo = txtTitulo.Text;
            jogo.valorPago = string.IsNullOrWhiteSpace(txtValorPago.Text) ? (double?)null : Convert.ToDouble(txtValorPago.Text);
            jogo.DataCompra = string.IsNullOrWhiteSpace(txtDataCompra.Text) ? (DateTime?)null : Convert.ToDateTime(txtDataCompra.Text);
            jogo.idEditor = Convert.ToInt32(ddlEditora.SelectedValue);
            jogo.idGenero = Convert.ToInt32(ddlGenero.SelectedValue);
            jogo.Id = ObterIdDoJogo();

            return jogo;
        }
        private string GravarImagemNoDisco()//como o objetivo desse método é passar o valor para o "jogo.Imagem" se ele for void ele não vai mandar, então por isso de ter o return na váriavel file name
        {
            /*se o fileoploadimage tiver um arquivo nele*/if (FileOploadImage.HasFile)
            {
                try
                {
                    var caminho = $"{AppDomain.CurrentDomain.BaseDirectory}Content\\ImagensJogos\\";
                    var fileName = $"{DateTime.Now.ToString("yyyyMMddhhmmss")}_{FileOploadImage.FileName}";
                    FileOploadImage.SaveAs($"{ caminho}{fileName}");
                    return fileName;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }else
            {
                return null;
            }

        }
        private void CarregarEditoresNaCombo()
        {
            _editorBo = new EditoraBo();
            var editores = _editorBo.ObterTodasAsEditoras();
            ddlEditora.DataSource = editores;
            ddlEditora.DataBind();
        }
        private void CarregarGenerosNaCombo()
        {
            _generoBo = new GeneroBo();
            var generos = _generoBo.ObterTodosOsGeneros();
            ddlGenero.DataSource = generos;
            ddlGenero.DataBind();
        }
        public void CarregarDadosParaEdicao()
        {
            _jogosBo = new JogosBo();
            var id = ObterIdDoJogo();

            var jogo = _jogosBo.ObterJogoPeloId(/*está procurando o jogo pelo id infomrado no "ObterIdDoJogo*/id);
            
            txtTitulo.Text = jogo.Titulo;
            txtValorPago.Text = Convert.ToString(jogo.valorPago);
            txtDataCompra.Text = jogo.DataCompra.HasValue ? jogo.DataCompra.Value./*para inserir no campo de dato, a data string tem que star fomratado no formato universal de data*/ToString("yyyy-MM-dd") : string.Empty;
            ddlEditora.SelectedValue = Convert.ToString(jogo.idEditor);
            ddlGenero.SelectedValue = Convert.ToString(jogo.idGenero);
        }
        public /*ele está retornando um valor int, então deve ser uma "public int"*/int ObterIdDoJogo()
        {
            var id = 0;
            var idQueryString = Request.QueryString["id"];
            if (/*se conseguir converter*/int.TryParse(idQueryString,out id))
            {
                if (id <= 0) {
                    throw new Exception("Id inválida");
                }

                return id;

            }else
            {
                return id;
            }

        }

        public bool EstaEmModoEdicao()
        {
            return Request.QueryString.AllKeys.Contains("id");
        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            var id = ObterIdDoJogo();
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "delete from jogos where id = @id;";

                command.Parameters.AddWithValue("@id", id);
                Conexao.Conectar();
                command.ExecuteNonQuery();
                Response.Redirect("/Jogos/catalogo.aspx");

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Conexao.Desconectar();
               
            }
        }
    }
}