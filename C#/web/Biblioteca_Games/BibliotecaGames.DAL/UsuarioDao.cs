using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*deve usar pegar pegar as coisas dessa biblioteca*/using BibliotecaGames.Entidades;
using System.Data.SqlClient;
namespace BibliotecaGames.DAL
{
    public class UsuarioDao
    {
        public Usuario ObterUsuarioPeloUsuarioESenha(string nomeusuario, string senha) {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao.connection;
                command.CommandText = "select * from Usuarios where Usuario = @Usuario and Senha = @Senha;";
                command.Parameters.AddWithValue("@Usuario", nomeusuario);
                command.Parameters.AddWithValue("@Senha", senha);
                Conexao.Conectar();
                var reader = command.ExecuteReader();
                Usuario usuario = null;
                while (reader.Read()) {
                    usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(reader["id"]);
                    usuario.Nome_Usuario = Convert.ToString(reader["Usuario"]);
                    usuario.Senha = Convert.ToString(reader["Senha"]);
                    usuario.Perfil = Convert.ToChar(reader["Perfil"]);
                }
                return usuario;
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
