using MangaDb.Classes.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaDb.Classes.DAL
{
    public class MangaDao
    {
        public int InserirManga(MangaEntidades manga)
        {
            try
            {
                var comando = new MySqlCommand();
                comando.Connection = Conexao.connection;
                comando.CommandText = "";

                comando.Parameters.AddWithValue("@titulo", manga.cancelado);
                
                Conexao.Conectar();
                return comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o mangá:\n"+erro);
                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }



    }
}
