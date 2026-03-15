using MySql.Data.MySqlClient;

namespace mySql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;user=root;password=Spot1234"; //port = (als port verschilt van default port)
            using(MySqlConnection connection = new MySqlConnection(connectionString)) //localhost => ip adress server (my computer)
            {
               try 
                {
                    connection.Open();
                    Console.WriteLine("Successfully connected to MySql server");

                    string cmdText = "CREATE DATABASE school;";
                    MySqlCommand cmd = new MySqlCommand(cmdText, connection); //to execute query
                    cmd.ExecuteNonQuery(); //execution  
                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                } 
            }
            
            /* string connectionString = "server=123.456.0.7;port=7779;user=root;password=root123";
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Successfully connected to the MySql server");

                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            } */


        }
    }
}