using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.BLL
{
    //criamos uma excessão personalizada, agora a exception será "UsuarioNaoCadastradoException", ele é visto por enquanto no "LoginBo"
    public class UsuarioNaoCadastradoException:Exception
    {
        public UsuarioNaoCadastradoException()
        {
        }

        public UsuarioNaoCadastradoException(string message)
        : base(message)
    {
        }

        public UsuarioNaoCadastradoException(string message, Exception inner)
        : base(message, inner)
    {
        }
    }
}
