using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adicionados
using MangaDb.Classes.DAL;
using MangaDb.Classes.Entidades;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MangaDb.Classes.BLL
{
    public class MangaBo
    {
        private MangaDao _mangaDao;
        public void InserirNovoManga(MangaEntidades manga)
        {
            _mangaDao = new MangaDao();
            var linhasAfetadas = _mangaDao.InserirManga(manga);
        }

    }
}
