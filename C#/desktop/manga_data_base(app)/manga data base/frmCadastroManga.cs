using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manga_data_base
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(frmLogin.conexao);
        private string strMysql;
        private void gravarManga()
        {
            string estatus;
            if (radSim.Checked == true)
            {
                estatus = "sim";
            }
            else
            {
                estatus = "não";
            }
            strMysql = "insert into dbMangas.manga (nomeManga,volumes,preco,paginas,Mangaka,Genero1,Genero2,editora,sobre,nome2,estatus,idUsuario,imagem) " +
                                           "values (@nomeManga,@volumes,@preco,@paginas,@Mangaka,@Genero1,@Genero2,@editora,@sobre,@nome2,'" + estatus + "'," + frmLogin.iduser + ",@imagem);";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            /*Aqui está adicioando parametros para o texto que terá no "comando"*/
            comando.Parameters.AddWithValue("@nomeManga", txtNome.Text);
            comando.Parameters.AddWithValue("@volumes", Convert.ToInt16(numVolume.Text));
            comando.Parameters.AddWithValue("@preco", Convert.ToDouble(txtPreco.Text));
            comando.Parameters.AddWithValue("@paginas", Convert.ToInt16(numPagina.Text));
            comando.Parameters.AddWithValue("@Mangaka", cmbMangaka.Text);
            comando.Parameters.AddWithValue("@Genero1", cmbGenero1.Text);
            comando.Parameters.AddWithValue("@Genero2", cmbGenero2.Text);
            comando.Parameters.AddWithValue("@editora", cmbEditora.Text);
            comando.Parameters.AddWithValue("@nome2", txtNome2.Text);
            comando.Parameters.AddWithValue("@sobre", txtSobre.Text);
            comando.Parameters.AddWithValue("@imagem", txtLocalização.Text);
            try
            {
                con.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Mangá Adicionado com sucesso!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fimCad();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro:\n" + erro);
            }
            finally
            {
                con.Close();
            }
        }
        private void fimCad()
        {
            txtNome.Clear();
            txtNome2.Clear();
            numVolume.Value = 1;
            numPagina.Value = 1;
            txtPreco.Clear();
            cmbEditora.Text = null;
            cmbGenero1.Text = null;
            cmbGenero2.Text = null;
            cmbMangaka.Text = null;
            txtSobre.Clear();
            txtLocalização.Clear();
            picManga.Image = null;
            ofdLogo.FileName = "";
        }
        private void inserirCmbMangaka()
        {
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "select Mangaka from tblMangaka";
            MySqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbMangaka.DisplayMember = "Mangaka";
            /*Isso define a ordem na qual é exibida*/
            cmbMangaka.ValueMember = "idMangaka";
            cmbMangaka.DataSource = dt;
            con.Close();
        }
        /*Insere os Generos nas duas ComboBox*/
        private void inserirCmbGenero()
        {
            try
            {
                con.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = con;
                    comando.CommandText = "select Genero from tblGenero";
                    using (MySqlDataReader dr = comando.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        //Insere na cmbGenero1
                        cmbGenero1.DisplayMember = "Genero";
                        cmbGenero2.ValueMember = "idGenero";
                        cmbGenero1.DataSource = dt;
                        //tem que criar um novo bindingContex
                        cmbGenero2.BindingContext = new BindingContext();
                        cmbGenero2.DisplayMember = "Genero";
                        cmbGenero2.ValueMember = "idGenero";
                        cmbGenero2.DataSource = dt;
                    }
                }
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        private void inserirCmbEditora()
        {
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "select Editora from tblEditora";
            MySqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbEditora.DisplayMember = "Editora";
            cmbEditora.ValueMember = "idEditora";
            cmbEditora.DataSource = dt;
            con.Close();
        }
        /*Esse comando impede o usuário de escrever texto*/
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void btnCadManga_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Tem espaços em branco!", "Mangá", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }
            else
            {
                if (txtPreco.Text == "")
                {
                    MessageBox.Show("Tem espaços em branco!", "Mangá", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPreco.Focus();
                    return;
                }
                else
                {
                    if (txtPreco.Text == "")
                    {
                        MessageBox.Show("Tem espaços em branco!", "Mangá", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPreco.Focus();
                        return;
                    }
                    else
                    {
                        gravarManga();
                    }
                }
            }
        }
        private void btnCadMangaka_Click(object sender, EventArgs e)
        {
            frmCadastroMangaka frm = new frmCadastroMangaka();
            frm.Show();
        }
        private void btnCadGen1_Click(object sender, EventArgs e)
        {
            frmCadastroGenero frm1 = new frmCadastroGenero();
            frm1.Show();
        }
        private void btnCadGen2_Click(object sender, EventArgs e)
        {
            frmCadastroGenero frm1 = new frmCadastroGenero();
            frm1.Show();
        }
        private void frmCadastro_Load(object sender, EventArgs e)
        {
            inserirCmbMangaka();
            inserirCmbGenero();
            inserirCmbEditora();
            radNao.Checked = true;
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            inserirCmbGenero();
            inserirCmbMangaka();
            inserirCmbEditora();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCadGen1_Click_1(object sender, EventArgs e)
        {
            frmCadastroGenero frm = new frmCadastroGenero();
            frm.Show();
        }
        private void btnCadGen2_Click_1(object sender, EventArgs e)
        {
            frmCadastroGenero frm = new frmCadastroGenero();
            frm.Show();
        }
        private void btnCadEditora_Click(object sender, EventArgs e)
        {
            frmCadastroEditora frm = new frmCadastroEditora();
            frm.Show();
        }
        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            inserirCmbGenero();
            inserirCmbMangaka();
            inserirCmbEditora();
        }
        /*Impede o usuário de escrever números onde não deve*/
        private void txtPreco_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            /*Impede caracteres não numéricos*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            /*Permite também as vírgulas*/
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            fimCad();
        }
        private void btnAddImagem_Click(object sender, EventArgs e)
        {
            /*File name é o nome que fica na caixa de pesquisa quando abre a pasta do sistema*/ofdLogo.FileName = "";
            /*Nome da caixa de dialogo*/ofdLogo.Title = "Mangá";
            /*Aqui é o filtro da imagem*/ofdLogo.Filter = "JPEG|*.JPG|PNG|*.png";
            /*Chama a caixa de dialogo*/ofdLogo.ShowDialog();
            txtLocalização.Text = ofdLogo.FileName;
        }
        private void ofdLogo_FileOk(object sender, CancelEventArgs e)
        {
            /*No código a baixo:
             picManga.Image-Imagem da Picture Box da imagem do mangá
             Image.FromFile-O Image é o mesmo Image do "picMnaga.Image", FromFile-Do arqui- Imagem do Arquivo
             odfLogo.FileName-Pegou o resultado da pesquisa*/
            picManga.Image = Image.FromFile(ofdLogo.FileName);
        }
    }
}
