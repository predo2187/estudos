using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manga_data_base
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
    }
        MySqlConnection con = new MySqlConnection("server=localhost;database=dbMangas;uid=root;server=localhost;pwd=");
        string strMysql;
        /*Esse comando manda o nome dos usuários para a ComboBox*/private void selectUser()
        {
            try
            {
                //con.Open();
                using (var comando = new MySqlCommand())
                {
                    comando.Connection = con;
                    comando.CommandText = "select Usuario from tblUsuario";
                    using (MySqlDataReader dr = comando.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        cmbUsuarios.DisplayMember = "Usuario";
                        cmbUsuarios.DataSource = dt;
                    }
                }
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por Pedro Octávio Cruvinel Almeida.\nContato:\noctavioeficaz@gmail.com" +
            "\n(+55) 11 95819-2543", "Desenvolvido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            selectUser();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            selectUser();
        }
        /*essa é váriave que vai para todos os fomrs*/public static int iduser;
        /*Essa é a conexão para todos os os forms*/public static string conexao = "server=localhost;database=dbMangas;uid=root;server=localhost;pwd=";
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
        strMysql = "select * from tblUsuario where Usuario = '"/*Não esquece do " ' " seu idiota*/ + cmbUsuarios.Text + "';";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            try
            {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                if (txtSenha.Text == /*esse seria o comando para adicionar 
                    o valor em uma váriavel ou algo do tipo, porém ele também 
                    pega o valor do banco de dado, então está checagem*/dr["senha"].ToString())
                {
                    /*aqui é para no programa os select usar esse idUser para filtrr os mangás de determinado usuário*/iduser = Convert.ToInt16(dr["idUsuario"]);
                    Hide();
                    frmHome frm = new frmHome();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("A senha senha está incorreta","Usuário",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    txtSenha.Clear();
                    txtSenha.Focus();
                }
            }
            catch (Exception erro){
                MessageBox.Show("Ocorreu um erro:\n" /*aqui tem que ser " + "*/+ erro);
            }
            finally
            {
                con.Close();
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.Show();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
