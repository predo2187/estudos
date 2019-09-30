using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manga_data_base
{
    public partial class frmCadastroGenero : Form
    {
        public frmCadastroGenero()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(frmLogin.conexao);
        private string strMysql;
        /*Comando para colocar as Gêneros na ComboBox*/
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
                        cmbGenero.DisplayMember = "Genero";
                        cmbGenero.DataSource = dt;
                    }
                }
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
                //verificando seo gênero já está registrado no banco de dados
                con.Open();
                strMysql = "select Genero from tblGenero where Genero = @Genero;";
                MySqlCommand ver = new MySqlCommand(strMysql, con);
                ver.Parameters.AddWithValue("@Genero", txtNome.Text);
                MySqlDataReader read = ver.ExecuteReader();
                /*Básicamente o read lê a tabela e no "if (read.Read())" ele ve se está lendo
                esse if é para quando já está cadastrada*/
                if (read.Read())
                {
                    MessageBox.Show("Gênero já existe!", "Gênero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    strMysql = "insert into dbMangas.tblGenero (Genero)values(@Genero);";
                    MySqlCommand comando = new MySqlCommand(strMysql, con);
                    comando.Parameters.AddWithValue("@Genero", txtNome.Text);
                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Gênero Cadastrado!", "Gênero", MessageBoxButtons.OK);
                        /*Lembrando que o "con.Close()" deve vir antes do "fimCad()"*/
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
            inserirCmbGenero();
        }
        private void frmCadastroGenero_Load(object sender, EventArgs e)
        {
            inserirCmbGenero();
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
                /*Nesse update o ComboBox selecionado é o @genero, e o TextBox é o @UpdateGenero, assim ele atualiza 
                o genero no banco de dados baseado no antigo nome
                @UpdateGenero é o novo nome do gênero, já o @Genero é o nome antigo*/
                strMysql = "update tblGenero set Genero = @UpdateGenero where Genero = @Genero;";
                MySqlCommand comando = new MySqlCommand(strMysql, con);
                comando.Parameters.AddWithValue("@Genero", cmbGenero.Text);
                comando.Parameters.AddWithValue("@UpdateGenero", txtNome.Text);
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
                    MessageBox.Show("Genêro Editado!", "Genêro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    //O fimCad tem que vir depois do "con.Close()" pois no cmbInserirEditora ele abre conexão
                    fimCad();
                }
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deletar Genêro?", "Genêro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                strMysql = "delete from tblGenero where Genero = @Genero;";
                MySqlCommand comando = new MySqlCommand(strMysql, con);
                comando.Parameters.AddWithValue("@Genero", cmbGenero.Text);
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
                    MessageBox.Show("Genêro Deletado!", "Genêro", MessageBoxButtons.OK);
                    con.Close();
                    fimCad();
                }
            }
            else
            {
                return;
            }
        }
        /*Essa ação é para o texto da ComboBox ser exibido na TextBox*/
        private void cmbGenero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtNome.Text = cmbGenero.Text;
        }
    }
}

