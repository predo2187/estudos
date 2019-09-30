using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adicionados
using System.Data.SqlClient;
using BibliotecaGames.Entidades;//List<Jogo>

namespace BibliotecaGames.DAL
{
    public class JogoDao
    {
        public List<Jogo> ObterTodosOsJogos()
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "select * from jogos;";
                Conexao.Conectar();
                var reader = command.ExecuteReader();
                var jogos = new List<Jogo>();
                while (reader.Read())
                {
                    var jogo = new Jogo();
                    jogo.Id = Convert.ToInt32(reader["id"]);
                    jogo.Titulo = Convert.ToString(reader["titulo"]);
                    jogo.Imagem = Convert.ToString(reader["imagem"]);
                    jogo.DataCompra = reader["dataCompra"] == DBNull.Value ? (DateTime?) null : Convert.ToDateTime(reader["dataCompra"]);
                    jogo.valorPago = reader["valorPago"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["valorPago"]);

                    jogos.Add(jogo);

                }
                return jogos;
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
        /*aqui tem que retornar um valor, se lembre que deu erro na hora de criar*/
        public Jogo ObterJogoPeloId(int id)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "select * from jogos where id = @id;";
                command.Parameters.AddWithValue("@id", id);
                Conexao.Conectar();
                var reader = command.ExecuteReader();

                /*tem que retornar um valor mesmo o jogo não existindo*/Jogo jogo = null;

                while (reader.Read())
                {
                    //se entrou aqui é por que o jogo existe, então no fim ele retorna o jogo

                    jogo = new Jogo();
                    jogo.Id = Convert.ToInt32(reader["id"]);
                    jogo.Titulo = Convert.ToString(reader["titulo"]);
                    jogo.Imagem = Convert.ToString(reader["imagem"]);
                    jogo.DataCompra = reader["dataCompra"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["dataCompra"]);
                    jogo.valorPago = reader["valorPago"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["valorPago"]);
                    jogo.idGenero = Convert.ToInt32(reader["idGenero"]);
                    jogo.idEditor = Convert.ToInt32(reader["idEditora"]);

                    return jogo;

                }
                //se não existe jogo, ele retorna o próprio jogo, que foi delcarado null
                return jogo;
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
        public int InserirJogo(Jogo jogo)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "insert into jogos (titulo, valorPago, dataCompra, imagem, idGenero, idEditora)"
                                                + "values(@titulo, @valorPago, @dataCompra, @imagem, @idGenero, @idEditora);";

                command.Parameters.AddWithValue("@titulo", jogo.Titulo);
                command.Parameters.AddWithValue("@valorPago", jogo.valorPago);
                command.Parameters.AddWithValue("@dataCompra", jogo.DataCompra);
                command.Parameters.AddWithValue("@imagem", jogo.Imagem);
                command.Parameters.AddWithValue("@idGenero", jogo.idGenero);
                command.Parameters.AddWithValue("@idEditora", jogo.idEditor);
                Conexao.Conectar();
                return command.ExecuteNonQuery();

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

        public int AlterarJogo(Jogo jogo)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "update jogos set titulo = @titulo, valorPago = @valorPago, dataCompra = @dataCompra, imagem = @imagem, idGenero = @idGenero, idEditora = @idEditora where id = @id;";

                command.Parameters.AddWithValue("@titulo", jogo.Titulo);
                command.Parameters.AddWithValue("@valorPago", jogo.valorPago);
                command.Parameters.AddWithValue("@dataCompra", jogo.DataCompra);
                command.Parameters.AddWithValue("@imagem", jogo.Imagem);
                command.Parameters.AddWithValue("@idGenero", jogo.idGenero);
                command.Parameters.AddWithValue("@idEditora", jogo.idEditor);
                command.Parameters.AddWithValue("@id", jogo.Id);
                Conexao.Conectar();
                return command.ExecuteNonQuery();

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

