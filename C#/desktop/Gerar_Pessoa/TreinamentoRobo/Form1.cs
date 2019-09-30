using Indigosoft.RobotsMethods.Libraries.HtmlAgilityPackExtensions;
//using Indigosoft.RobotsMethods.Libraries.HtmlAgilityPackExtensions.Helpers;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TreinamentoRobo
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //var helper = new HttpWebResponseHelper("https://www.4devs.com.br/")
            //{
            //    CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore),
            //    Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3",
            //    UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/73.0.3683.86 Safari/537.36",
            //    KeepAlive = true,
            //    AutomaticDecompression = DecompressionMethods.GZip,
            //};

            //helper.Headers.Add("Accept-Language: pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
            //helper.Headers.Add("Accept-Encoding: gzip, deflate, br");

            _web = new BrowserSession { Url = "https://www.4devs.com.br/" };
        }
        BrowserSession _web;
        private void btnIniciarOpcoes_Click(object sender, EventArgs e)
        {
            //TODO Iniciar Sessao do WebRequest (Carregando as informações iniciais da página. Ex.: Opções de Idade, Estado e Cidade).
        }
        private void cmbEstadoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO Recarregar o combo Cidade a partir do Estado escolhido.
            //_web.SetReferer("https://www.4devs.com.br/gerador_de_pessoas");
            string retorno = _web.Post("ferramentas_online.php", "acao=carregar_cidades&cep_estado=" + cmbEstadoPesquisa.Text);
            var html = retorno.ToHtmlDocument();
            var valoresCidade = html.GetElementsByTag("option");
            for (int i = 0; i < valoresCidade.Count; i++)
            {
                var t = valoresCidade[i].NextSibling.InnerText;
                cmbCidadePesquisa.Items.Add(t);
            }
        }
        private void btnGerarPessoa_Click(object sender, EventArgs e)
        {
            //TODO Enviar o post para gerar um perfil de uma pessoa com base nas opções escolhidas no form e preencher o mesmo com as informações recebidas.
            gerarPessoa();
        }
        /*fiz essa váriavel e a de baixo pois o "sexo" no _web.Post o sexo não estava funcionando*/public static string sexo;
        public static string pontuacao;
        public class pessoa
        {
            public string nome { get; set; }
            public int idade { get; set; }
            public string cpf { get; set; }
            public string rg { get; set; }
            public string data_nasc { get; set; }
            public string signo { get; set; }
            public string mae { get; set; }
            public string pai { get; set; }
            public string email { get; set; }
            public string senha { get; set; }
            public string cep { get; set; }
            public string endereco { get; set; }
            public int numero { get; set; }
            public string bairro { get; set; }
            public string cidade { get; set; }
            public string estado { get; set; }
            public string telefone_fixo { get; set; }
            public string celular { get; set; }
            public double altura { get; set; }
            public double peso { get; set; }
            public string tipo_sanguineo { get; set; }
            public string cor { get; set; }
        }
        private void gerarPessoa()
        {
            if(radM.Checked == true)
            {
                 sexo = "H";
            }else
            {
                 sexo = "I";
            }
            if (radS.Checked == true)
            {
                pontuacao = "S";
            }else
            {
                pontuacao = "N";
            }

            string retorno = _web.Post("ferramentas_online.php","acao=gerar_pessoa&sexo=" + sexo + "&pontuacao=" + pontuacao + "&idade=" + cmbIdade.Text + "&cep_estado=" + cmbEstadoPesquisa.SelectedText + "&txt_qtde=1&cep_cidade=" + cmbCidadePesquisa./*se não colcar o "selectedIndex" não funciona, pois manda o texto e não o index, o mesmo para o próximo*/SelectedText);
            
            string json = retorno;

            pessoa pessoa = JsonConvert.DeserializeObject<pessoa>(json);
            txtAltura.Text = Convert.ToString(pessoa.altura);
            txtBairro.Text = pessoa.bairro;
            txtCelular.Text = pessoa.celular;
            txtCep.Text = pessoa.cep;
            txtCidade.Text = cmbCidadePesquisa.Text;
            txtCorFavorita.Text = pessoa.cor;
            txtCpf.Text = pessoa.cpf;
            txtDataNascimento.Text = pessoa.data_nasc;
            txtEmail.Text = pessoa.email;
            txtEndereco.Text = pessoa.endereco;
            txtEstado.Text = cmbEstadoPesquisa.Text;
            txtNome.Text = pessoa.nome;
            txtNomeDaMae.Text = pessoa.mae;
            txtNomeDoPai.Text = pessoa.pai;
            txtNumero.Text = Convert.ToString(pessoa.numero);
            txtPeso.Text = Convert.ToString(pessoa.peso);
            txtRg.Text = pessoa.rg;
            txtSenha.Text = pessoa.senha;
            txtSigno.Text = pessoa.signo;
            txtTelefone.Text = pessoa.celular;
            txtTipoSanguinio.Text = pessoa.tipo_sanguineo;
        }
        private void gerarIdade()
        {
            string retorno = _web.Get("gerador_de_pessoas");
            var html = retorno.ToHtmlDocument();
            var idade = html.GetElementbyId("idade");
            var valoresIdade = idade.GetElementsByTag("option");
            for (int i = 0; i < valoresIdade.Count; i++)
            {
                var item = valoresIdade[i];
                var valor = item.Attributes[0].Value;
                //int lista = Convert.ToInt16(valor);
                //int[] vetor = new int[i];
                cmbIdade.Items.Add(valor);
            }
        }
        private void gerarEstado()
        {
            string retorno = _web.Get("gerador_de_pessoas");
            var html = retorno.ToHtmlDocument();
            var estados = html.GetElementById("cep_estado");
            var valoresEstado = estados.GetElementsByTag("option");
            for (int i = 0; i < valoresEstado.Count; i++)
            {
                var item = valoresEstado/*o i está difinido que vai começar zero*/[i].InnerText;
                var valor = valoresEstado[i].Attributes.FirstOrDefault().Value;
                cmbEstadoPesquisa.Items.Add(valor);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gerarIdade();
            gerarEstado();
        }
    }
}
