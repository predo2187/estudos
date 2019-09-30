using System;
using System.Net;
using System.Windows.Forms;
namespace TreinamentoRobo
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
            _web = new BrowserSession { Url = "https://cdv.escale.com.br/" };
        }
        BrowserSession _web;
        string cepInvalido = "Cep Inválido.";
        string regiaoNCabeamento = "Sua região ainda não tem cabeamento.";
        string regiaoTemCabeamento = "Sua região tem cabeamento.";
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string cep = maskCep.Text;
            cep = cep.Replace("-", "");
            if (cep.Length <= 7)
            {
                MessageBox.Show(cepInvalido, "Cep Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string get = _web.Get("/api/cep/" + cep);
            if (get.Length <= 2)
            {
                MessageBox.Show(regiaoNCabeamento, "Cabemamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(regiaoTemCabeamento, "Cabeamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            maskCepForm1.Clear();
            maskCep.Clear();
        }
        private void btnverificarForm2_Click(object sender, EventArgs e)
        {
            string cep = maskCepForm1.Text;
            cep = cep.Replace("-", "");
            if (cep.Length <= 7)
            {
                MessageBox.Show(cepInvalido, "Cep Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var wc = new WebClient();
            string pagina = wc.DownloadString("https://cdv.escale.com.br/api/cep/" + cep);
            if (pagina.Length <= 2)
            {
                MessageBox.Show(regiaoNCabeamento, "Cabemamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(regiaoTemCabeamento, "Cabeamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            maskCepForm1.Clear();
            maskCep.Clear();
        }
    }
}
