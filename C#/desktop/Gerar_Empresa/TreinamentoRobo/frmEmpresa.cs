using Indigosoft.RobotsMethods.Libraries.HtmlAgilityPackExtensions;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using HtmlAgilityPack;
using System.Data.SqlClient;
using System.Text;

namespace TreinamentoRobo
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
            _web = new BrowserSession { Url = "https://www.4devs.com.br/" };
        }
        BrowserSession _web;
        public static string pontuacao;
        public static string empresaDados;
        Empresa empresa = new Empresa();
        SqlConnection connection = new SqlConnection(@"Data Source=INDNOTDEV001\SQLEXPRESS;Initial Catalog=dbJson;Persist Security Info=True;User ID=sa;Password=jp19160518");
        SqlCommand comando = new SqlCommand();
        string json = string.Empty;
        public class Empresa
        {
            public string nomeEmpresa { get; set; }
            public string cnpj { get; set; }
            public string inscricaoEstadual { get; set; }
            public string diaAbertua { get; set; }
            public string site { get; set; }
            public string email { get; set; }
            public string cep { get; set; }
            public string endereco { get; set; }
            public string numero { get; set; }
            public string bairro { get; set; }
            public string cidade { get; set; }
            public string estado { get; set; }
            public string celular { get; set; }
            public string telefone { get; set; }
        }
        private void GerarEmpresa()
        {
            if (radS.Checked == true)
            {
                pontuacao = "S";
            }
            else
            {
                pontuacao = "N";
            }
            string retorno = _web.Post("ferramentas_online.php", "acao=gerar_empresa&pontuacao=" + pontuacao + "&estado=" + cmbEstadoPesquisa.Text + "&idade=" + numAnos);
            var html = retorno.ToHtmlDocument();

            var nome = html.GetElementbyId("nome");
            empresa.nomeEmpresa = nome.GetAttributeByElement("value");
            txtNome.Text = empresa.nomeEmpresa;

            nome = html.GetElementbyId("cnpj");
            empresa.cnpj = nome.GetAttributeByElement("value");
            txtCNPJ.Text = empresa.cnpj;

            nome = html.GetElementbyId("ie");
            empresa.inscricaoEstadual = nome.GetAttributeByElement("value");
            txtInscricaoEstadual.Text = empresa.inscricaoEstadual;

            nome = html.GetElementbyId("data_abertura");
            empresa.diaAbertua = nome.GetAttributeByElement("value");
            txtDataAbertura.Text = empresa.diaAbertua;

            nome = html.GetElementbyId("site");
            empresa.site = nome.GetAttributeByElement("value");
            txtSite.Text = empresa.site;

            nome = html.GetElementbyId("email");
            empresa.email = nome.GetAttributeByElement("value");
            txtEmail.Text = empresa.email;

            nome = html.GetElementbyId("cep");
            empresa.cep = nome.GetAttributeByElement("value");
            txtCEP.Text = empresa.cep;

            nome = html.GetElementbyId("endereco");
            empresa.endereco = nome.GetAttributeByElement("value");
            txtEndereco.Text = empresa.endereco;

            nome = html.GetElementbyId("numero");
            empresa.numero = nome.GetAttributeByElement("value");
            txtNumero.Text = empresa.numero;

            nome = html.GetElementbyId("bairro");
            empresa.bairro = nome.GetAttributeByElement("value");
            txtBairro.Text = empresa.bairro;

            nome = html.GetElementbyId("cidade");
            empresa.cidade = nome.GetAttributeByElement("value");
            txtCidade.Text = empresa.cidade;

            nome = html.GetElementbyId("estado");
            empresa.estado = nome.GetAttributeByElement("value");
            txtEstado.Text = empresa.estado;

            nome = html.GetElementbyId("telefone_fixo");
            empresa.telefone = nome.GetAttributeByElement("value");
            txtTelefone.Text = empresa.telefone;

            nome = html.GetElementbyId("celular");
            empresa.celular = nome.GetAttributeByElement("value");
            txtCelular.Text = empresa.celular;

        }
        private void gerarEstado()
        {
            string retorno = _web.Get("gerador_de_pessoas");
            var html = retorno.ToHtmlDocument();
            var estados = html.GetElementById("cep_estado");
            var valoresEstado = estados.GetElementsByTag("option");
            for (int i = 0; i < valoresEstado.Count; i++)
            {
                var item = valoresEstado[i].InnerText;
                var valor = valoresEstado[i].Attributes.FirstOrDefault().Value;
                cmbEstadoPesquisa.Items.Add(valor);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gerarEstado();
        }
        private void btnGerarEmpresa_Click(object sender, EventArgs e)
        {
            if (numAnos.Value == 0)
            {
                MessageBox.Show("Você não informou quantos anos a empresa tem.", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cmbEstadoPesquisa.Text == "")
                {
                    MessageBox.Show("Você não informou a qual estado a empresa pertence.", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GerarEmpresa();
                    json = JsonConvert.SerializeObject(empresa);
                }
            }
        }
        private void SerializarJson()
        {
            DialogResult dialogResult = MessageBox.Show("Gravar Json no Banco de Dados?", "Json", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    comando.Connection = connection;
                    comando.CommandText = "insert into tblJson (conteudo) values (@conteudo);";
                    comando.Parameters.AddWithValue("@conteudo", json);
                    comando.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Json salvo com sucesso no banco de dados", "Json", MessageBoxButtons.OK);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar o Json:\n" + erro, "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                return;
            }
        }
        private void btnJson_Click_1(object sender, EventArgs e)
        {
            SerializarJson();
        }
        private void btnCopiarJson_Click(object sender, EventArgs e)
        {
            if (json == "")
            {
                MessageBox.Show("Nenhum Json selecionado", "Json", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Clipboard.SetText(json);
                MessageBox.Show("Json copiada para á área de transferencia", "Json", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

