using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manga_data_base
{
    public partial class frmCadastroEditora : Form
    {
        public frmCadastroEditora()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(frmLogin.conexao);
        private string strMysql;
        /*Comando para colocar as editoras na ComboBox*/private void inserirCmbEditora()
        {
            try
            {
                con.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = con;
                    comando.CommandText = "select Editora from tblEditora";
                    using (MySqlDataReader dr = comando.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        cmbEditora.DisplayMember = "Editora";
                        cmbEditora.DataSource = dt;
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
                MessageBox.Show("Tem espaços em branco!", "Espaços vazius", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                //verificando se a editora já está registrada no banco de dados
                con.Open();
                strMysql = "select Editora from tblEditora where Editora = @Editora;";
                MySqlCommand ver = new MySqlCommand(strMysql, con);
                ver.Parameters.AddWithValue("@Editora", txtNome.Text);
                MySqlDataReader read = ver.ExecuteReader();
                /*Básicamente o read lê a tabela e no "if (read.Read())" ele ve se está lendo
                esse if é para quando já está cadastrada*/if (read.Read())
                {
                    MessageBox.Show("Editora já existe!", "Editora", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                    con.Close();
                    return;
                }
                /*aqui já é o cadastro*/else
                {
                    /*Esse fechamento de conexão está aqui para fechar a conexão da checagem à cima, pois tem uma 
                    condição que foi o "if"*/con.Close();
                    con.Open();
                    strMysql = "insert into dbMangas.tblEditora (Editora)values(@Editora);";
                    MySqlCommand comando = new MySqlCommand(strMysql, con);
                    comando.Parameters.AddWithValue("@Editora", txtNome.Text);
                    try
                    {
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Editora Cadastrada!", "Editora", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                        
                        con.Close();
                        /*aqui é para simplificar a finalização da ação*/fimCad();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Ocorreu um erro:\n" + erro);
                        con.Close();
                    }
                }
            }
        }
        /*Essa ação é par simplificar o código*/private void fimCad()
        {
            txtNome.Clear();
            txtNome.Focus();
            inserirCmbEditora();
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void frmCadastroEditora_Load_1(object sender, EventArgs e)
        {
            inserirCmbEditora();
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Tem espaços em branco!", "Espaços vazius", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                /*Nesse update o ComboBox selecionado é o @Editora, e o TextBox é o @UpdateEditora, assim ele atualiza 
                a editora no banco de dados baseado no antigo nome
                @UpdateEditora é o novo nome da editora, já o @Editora é o nome antigo*/
                strMysql = "update tblEditora set Editora = @UpdateEditora where Editora = @Editora;";
                MySqlCommand comando = new MySqlCommand(strMysql, con);
                comando.Parameters.AddWithValue("@Editora", cmbEditora.Text);
                comando.Parameters.AddWithValue("@UpdateEditora", txtNome.Text);
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
                    MessageBox.Show("Editora Editada!", "Editora", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);                  
                    con.Close();
                    //O fimCad tem que vir depois do "con.Close()" pois no cmbInserirEditora ele abre conexão
                    fimCad();
                }
            }
        }
        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deletar Editora?", "Editora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                strMysql = "delete from tblEditora where Editora = @Editora;";
                MySqlCommand comando = new MySqlCommand(strMysql, con);
                comando.Parameters.AddWithValue("@Editora", cmbEditora.Text);
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
                    MessageBox.Show("Editora Deletada!", "Editora", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        /*Essa ação é para o texto da ComboBox ser exibido na TextBox*/private void cmbEditora_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtNome.Text = cmbEditora.Text;
        }
    }
} 
