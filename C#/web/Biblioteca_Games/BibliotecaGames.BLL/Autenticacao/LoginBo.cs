﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adicioandos
using BibliotecaGames.DAL;
using BibliotecaGames.Entidades;
using BibliotecaGames.BLL.Exceptions;

namespace BibliotecaGames.BLL.Autenticacao
{
    public class LoginBo
    {
        private UsuarioDao _usuarioDao;
        public Usuario ObterUsuarioParaLogar(string nomeusuario, string senha)
        {
            _usuarioDao = new UsuarioDao();

            var usuario = _usuarioDao.ObterUsuarioPeloUsuarioESenha(nomeusuario, senha);

            if (usuario == null)
            {
                throw new UsuarioNaoCadastradoException();
            }
            else
            {
                return usuario;
            }
            
        }
        
    }
}
