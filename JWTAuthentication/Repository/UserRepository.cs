using JWTAuthentication.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace JWTAuthentication.Repository
{
    public class UserRepository
    {
        private IConfiguration _configuration;

        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public User Find(string IdUsuario)
        {
            using (SqlConnection conexao = new SqlConnection(
                _configuration.GetConnectionString("ConnString")))
            {
                return conexao.QueryFirstOrDefault<User>(
                    "SELECT IdUsuario, Senha as AccessKey " +
                    "FROM dbo.tb_usuario " +
                    "WHERE IdUsuario = @IdUsuario", new { IdUsuario });
            }
        }
    }
}
