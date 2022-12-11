using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using System.Diagnostics;

namespace WebApplication1.Models
{

    public class Personal_info
    {

        SQLiteConnection database;
        public Personal_info()
        {
            string connectionString = "Data source=C:\\Users\\nadam\\OneDrive\\Bureau\\tp 3 .net\\WebApplication1\\WebApplication1\\database.db;";
            database = new SQLiteConnection(connectionString);
            database.Open();
        }
        public List<Person> GetAllPerson()
        {

            List<Person> persons = new List<Person>();
            using (database)
            {
                SQLiteCommand command = new SQLiteCommand(
                    "SELECT * FROM personal_info", database
                    );
                SQLiteDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        persons.Add(new Person(reader));
                    }
                }
            }
            return persons;
        }
        public Person GetPerson(int id)
        {
            Person person = null;
            using (database)
            {
                SQLiteCommand command = new SQLiteCommand(
                    $"SELECT * FROM personal_info WHERE id = {id}", database
                    );
                SQLiteDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        person = new Person(reader);
                        Debug.WriteLine("hi");
                    }
                }
            }
            return person;
        }

        public int getid(string first_name, string country)
        {
            int id =0;
            Debug.WriteLine(first_name);
            Debug.WriteLine(country);
            using (database)
            {
                SQLiteCommand command = new SQLiteCommand(
                    $"SELECT * FROM personal_info WHERE first_name = '{first_name}' and country = '{country}'", database
                    );
                SQLiteDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                       

                        id = (int)reader["id"];
                    }
                }
            }
            return id;
        }
    }
}












