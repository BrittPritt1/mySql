using MySql.Data.MySqlClient;

namespace mySql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=Spot1234"); //localhost = ip adress server (my computer)
            connection.Open();

            Console.WriteLine("Successfully connected to MySql server");

        }
    }
}