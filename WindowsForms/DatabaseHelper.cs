using System;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

public class DatabaseHelper
{
    private readonly string _connectionString = "Data Source=ZYNPYLMN\\MSSQLSERVER01;Initial Catalog=JwtAuthDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;";


    public bool RegisterUser(string email, string password)
    {
        string hashedPassword = HashPassword(password);

        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Users (Email, PasswordHash) VALUES (@Email, @PasswordHash)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }

    public bool LoginUser(string email, string password)
    {
        using (SqlConnection conn = new SqlConnection(_connectionString))
        {
            string query = "SELECT PasswordHash FROM Users WHERE Email = @Email";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", email);

            conn.Open();
            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                string storedHash = result.ToString();
                return VerifyPassword(password, storedHash);
            }

            return false;
        }
    }

    private string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }

    private bool VerifyPassword(string password, string storedHash)
    {
        return HashPassword(password) == storedHash;
    }
}

