using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Crypto.Prng;

namespace mySql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string connectionString = "server=localhost;user=root;password=Spot1234;database=school;"; //port = (als port verschilt van default port)
            using(MySqlConnection connection = new MySqlConnection(connectionString)) //localhost => ip adress server (my computer)
            {
               try 
                {
                    connection.Open();
                    Console.WriteLine("Successfully connected to MySql server");

                    //1. CREATE DATBASE dbname
                        //string cmdText = "CREATE DATABASE school;";

                    //2. MySqlCommand object
                        //MySqlCommand cmd = new MySqlCommand(cmdText, connection);

                    //3. ExecuteNonQuery, ExecuteReader, ExecuteScalar
                        //cmd.ExecuteNonQuery();

                    string[] studentNames =
                    {
                        "Alice Joghnson", 
                        "Bob Smith", 
                        "Charlie Williams", 
                        "David Jones", 
                        "Eva Brown", 
                        "Frank Miller", 
                        "Grace Davis", 
                        "Henry Garcia",
                        "Ivy Rodriguez",
                        "Jack Martinez"
                    };

                    new MySqlCommand("DROP TABLE students", connection).ExecuteNonQuery();

                    string tableCmdText = "CREATE TABLE students (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(30), age INT);";
                    var tableCmd = new MySqlCommand(tableCmdText, connection);
                    tableCmd.ExecuteNonQuery();
                    Console.WriteLine("Create table 'students'");

                    for(int i = 0; i < studentNames.Length; i++)
                    {
                        int ageRandom = new Random().Next(20,30);
                        string insertCmdText = $"INSERT INTO students (name, age) VALUE ('{studentNames[i]}', '{ageRandom}');";
                        var insertCmd = new MySqlCommand(insertCmdText, connection);
                        insertCmd.ExecuteNonQuery();
                        Console.WriteLine($"-> Inserted row {i + 1}");
                    }

                    string queryCmdText = "SELECT * FROM students;";
                    var queryCmd = new MySqlCommand(queryCmdText,connection);
                    using(MySqlDataReader reader = queryCmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string name = reader.GetString("name");
                            int age = reader.GetInt32("age");

                            Console.WriteLine($"ID: {id}, NAME: {name}, AGE: {age}");
                        }   
                    }

                    string cmdTextScalar = "SELECT name FROM students WHERE id = 5;";
                    var cmdScalar = new MySqlCommand(cmdTextScalar, connection);
                    string scalarName = (string) cmdScalar.ExecuteScalar();
                    Console.WriteLine("Scalar value: " + scalarName);
                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                } 
            } */
            
            string connectionString = "server=123.456.0.7;port=7779;user=root;password=root123;database=school";
            using(MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=Spot1234;database=school"))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Successfully connected to the MySql server");

                    new MySqlCommand("DROP TABLE teachers", connection).ExecuteNonQuery();

                    string cmdTextTable = "CREATE TABLE teachers (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(30), age INT, experience FLOAT);";
                    MySqlCommand cmd = new MySqlCommand(cmdTextTable, connection);
                    cmd.ExecuteNonQuery();

                    new MySqlCommand("INSERT INTO teachers (name, age, experience) VALUES ('John Smith', 35, 5.5);", connection).ExecuteNonQuery();
                    new MySqlCommand("INSERT INTO teachers (name, age, experience) VALUES ('Anna Johnson', 40, 8.2);", connection).ExecuteNonQuery();
                    new MySqlCommand("INSERT INTO teachers (name, age, experience) VALUES ('Robert Davis', 32, 3.1);", connection).ExecuteNonQuery();

                    string selectCmdText = "SELECT * from teachers;";
                    var selectCmd = new MySqlCommand(selectCmdText, connection);
                    using(MySqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string name = reader.GetString("name");
                            int age = reader.GetInt32("age");
                            float exp = reader.GetFloat("experience");

                            Console.WriteLine($"ID: {id}, NAME: {name}, AGE: {age}, EXPERIENCE: {exp}");
                        }
                    }

                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }


        }
    }
}