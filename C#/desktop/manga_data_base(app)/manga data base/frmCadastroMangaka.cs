using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manga_data_base
{
    public partial class frmCadastroMangaka : Form
    {
        public frmCadastroMangaka()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(frmLogin.conexao);
        private string strMysql;
        /*Comando para colocar os Mangakas na ComboBox*/
        private void inserirCmbMangaka()
        {
            try
            {
                con.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = con;
                    comando.CommandText = "select Mangaka from tblMangaka";
                    using (MySqlDataReader dr = comando.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        cmbMangaka.DisplayMember = "Mangaka";
                        cmbMangaka.DataSource = dt;
                    }
                }
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void frmCadastroMangaka_Load(object sender, EventArgs e)
        {
            inserirCmbMangaka();
        }
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Tem espaços em branco!", "Espaços vazius", MessageBoxButtons.OK);
                return;
            }
            else
            {
                //verificando seo Mangaka já está registrado no banco de dados
                con.Open();
                strMysql = "select Mangaka from tblMangaka where Mangaka = @Mangaka;";
                MySqlCommand ver = new MySqlCommand(strMysql, con);
                ver.Parameters.AddWithValue("@Mangaka", txtNome.Text);
                MySqlDataReader read = ver.ExecuteReader();
                /*Básicamente o read lê a tabela e no "if (read.Read())" ele ve se está lendo
                esse if é para quando já está cadastrada*/
                if (read.Read())
                {
                    MessageBox.Show("Mangáka já existe!", "Mangáka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                    con.Close();
                    return;
                }
                /*aqui já é o cadastro*/
                else
                {
                    /*Esse fechamento de conexão está aqui para fechar a conexão da checagem à cima, pois tem uma 
                    condição que foi o "if"*/
                    con.Close();
                    con.Open();
                    strMysql = "insert into dbMangas.tblMangaka (Mangaka)values(@Mangaka);";
                    MySqlCommand comando = new MySqlCommand(strMysql, con);
                    comando.Parameters.AddWithValue("@Mangaka", txtNome.Text);
                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Mangáka Cadastrado!", "Mangáka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        con.Close();
                        /*aqui é para simplificar a finalização da ação*/
                        fimCad();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Ocorreu um erro:\n" + erro);
                        con.Close();
                    }
                }
            }
        }
        /*Essa ação é par simplificar o código*/
        private void fimCad()
        {
            txtNome.Clear();
            txtNome.Focus();
            inserirCmbMangaka();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Tem espaços em branco!", "Espaços vazius", MessageBoxButtons.OK);
                return;
            }
            else
            {
                /*Nesse update o ComboBox selecionado é o @Mangaka, e o TextBox é o @UpdateMangaka, assim ele atualiza 
                a editora no banco de dados baseado no antigo nome
                @UpdateMangaka é o novo nome do Mangaka, já o @Mangaka é o nome antigo*/
                strMysql = "update tblMangaka set Mangaka = @UpdateMangaka where Mangaka = @Mangaka;";
                MySqlCommand comando = new MySqlCommand(strMysql, con);
                comando.Parameters.AddWithValue("@Mangaka", cmbMangaka.Text);
                comando.Parameters.AddWithValue("@UpdateMangaka", txtNome.Text);
                try
                {
                    con.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro:\n" + erro);
                }
                finally
                {
                    MessageBox.Show("Mangáka Editado!", "Mangáka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    //O fimCad tem que vir depois do "con.Close()" pois no cmbInserirEditora ele abre conexãofimCad();
                }
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deletar Mangáka?", "Mangáka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                strMysql = "delete from tblMangaka where Mangaka = @Mangaka;";
                MySqlCommand comando = new MySqlCommand(strMysql, con);
                comando.Parameters.AddWithValue("@Mangaka", cmbMangaka.Text);
                try
                {
                    con.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro:\n" + erro);
                }
                finally
                {
                    MessageBox.Show("Mangáka Deletado!", "Mangáka", MessageBoxButtons.OK);
                    con.Close();
                    fimCad();
                    txtNome.Clear();
                }
            }
            else
            {
                return;
            }
        }
        /*Essa ação é para o texto da ComboBox ser exibido na TextBox*/ private void cmbMangaka_SelectionChangeCommitted(object sender, EventArgs e)
        {
                txtNome.Text = cmbMangaka.Text;
        }
    }
}

