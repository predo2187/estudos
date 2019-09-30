using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adicionados
using BibliotecaGames.DAL;
using BibliotecaGames.Entidades;
namespace BibliotecaGames.BLL
{
    public class EditoraBo
    {
        private EditorDao _editorDao;
        public List<Editor> ObterTodasAsEditoras()
        {
            _editorDao = new EditorDao();
            return _editorDao.ObterTodasAsEditoras();
        }
    }
}
