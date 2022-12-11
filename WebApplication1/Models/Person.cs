using Microsoft.Ajax.Utilities;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Person
    {
        public int id;
        public string first_name;
        public string last_name;
        public string email;
       
        public string image;
        public string country;

        public Person (SQLiteDataReader reader)
        {
            this.id = (int)reader["id"];
            this.first_name = (string)reader["first_name"];
            this.last_name = (string)reader["last_name"];
            this.email = (string)reader["email"];
           
            this.image = (string)reader["image"];
            this.country = (string)reader["country"];
        }

        public int getId()
        {
            return this.id;
        }
    }
   
}