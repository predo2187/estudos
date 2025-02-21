﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adicionados
using BibliotecaGames.DAL;//JogoDao _jogosDao
using BibliotecaGames.Entidades;//List<Jogo>
using BibliotecaGames.BLL.Exceptions;

namespace BibliotecaGames.BLL
{
    public class JogosBo
    {
        private JogoDao _jogoDao;
        public List<Jogo> ObterTodosOsJogos()
        {
            _jogoDao = new JogoDao();
            return _jogoDao.ObterTodosOsJogos();
        }

        public Jogo ObterJogoPeloId(int id)
        {
            _jogoDao = new JogoDao();
            var jogo = _jogoDao.ObterJogoPeloId(id);

            if(jogo == null)
            {
                throw new JogoNaoEncontradoException();
            }else
            {
                return jogo;
            }
        }

        public void InserirNovoJogo(Jogo jogo)
        {
            _jogoDao = new JogoDao();
            ValidarJogo(jogo);

            var linhasAfetadas = _jogoDao.InserirJogo(jogo);

            if(linhasAfetadas == 0)
            {
                throw new JogoNaoCadastradoException();

            }
        }
       
        public void AlterarJogo(Jogo jogo)
        {
            _jogoDao = new JogoDao();
            ValidarJogo(jogo);

            var linhasAfetadas = _jogoDao.AlterarJogo(jogo);

            if (linhasAfetadas == 0)
            {
                throw new JogoNaoAlteradoExcpetion();

            }
        }
        public void ValidarJogo(Jogo jogo)
        {
            if (string.IsNullOrWhiteSpace(jogo.Titulo) || jogo.idEditor == 0 || jogo.idGenero == 0)
            {
                throw new JogoInvalidoException();

            }

        }
    }
}
