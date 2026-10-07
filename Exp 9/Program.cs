using System;
using System.Data;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=Student.db";

        DataTable studentTable = new DataTable();

        using (SqliteConnection connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            string createTable = @"
                CREATE TABLE IF NOT EXISTS Students
                (
                    ID INTEGER PRIMARY KEY,
                    Name TEXT,
                    Department TEXT
                )";

            using (SqliteCommand command = new SqliteCommand(createTable, connection))
            {
                command.ExecuteNonQuery();
            }

            using (SqliteCommand command =
                   new SqliteCommand("DELETE FROM Students", connection))
            {
                command.ExecuteNonQuery();
            }

            string insertData = @"
                INSERT INTO Students VALUES
                (101, 'Arun', 'IT'),
                (102, 'Priya', 'CSE'),
                (103, 'Kevin', 'ECE')";

            using (SqliteCommand command = new SqliteCommand(insertData, connection))
            {
                command.ExecuteNonQuery();
            }

            string selectData = "SELECT * FROM Students";

            using (SqliteCommand command = new SqliteCommand(selectData, connection))
            {
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    studentTable.Load(reader);
                }
            }
        }

        Console.WriteLine("Student Details");
        Console.WriteLine("----------------------------------------");

        foreach (DataRow row in studentTable.Rows)
        {
            Console.WriteLine(
                "ID: " + row["ID"] +
                ", Name: " + row["Name"] +
                ", Department: " + row["Department"]);
        }

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Data retrieved successfully.");
        Console.WriteLine("Working in disconnected environment.");
    }
}