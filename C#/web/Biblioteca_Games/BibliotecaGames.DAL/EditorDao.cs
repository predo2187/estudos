using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adicioandos
using BibliotecaGames.Entidades;

namespace BibliotecaGames.DAL
{
    public class EditorDao
    {
        public List<Editor> ObterTodasAsEditoras()
        {
            try
            {
                using (var connection = new SqlConnection(Conexao.connectionString))
                {
                    connection.Open();

                    var command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = $"select * from editor order by nome;";

                    
                    var reader = command.ExecuteReader();

                    var editoras = new List<Editor>();

                    while (reader.Read())
                    {
                        var editor = new Editor();

                        editor.Id = Convert.ToInt32(reader["id"]);
                        editor.Nome = reader["nome"].ToString();

                        editoras.Add(editor);

                    }
                    /*não esqueça de atualizar as "public list <...>" pois ficou dando erro e vcoê ficou 10 minutos para resolver*/
                    return editoras;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
           
        }
    }
}
