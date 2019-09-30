using System.Text;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Linq;
using System.Windows.Forms;
//os 3 abaixo foram adiconados
using System.Net;
using HtmlAgilityPack;using System.Diagnostics;

namespace captura_perguntas_msdn
{
    public partial class frmCapturaPerguntas : Form
    {
        public frmCapturaPerguntas()
        {
            InitializeComponent();
        }
        int pag = 0;
        string id = string.Empty;
        string titulo = string.Empty;
        string postagem = string.Empty;
        string exibicao = string.Empty;
        string respostas = string.Empty;
        string link = string.Empty;
        string linka = string.Empty;
        string data = string.Empty;
        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            //a variável pag fica pode ficar com outros valores então sempre define para 1 quando atualizar
            pag = 1;
            lblPag.Text = Convert.ToString(pag);
            carregar();
        }
        private void carregar()
        {
        var wc = new WebClient();
        /*essa string baixou o texto da página html*/
        string pagina = wc./*mais especificamente isso baixou a página*/DownloadString("https://social.msdn.microsoft.com/Forums/pt-br/home?sort=lastpostdesc&brandIgnore=true&page=" + pag);
        var htmlDocument = new /*do pacote que você baixou*/HtmlAgilityPack.HtmlDocument();
        htmlDocument.LoadHtml(/*aqui dentro ele espera uma string, que no caso é a nossa página html*/pagina);
        dgvMSDN.Rows.Clear();
            foreach (/*para usar isso é necessário o HtmlAgilityPack, esse node pega os filhos, então por isso o laço de repetição
                pois ele vai pegar os dados até não ter mais*/HtmlNode node in htmlDocument.GetElementbyId(/*esse é o id do ul que ocntem as perguntas*/"threadList").ChildNodes)
            {
                if (/*essa verificação é para saber que o node stá com algum atributo, por isso o ".Count >0"*/node.Attributes.Count > 0)
                {
                    id = node.Attributes[/* está buscando o atributo do site, que está dentro do ul*/"data-threadid"].Value;
                    link = /*contatenação básica, já que a extensão do link é pega pelo node, apenas a inserimos dentro do url padrão do site*/"https://social.msdn.microsoft.com/forums/pt-br/" + id;
                    titulo = WebUtility.HtmlDecode(node.Descendants().First(x => x.Id.Equals(/*no site o threadTitle é seguido pelo mesmo valor de sua id*/"threadTitle_" + id))/*aqui já é para pegar o titulo mesmo*/.InnerText);
                    //tranforma em utf-8
                    byte[] bytes = Encoding.Default.GetBytes(titulo);
                    titulo = Encoding.UTF8.GetString(bytes);
                    //termina de tranformar
                    postagem = /*isso é para converter o texto html para o padrão do c#*/WebUtility.HtmlDecode(node.Descendants().First(x => /*aqui verifica se o atributo existe*/x.Attributes["class"] != null && x.Attributes/*aqui está buscando os atributos*/["class"].Value.Equals/*aqui buscou o atributo de valor "lastpost"*/("lastpost")).InnerText./*como no html tem várias quebras d elinhas este código é para remove-las*/Replace("\n", /*esse segundo é o que será iserido no lugar*/"").Replace("  ", "").Replace("Created by", "Postado por: "));
                    //os códigos abaixo são indenticos pois são propriedades semelhantes e que estão próximas
                    exibicao = WebUtility.HtmlDecode(node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("viewcount")).InnerText.Replace("\n", "").Replace("  ", " "));
                    respostas = WebUtility.HtmlDecode(node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("replycount")).InnerText.Replace("\n", "").Replace("  ", " "));
                    //verifica se obteve exito em verificar as informações
                    if (!string.IsNullOrEmpty(titulo))
                    {
                        dgvMSDN.Rows.Add(titulo, postagem, exibicao, respostas, link);
                    }
                }
            }
        }
        private void carregarRespostas()
        {
            var wc2 = new WebClient();
            string pagina2 = wc2.DownloadString(linka);
            var htmlDocument2 = new HtmlAgilityPack.HtmlDocument();
            htmlDocument2.LoadHtml(pagina2);
            /*faz a pesquisa no htmlDocument2 para ver se dentro dele existe o "allReplies"*/
            var allreplies = htmlDocument2.GetElementbyId("allReplies");
            if (allreplies == null)
            {
                return;
            }
            /*aqui está contatenando o o texto allreplies com childNodes, para formar um código*/
            var child = allreplies.ChildNodes;
            /*esse if conta quantos registros tem no child, pois nesse site posts sem resposta não tem child*/
            if (child.Count > 2)
            {
                foreach (HtmlNode replie in child[3].ChildNodes)
                {
                    if (replie.Attributes.Count > 0)
                    {
                        var nome = replie.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("userInfo")).InnerHtml;

                        nome = nome.Substring(nome.IndexOf("Threads de"));
                        nome = nome.Substring(0, nome.IndexOf("\"}'"));
                        nome = nome.Replace("Threads de ", "");
                        nome = /*precisa disso para não vir com problema &#233, deve ser por que são dados html*/WebUtility.HtmlDecode(nome);
                        data = WebUtility.HtmlDecode(replie.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("actions"))./*pega o primeiro child node*/ChildNodes[1].InnerHtml);

                        var pontos = replie.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("userInfo")).InnerHtml;

                        if (!string.IsNullOrEmpty(nome))
                        {
                            dgvdados.Rows.Add(nome, data);
                        }
                    }
                }
            }
        }
        //A baixo está apenas as ações que atuam mudando a página
        private void dgvMSDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvdados.Rows.Clear();
            linka = dgvMSDN.Rows[e.RowIndex].Cells[4].Value.ToString();
            carregarRespostas();
            if (e.ColumnIndex == 4)
            {
                /*esse comando é para o link abrir em um navegador*/Process.Start(new ProcessStartInfo(dgvMSDN.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
            }
        }
        private void btnProx_Click(object sender, EventArgs e)
        {
                dgvdados.Rows.Clear();
                dgvMSDN.Rows.Clear();
                pag += 1;
                lblPag.Text = Convert.ToString(pag);
                carregar();
        }
        private void btnVolt_Click(object sender, EventArgs e)
        {
            if (pag < 1)
            {
                return;
            }
            if (pag == 1)
            {
                return;
            }
            else
            {
                dgvdados.Rows.Clear();
                dgvMSDN.Rows.Clear();
                pag -= 1;
                lblPag.Text = Convert.ToString(pag);
                carregar();
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvMSDN.Rows.Clear();
            pag = 0;
            lblPag.Text = "0";
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnVoltar5_Click(object sender, EventArgs e)
        {
            if (pag == 0)
            {
                return;
            }
            if(pag < 5)
            {
                dgvdados.Rows.Clear();
                dgvMSDN.Rows.Clear();
                pag = 1;
                lblPag.Text = Convert.ToString(pag);
                carregar();
            }
            else if(pag == 5)
            {
                dgvdados.Rows.Clear();
                dgvMSDN.Rows.Clear();
                pag = 1;
                lblPag.Text = Convert.ToString(pag);
                carregar();
            }
            else
            {
                dgvdados.Rows.Clear();
                dgvMSDN.Rows.Clear();
                pag -= 5;
                lblPag.Text = Convert.ToString(pag);
                carregar();
            }
        }
        private void btnProximo5_Click(object sender, EventArgs e)
        {
            dgvdados.Rows.Clear();
            dgvMSDN.Rows.Clear();
            pag += 5;
            lblPag.Text = Convert.ToString(pag);
            carregar();
        }
        private void btnIrPag_Click_1(object sender, EventArgs e)
        {
            /*abre pagina html*/Process.Start("https://social.msdn.microsoft.com/Forums/pt-br/home?sort=lastpostdesc&brandIgnore=true&page=" + pag);
        }
    }
}
