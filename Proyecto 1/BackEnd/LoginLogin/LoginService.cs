using System;
using MySql.Data.MySqlClient;

namespace Proyecto_1.BackEnd
{
    public class LoginService
    {
        private string connectionString = "server=localhost; user id = root; password =P3rR012.;database=ing; port=3306;";

        public bool AutenticarUsuario(string usuario, string password)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Usuario WHERE usuario=@usuario AND password= @password";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}

