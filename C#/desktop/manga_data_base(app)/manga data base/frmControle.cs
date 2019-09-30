using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manga_data_base
{
    public partial class frmControle : Form
    {
        public frmControle()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(frmLogin.conexao);
        private string strMysql;
        /*Está carregando os dados para o DataGridView*/private void carregarDgv()
        {
            string ordem;
            if (radNome.Checked == true)
            {
                ordem = "nomeManga";
            }
            else if (radVolume.Checked == true)
            {
                ordem = "volumes desc";
            }
            else if (radPreco.Checked == true)
            {
                ordem = "preco desc";
            }
            else
            {
                ordem = "idManga";
            }
            strMysql = "select idManga as Id, nomeManga as Nome, volumes as Volumes, preco as Preço from manga where idUsuario = " /*esse código é para apenas selecionar os manás que contem esse idUser*/+ frmLogin.iduser + " order by "/*preste atenção nessa contatenação que você pode usar para outras coisas*/ + ordem + ";";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            DataTable data = new DataTable();
            try
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(strMysql, con);
                adapter.Fill(data);
                dgvMangas.DataSource = data;
                /*Meio qu einstanciou a coluna do DtaGridView*/
                DataGridViewColumn colunaId = dgvMangas.Columns[0];
                /*Agora dá para definir coisas para a "instancia"*/
                colunaId.Width = 55;
                DataGridViewColumn colunaVolume = dgvMangas.Columns[2];
                DataGridViewColumn colunaPreco = dgvMangas.Columns[3];
                colunaVolume.Width = 55;
                colunaPreco.Width = 55;
                /*Impede do usuário selecionar mais de uma coluna*/
                dgvMangas.MultiSelect = false;
                /*Faz com que selecione uma coluna inteira em vez de um pedaço*/
                dgvMangas.SelectionMode = DataGridViewSelectionMode./*especificamente é isso*/FullRowSelect;
                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro:\n" + erro);
            }
        }
        private void frmAdicionar_Load(object sender, EventArgs e)
        {
            carregarDgv();
            //Fiz os comandos a baixo pois as colunas estavam iniciando muito largas, que estão também no "inserirDgv"
            DataGridViewColumn colunaId = dgvMangas.Columns[0];
            colunaId.Width = 55;
            DataGridViewColumn colunaVolume = dgvMangas.Columns[2];
            DataGridViewColumn colunaPreco = dgvMangas.Columns[3];
            colunaVolume.Width = 55;
            colunaPreco.Width = 55;
        }
        private void btndicionar_Click(object sender, EventArgs e) {
            if (txtId.Value == 0)
            {
                MessageBox.Show("Tem espaços em branco, preencha-os!","Espaços vazius",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                //Nesse strMySql em vex de colocar "addParameter" fiz a contatenação
                strMysql = "update manga set volumes = volumes + " + numVolumes.Value + " where idManga = " + txtId.Value + ";";
                MySqlCommand comando = new MySqlCommand(strMysql, con);
                try
                {
                    con.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Volumes adicionados com sucesso", "Volumes", MessageBoxButtons.OK);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro:\n" + erro);
                }
                finally
                {
                    con.Close();
                    fimCad();
                }
            }   
        }
        /*Essa ação é para otimizar o código*/private void fimCad()
        {
            txtNome.Clear();
            numVolumes.Value = 1;
            txtId.Value = 1;
            numAtual.Value = 1;
            carregarDgv();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Value == 0)
            {
                MessageBox.Show("Tem espaços em branco, preencha-os!", "Espaços vazius", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                strMysql = "update manga set volumes = volumes - " + numVolumes.Value + " where idManga = " + txtId.Value + ";";
                MySqlCommand comando = new MySqlCommand(strMysql, con);
                try
                {
                    con.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Volumes removidos com sucesso", "Controle", MessageBoxButtons.OK);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu um erro:\n" + erro);
                }
                finally
                {
                    con.Close();
                    fimCad();
                }
            }
        }
        private void dgvMangas_SelectionChanged(object sender, EventArgs e)
        {
            refresh();
        }
        private void btnRefreshOrdem_Click(object sender, EventArgs e)
        {
            carregarDgv();
        }
        private void refresh()
        {
            //está mandando o id para 
            strMysql = "select * from manga where idManga = " + dgvMangas.CurrentRow.Cells[0].Value.ToString() + ";";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            try
            {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                /*Aqui checa se tem a id na tabela, se não tiver vai dar a menssagem de erro*/
                if (!dr.HasRows)
                {
                    MessageBox.Show("Mangá não encontrado!", "Controle", MessageBoxButtons.OK);
                    txtId.Value = 0;
                    txtId.Focus();
                }
                else
                {
                    txtId.Text = dr["idManga"].ToString();
                    txtNome.Text = dr["nomeManga"].ToString();
                    numAtual.Text = dr["volumes"].ToString();
                    picManga.Image = Image.FromFile(dr["imagem"].ToString());
                }
            }
            catch //(Exception erro)
            {
                //Fica aparecendo sempre o erro de que a conexão já foi aberta MessageBox.Show("Ocorreu um erro:\n" + erro);
            }
            finally
            {
                con.Close();
            }
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            strMysql = "select * from manga where idManga = " + txtId.Text + ";";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            try
            {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                /*Aqui checa se tem a id na tabela, se não tiver vai dar a menssagem de erro*/
                if (!dr.HasRows)
                {
                    MessageBox.Show("Mangá não encontrado!", "Controle", MessageBoxButtons.OK);
                    txtId.Value = 0;
                    txtId.Focus();
                }
                else
                {
                    /*Aqui simplesmente pegou um valor e o colocou na TextBox*/
                    txtNome.Text = dr["nomeManga"].ToString();
                    numAtual.Text = dr["volumes"].ToString();
                    picManga.Image = Image.FromFile(dr["imagem"].ToString());
                }
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
    }
}

