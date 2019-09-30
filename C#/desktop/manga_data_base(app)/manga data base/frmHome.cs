using System;
using System.Windows.Forms;

namespace manga_data_base
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastro frm = new frmCadastro();
            frm.Show();
        }
        private void btnLista_Click(object sender, EventArgs e)
        {
            frmLista frm = new frmLista();
            frm.Show();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmControle frm = new frmControle();
            frm.Show();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnColecao_Click(object sender, EventArgs e)
        {
            frmTotal frm = new frmTotal();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(frmLogin.iduser));
        }
    }
}
