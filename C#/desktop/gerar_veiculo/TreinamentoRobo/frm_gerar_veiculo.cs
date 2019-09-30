using Indigosoft.RobotsMethods.Libraries.HtmlAgilityPackExtensions;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using HtmlAgilityPack;

namespace TreinamentoRobo
{
    public partial class frm_gerar_veiculo : Form
    {
        public frm_gerar_veiculo()
        {
            InitializeComponent();
            _web = new BrowserSession { Url = "https://www.4devs.com.br/" };
        }
        BrowserSession _web;
        public static string pontuacao;
        public class veiculo{
        public string marca { get; set; }
        public string modelo { get; set; }
        public string ano { get; set; }
        public string renavam { get; set; }
       public string placa { get; set; }
       public string cor { get; set; }
        }
        private void gerarCarro()
        {
            if (radS.Checked == true)
            {
                pontuacao = "S";
            }
            else
            {
                pontuacao = "N";
            }
            string retorno = _web.Post("ferramentas_online.php", "acao=gerar_veiculo&pontuacao=" + pontuacao + "&estado=" + cmbEstadoPesquisa.Text + "&fipe_codigo_marca=" + cmbMarca.ValueMember);
            var html = retorno.ToHtmlDocument();

            veiculo veiculo = new veiculo();

            var carro = html.GetElementbyId("marca");
            veiculo.marca = carro.GetAttributeByElement("value");
            txtMarc.Text = veiculo.marca;

            carro = html.GetElementbyId("modelo");
            veiculo.modelo = carro.GetAttributeByElement("value");
            txtModelo.Text = veiculo.modelo;

            carro = html.GetElementbyId("ano");
            veiculo.ano = carro.GetAttributeByElement("value");
            txtAno.Text = veiculo.ano;

            carro = html.GetElementbyId("renavam");
            veiculo.renavam = carro.GetAttributeByElement("value");
            txtRENAVAM.Text = veiculo.renavam;

            carro = html.GetElementbyId("placa_veiculo");
            veiculo.placa = carro.GetAttributeByElement("value");
            txtPlaca.Text = veiculo.placa;

            carro = html.GetElementbyId("cor");
            veiculo.cor = carro.GetAttributeByElement("value");
            txtCor.Text = veiculo.cor;
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
        private void gerarMarca()
        {
            string retorno = _web.Get("gerador_de_veiculos");
            var html = retorno.ToHtmlDocument();
            var marcas = html.GetElementById("fipe_codigo_marca");
            var valoresMarcas = marcas.GetElementsByTag("option");
            for (int i = 0; i < valoresMarcas.Count; i++)
            {
                var idMarca = valoresMarcas[i].Attributes.FirstOrDefault().Value;
                var marca = valoresMarcas[i].NextSibling.InnerText;
                byte[] bytes = System.Text.Encoding.Default.GetBytes(marca);
                marca = System.Text.Encoding.UTF8.GetString(bytes);
                cmbMarca.Items.Add(marca);
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            gerarEstado();
            gerarMarca();
        }
        private void tbnGerar_Click_1(object sender, EventArgs e)
        {
            gerarCarro();
        }
    }
}
