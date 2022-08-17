using System;
using Bcrypt.net;

namespace Hashing
{
    public class Hashing
    {
        public Hashing()
        {
            public void newUser(string username, string password)
            {
                //Hash the users password
                string passwordtohash = password + "&Y7~GW"; //&Y7~GW == Hardcode Salt
                string hashToStoreInDatabase = BCrypt.HashPassword(passwordtohash, BCrypt.GenerateSalt(12));

                //add user+ hashed password into database
                SqlConnection con = new SqlConnection
                {
                    ConnectionString = @" Data Source=DESKTOP-RMH53MH\SQLEXPRESS;Initial Catalog=GCRMDB;Integrated Security=True"
                }
                    con.Open()
    
                SqlCommand cmd = con.CreateCommand(query, con)
                cmd.CommandText = "INSERT INTO Users (Username, Password, isAdmin)" + " VALUES (@Username, @Password, @isAdmin)";
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
                cmd.ExecuteNonQuery();

            }

            /*private static string GetRandomSalt()
            {
                return BCrypt.GenerateSalt(12);
            }

            public static string HashPassword(string password)
            {
                return BCrypt.HashPassword(password, GetRandomSalt());
            }

            public static bool ValidatePassword(string password, string correctHash)
            {
                return BCrypt.Verify(password, correctHash);
            }*/

            /*private void updatePassword(string user, string Password)
            {


                string pwdToHash = Password + "&Y7~GW"; // &Y7~GW == hardcode Salt
                string hashToStoreInDatabase = BCrypt.HashPassword(pwdToHash, BCrypt.GenerateSalt());
                using (SqlConnection sqlConn = new SqlConnection)


                sqlConn.Open();
                SqlCommand cmSql = sqlConn.CreateCommand();
                cmSql.CommandText = "UPDATE LOGINS SET PASSWORD=@parm1 WHERE USERNAME=@parm2";
                cmSql.Parameters.Add("@parm1", SqlDbType.Char);
                cmSql.Parameters.Add("@parm2", SqlDbType.VarChar);
                cmSql.Parameters["@parm1"].Value = hashToStoreInDatabase;
                cmSql.Parameters["@parm2"].Value = user;
                cmSql.ExecuteNonQuery();
            }*/
        }

    }
}