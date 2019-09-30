using MangaDb.Classes.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaDb
{
    public partial class frmCadastro : Form
    {
        private MangaBo _mangaBo;


        private void obterDados()
        {


        }
     
    public frmCadastro()
        {
            InitializeComponent();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _mangaBo = new MangaBo();
            var manga = obterDados();

            try
            {
                _mangaBo.InserirNovoManga(manga);

            }
            catch
            {

            }
        }
        private void carregardados()
        {
            _mangaBo = new MangaBo();

            

        }
    }
    
