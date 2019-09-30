using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manga_data_base
{
    public partial class frmTotal : Form
    {
        public frmTotal()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(frmLogin.conexao);
        private string strMysql;
        private void frmTotal_Load(object sender, EventArgs e)
        {
            obras();
            mangas();
            valor();
            completo();
        }
        private void obras()
        {
            strMysql = "select sum(volumes * 0 + 1) as total from manga where idUsuario = " + /*se não dar "where" para o idUsuario atual, vai calcular tudo até os mangás que não são desse usuário*/frmLogin.iduser + ";";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            try
            {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                /*O "total" se refere a parte " as total" do comando MySql, pois ele é quem pegou o valor das obras*/
                txtObras.Text = dr["total"].ToString();
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
        private void mangas()
        {
            strMysql = "select sum(volumes) as total from manga where idUsuario = " + frmLogin.iduser + ";";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            try
            {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                /*O "total" se refere a parte " as total" do comando MySql, pois ele é quem pegou o valor das obras*/
                txtMangas.Text = dr["total"].ToString();
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
        private void valor()
        {
            strMysql = "select sum(volumes * preco) as total from manga where idUsuario = " + frmLogin.iduser + ";";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            try
            {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                /*O "total" se refere a parte " as total" do comando MySql, pois ele é quem pegou o valor das obras*/
                txtValorTotal.Text = dr["total"].ToString();
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
        private void completo()
        {
            strMysql = "select sum(estatus = 'sim') as total from manga where idUsuario = " + frmLogin.iduser + ";";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            try
            {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                /*O "total" se refere a parte " as total" do comando MySql, pois ele é quem pegou o valor das obras*/
                txtCompleto.Text = dr["total"].ToString();
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
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
