using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;


namespace Factorial
{
    class DataBaseHandler
    {
        //add params to connectionstring
        private string connectionString = @"server=localhost;uid=root;pwd=Vorontsov123;database=users";
        
        public List<string> GetUserNames()
        {
            using var connection = new MySqlConnection(connectionString);
            using var command = connection.CreateCommand();
            command.CommandType = System.Data.CommandType.Text;

            List<string> usernames = new List<string>();

            try
            {
                command.CommandText = @"SELECT name FROM users.usernames;";
                using (connection)
                {
                    connection.Open();
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var username = reader.GetString(0);
                        usernames.Add(username);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
            return usernames;
        }
        public void MakeClass(string name, int birth, decimal debt)
        {
            User user = new User();

            for(int i = 0; i < 5; i++)
            {
                //fill users
                user.Name = name;
                user.SetAge(birth);
                user.id = i;
                user.Debt = debt;

            }
        }
    }
}
