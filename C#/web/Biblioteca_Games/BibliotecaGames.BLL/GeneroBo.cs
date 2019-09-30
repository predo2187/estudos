using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adicioandos
using BibliotecaGames.DAL;
using BibliotecaGames.Entidades;
namespace BibliotecaGames.BLL.Autenticacao
{
    public class GeneroBo
    {
        private GeneroDao _generoDao;
        public List<Genero> ObterTodosOsGeneros()
        {
            _generoDao = new GeneroDao();
            return _generoDao.ObterTodosOsGeneros();
        }
    }
}
