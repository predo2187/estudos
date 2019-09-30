using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adicionados
using BibliotecaGames.Entidades;//list<Jogo>
using System.Data.SqlClient;//conexao

namespace BibliotecaGames.DAL
{
    public class GeneroDao
    {
        public List<Genero> ObterTodosOsGeneros()
        {
            try
            {
                
                var command = new SqlCommand();
                command.Connection = Conexao.connection; 
                command.CommandText = "select * from genero order by nome;";

                Conexao.Conectar();
                var reader = command.ExecuteReader();

                var generos = new List<Genero>();

                while (reader.Read())
                {
                    var genero = new Genero();

                    genero.Id = Convert.ToInt32(reader["id"]);
                    genero.Nome = reader["nome"].ToString();

                    generos.Add(genero);

                }
                /*não esqueça de atualizar as "public list <...>" pois ficou dando erro e vcoê ficou 10 minutos para resolver*/
                return generos;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
