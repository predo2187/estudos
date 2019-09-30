using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace manga_data_base
{
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(frmLogin.conexao);
        private string strMysql;
        /*Carregar dados para o DataGridView/Definições do DGV*/private void inserirDgv()
        {
            string ordem;
            if (radNome.Checked == true)
            {
                ordem = "nomeManga";
            }
            else if(radVolume.Checked == true)
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
            strMysql = "select idManga as Id, nomeManga as Nome, volumes as Volumes, preco as Preço from manga where idUsuario = " + frmLogin.iduser + " order by "/*preste atenção nessa contatenação que você pode usar para outras coisas*/ + ordem + ";";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            DataTable data = new DataTable();
            try
            {
                /*Ainda não sei o motivo de não abrir a conexão aqui con.Open();*/
                MySqlDataAdapter adapter = new MySqlDataAdapter(strMysql, con);
                adapter.Fill(data);
                dgvMangas.DataSource = data;
                /*Meio qu einstanciou a coluna do DtaGridView*/DataGridViewColumn colunaId = dgvMangas.Columns[0];
                /*Agora dá para definir coisas para a "instancia"*/colunaId.Width = 55;
                DataGridViewColumn colunaVolume = dgvMangas.Columns[2];
                DataGridViewColumn colunaPreco = dgvMangas.Columns[3];
                colunaVolume.Width = 55;
                colunaPreco.Width = 55;
                /*Impede do usuário selecionar mais de uma coluna*/dgvMangas.MultiSelect = false;
                /*Faz com que selecione uma coluna inteira em vez de um pedaço*/dgvMangas.SelectionMode = DataGridViewSelectionMode./*especificamente é isso*/FullRowSelect;
                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro:\n" + erro);
            }
        }
        private void limpar()
        {
            txtNome.Clear();
            txtNome2.Clear();
            cmbEditora.Text = null;
            cmbGenero1.Text = null;
            cmbGenero2.Text = null;
            cmbMangaka.Text = null;
            numPaginas.Value = 1;
            numVolumes.Value = 1;
            txtTotal.Clear();
            txtPreco.Clear();
            txtSobre.Clear();
            picManga.Image = null;
            txtLocalização.Clear();
        }
        private void frmLista_Load(object sender, EventArgs e)
        {
            inserirDgv();
            //Fiz os comandos a baixo pois as colunas estavam iniciando muito largas, que estão também no "inserirDgv"
            DataGridViewColumn colunaId = dgvMangas.Columns[0];
            colunaId.Width = 55;
            DataGridViewColumn colunaVolume = dgvMangas.Columns[2];
            DataGridViewColumn colunaPreco = dgvMangas.Columns[3];
            colunaVolume.Width = 55;
            colunaPreco.Width = 55;
        }
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
                        cmbGenero1.DisplayMember = "Genero";
                        cmbGenero2.ValueMember = "idGenero";
                        cmbGenero1.DataSource = dt;
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
        private void inserirCmbMangaka()
        {
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = con;
            comando.CommandText = "select Mangaka from tblMangaka;";
            MySqlDataReader dr = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbMangaka.DisplayMember = "Mangaka";
            cmbMangaka.ValueMember = "idMangaka";
            cmbMangaka.DataSource = dt;
            con.Close();
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            inserirCmbGenero();
            inserirCmbMangaka();
            inserirCmbEditora();
            strMysql = "select * from manga where idManga = " + txtId.Text + ";";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            try
            {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Mangá não encontrado", "Mangá", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    con.Close();
                    limpar();
                    txtId.Focus();
                    return;
                }
                else
                {
                    txtNome.Text = dr["nomeManga"].ToString();
                    cmbMangaka.Text = dr["Mangaka"].ToString();
                    cmbGenero1.Text = dr["Genero1"].ToString();
                    cmbGenero2.Text = dr["Genero2"].ToString();
                    cmbEditora.Text = dr["editora"].ToString();
                    txtPreco.Text = dr["preco"].ToString();
                    txtNome2.Text = dr["nome2"].ToString();
                    txtNome2.Text = dr["nome2"].ToString();
                    txtSobre.Text = dr["sobre"].ToString();
                    txtLocalização.Text = dr["imagem"].ToString();
                    /*a imagem não estava sendo trocada, além disso dava erro, então ela esta sendo carregada
                      a partir do txtLocalização, porém ela não se atualiza então tem a estrutura de decisão para
                      remover a imagem caso o mangá não tenha*/if (txtLocalização.Text == "")
                    {
                        picManga.Image = null;
                    }
                    else
                    {
                        picManga.Image = Image.FromFile(txtLocalização.Text);
                    }
                    numPaginas.Value = Convert.ToInt16(dr["paginas"].ToString());
                    numVolumes.Value = Convert.ToInt16(dr["volumes"].ToString());
                    /*Aqui começa o cálculo do valor total da coleção*/
                    Double volume = Convert.ToDouble(numVolumes.Value);
                    Double preco = Convert.ToDouble(txtPreco.Text);
                    txtTotal.Text = (volume * preco).ToString();
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*Aqui está definindo os RadioButtons de sim e não da coleção completa*/string estatus;
            /*Não esqueça dos 2 "==" seu idiota*/if (radSim.Checked == true)
            {
                 estatus = "sim";
            }
            else
            {
                 estatus = "não";
            }
            strMysql = "update manga set idManga = @idManga, nomeManga = @nomeManga,volumes = @volumes,preco = @preco,paginas = @paginas,Mangaka = @Mangaka,Genero1 = @Genero1,Genero2 = @Genero2, nome2 = @nome2, editora = @editora, sobre = @sobre, estatus = '"/*não esqueça do " ' " quando não for váriavel seu idiota*/ + estatus + "', imagem = @imagem where idManga = " + txtId.Value + ";";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            try
            {
                con.Open();
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idManga", txtId.Value);
                comando.Parameters.AddWithValue("@nomeManga", txtNome.Text);
                comando.Parameters.AddWithValue("@sobre", txtSobre.Text);
                comando.Parameters.AddWithValue("@Mangaka", cmbMangaka.Text);
                comando.Parameters.AddWithValue("@Genero1", cmbGenero1.Text);
                comando.Parameters.AddWithValue("@Genero2", cmbGenero2.Text);
                comando.Parameters.AddWithValue("@editora", cmbEditora.Text);
                comando.Parameters.AddWithValue("@paginas", numPaginas.Value);
                comando.Parameters.AddWithValue("@volumes", numVolumes.Value);
                comando.Parameters.AddWithValue("@preco", Convert.ToDouble(txtPreco.Text));
                comando.Parameters.AddWithValue("@nome2", txtNome2.Text);
                comando.Parameters.AddWithValue("@imagem", txtLocalização.Text);
                comando.ExecuteNonQuery();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro:\n" + erro);
            }
            finally
            {
                Double volume = Convert.ToDouble(numVolumes.Value);
                Double preco = Convert.ToDouble(txtPreco.Text);
                txtTotal.Text = (volume * preco).ToString();
                MessageBox.Show(txtNome.Text + " editado com sucesso!", "Mangá", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();
                inserirDgv();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //Esse comndo vai gerar uma MessageBox que da a opção de sim e não
            DialogResult dialogResult = MessageBox.Show("Deletar Mangá?", "Mangá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            /*Aqui é quando o comando sim for selecionado*/if (dialogResult == DialogResult.Yes)
            {
                strMysql = "delete from manga where idManga = " + txtId.Value + ";";
                MySqlCommand comando = new MySqlCommand(strMysql, con);
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
                    MessageBox.Show("Mangá excluído com sucesso!","Mangá",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    con.Close();
                    limpar();
                    inserirDgv(); 
                }
            }
            else
            {
                return;
            }
        }
        private void btnaddMangaka_Click(object sender, EventArgs e)
        {
            frmCadastroMangaka frm = new frmCadastroMangaka();
            frm.Show();
        }
        private void btnAddGenero_Click(object sender, EventArgs e)
        {
            frmCadastroGenero frm = new frmCadastroGenero();
            frm.Show();
        }
        private void btnAddGenero2_Click(object sender, EventArgs e)
        {
            frmCadastroGenero frm = new frmCadastroGenero();
            frm.Show();
        }
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
        private void dgvMangas_SelectionChanged(object sender, EventArgs e)
        {
            //Esse comando mando manda a id selecionada do DataGridView para o TextBox
            //txtId.Text = dgvMangas.CurrentRow.Cells[0].Value.ToString();
            inserirCmbGenero();
            inserirCmbMangaka();
            inserirCmbEditora();
            strMysql = "select * from manga where idManga = " + dgvMangas.CurrentRow.Cells[0].Value.ToString() + ";";
            MySqlCommand comando = new MySqlCommand(strMysql, con);
            try
            {
                con.Open();
                MySqlDataReader dr = comando.ExecuteReader();
                dr.Read();
                if (!dr.HasRows)
                {
                    //Comentado pois vi dar menssagem sempre que excluír algo MessageBox.Show("Mangá não encontrado", "Mangá", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    limpar();
                    txtId.Focus();
                    return;
                }
                else
                {
                    txtId.Text = dr["idManga"].ToString();
                    txtNome.Text = dr["nomeManga"].ToString();
                    cmbMangaka.Text = dr["Mangaka"].ToString();
                    cmbGenero1.Text = dr["Genero1"].ToString();
                    cmbGenero2.Text = dr["Genero2"].ToString();
                    cmbEditora.Text = dr["editora"].ToString();
                    txtPreco.Text = dr["preco"].ToString();
                    txtNome2.Text = dr["nome2"].ToString();
                    txtNome2.Text = dr["nome2"].ToString();
                    txtSobre.Text = dr["sobre"].ToString();
                    /*aqui pegou a localização*/txtLocalização.Text = dr["imagem"].ToString();
                    /*a imagem não estava sendo trocada, além disso dava erro, então ela esta sendo carregada
                      a partir do txtLocalização, porém ela não se atualiza então tem a estrutura de decisão para
                      remover a imagem caso o mangá não tenha*/if(txtLocalização.Text == "")
                    {
                        picManga.Image = null;
                    }
                    else
                    {
                        picManga.Image = Image.FromFile(txtLocalização.Text);
                    }
                    numPaginas.Value = Convert.ToInt16(dr["paginas"].ToString());
                    numVolumes.Value = Convert.ToInt16(dr["volumes"].ToString());
                    string estatus = dr["estatus"].ToString();
                    if(estatus == "sim")
                    {
                        radSim.Checked = true;
                    }
                    else
                    {
                        radNao.Checked = true;
                    }
                    /*Aqui começa o cálculo do valor total da coleção*/
                    Double volume = Convert.ToDouble(numVolumes.Value);
                    Double preco = Convert.ToDouble(txtPreco.Text);
                    txtTotal.Text = (volume * preco).ToString();
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
        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastroEditora frm = new frmCadastroEditora();
            frm.Show();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void btnRefreshOrdem_Click(object sender, EventArgs e)
        {
            inserirDgv();
        }
        private void ofdLogo_FileOk(object sender, CancelEventArgs e)
        {
            picManga.Image = Image.FromFile(ofdLogo.FileName);
        }
        private void btnImagem_Click(object sender, EventArgs e)
        {
            /*File name é o nome que fica na caixa de pesquisa quando abre a pasta do sistema*/
            ofdLogo.FileName = "";
            /*Nome da caixa de dialogo*/
            ofdLogo.Title = "Mangá";
            /*Aqui é o filtro da imagem*/
            ofdLogo.Filter = "JPEG|*.JPG|PNG|*.png";
            /*Chama a caixa de dialogo*/
            ofdLogo.ShowDialog();
            txtLocalização.Text = ofdLogo.FileName;
        }
    }
}
