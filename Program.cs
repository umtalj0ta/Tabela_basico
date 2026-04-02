using System;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=users.db";

        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();
            //Aqui crio a tabela
            var createCmd = connection.CreateCommand();
            createCmd.CommandText =
            @"
            CREATE TABLE IF NOT EXISTS USERS (
                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL, 
                Age INTEGER);
            ";
            createCmd.ExecuteNonQuery();

         //Inserir os dados       
            var insertCmd = connection.CreateCommand();
            insertCmd.CommandText =
            @"  
                INSERT INTO Users(Name,Age)
                VALUES ('Ana', 25),
                        ('Rui', 40);
            ";

            insertCmd.ExecuteNonQuery();            
                
        //agora ler os dados
            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM Users;";

            using( var reader = selectCmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    Console.WriteLine($"Id: {reader.GetInt32(0)}, Nome : {reader.GetString(1)}, Idade: {reader.GetInt32(2)}");
                }
            }
        }
    }
}