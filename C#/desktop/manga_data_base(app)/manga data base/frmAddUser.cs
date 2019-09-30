using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manga_data_base
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(frmLogin.conexao);
        private string strMysql;
        private void limpar()
        {
            txtNome.Clear();
            txtSenha.Clear();
            txtNome.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Tem espaços em branco!", "Espaços vazius", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Tem espaços em branco!", "Espaços vazius", MessageBoxButtons.OK);
                    return;
                }
                //verificando se o Mangaka já está registrado no banco de dados
                con.Open();
                strMysql = "select Usuario from tblUsuario where Usuario = @Usuario;";
                MySqlCommand ver = new MySqlCommand(strMysql, con);
                /*não tem como contatenar o txtNome, precisa do ver*/ver.Parameters.AddWithValue("@Usuario", txtNome.Text);
                MySqlDataReader read = ver.ExecuteReader();
                /*Básicamente o read lê a tabela e no "if (read.Read())" ele ve se está lendo
                esse if é para quando já está cadastrada
                báicamente ele vê se o red está lendo*/
                if (read.Read())
                {
                    MessageBox.Show("Usuário já existe!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    strMysql = "insert into dbMangas.tblUsuario (Usuario,senha)values('" + txtNome.Text + "','" + txtSenha.Text + "');";
                    MySqlCommand comando = new MySqlCommand(strMysql, con);
                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuário Cadastrado!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        con.Close();
                        /*aqui é para simplificar a finalização da ação*/
                        limpar();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Ocorreu um erro:\n" + erro);
                        con.Close();
                    }
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

