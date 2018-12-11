﻿
namespace CoffeeApp
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class DataAcccess
    {
        internal List<Person> GetPeople()
        {
            List<Person> personList = new List<Person>();
            SqlConnection connection = new SqlConnection(Helper.CnnStringValue("PetkoDataBase"));
            using (connection)
            {
                connection.Open();
                string query = "spe_get_users";
                SqlCommand command = new SqlCommand(query, connection);
                using (command)
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            Person person = new Person();
                            {
                                person.Firstname = (string)reader["first_name"];
                                person.Lastname = (string)reader["last_name"];   
                            };
                            personList.Add(person);
                        }

                    }
                }
            }
            return personList;
        }

        internal List<Drink> GetDrinks()
        {
            List<Drink> drinkList = new List<Drink>();
            SqlConnection connection = new SqlConnection(Helper.CnnStringValue("PetkoDataBase"));
            using (connection)
            {
                connection.Open();
                string sqlQuerie = "spe_get_drinks";
                SqlCommand command = new SqlCommand(sqlQuerie, connection);
                using (command)
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            Drink drink = new Drink();
                            drink.DrinkName = (string)reader["drink_name"];
                            drinkList.Add(drink);
                        }
                    }
                }
            }
            return drinkList;
        }

        internal void InsertIntoDB(string fullName, string typeOfDrink,int quantity)
        {
            SqlConnection connection = new SqlConnection(Helper.CnnStringValue("PetkoDataBase"));
            string[] splitName = fullName.Split().ToArray();
            string firtName = splitName[0];
            string lastName = splitName[1];
            using (connection)
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = $"spe_InsertData";
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@first_name", firtName);
                            command.Parameters.AddWithValue("@last_name", lastName);
                            command.Parameters.AddWithValue("@type_of_drink", typeOfDrink);
                            command.Parameters.AddWithValue("@quantity", quantity);
                            command.ExecuteNonQuery();

                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        if (transaction != null)
                        {
                            transaction.Rollback();
                        }
                    }
                }
            }
        }
        public DataTable GetDataSet()
        {
            // SqlConnection connection = new SqlConnection(Helper.CnnStringValue("PetkoDataBase"));
            // using (connection)
            // {
            //     connection.Open();
            //     string query = $"spe_get_report";
            //     SqlDataAdapter sda = new SqlDataAdapter(query,connection);
            //     sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //     DataTable dataTable = new DataTable();
            //     sda.Fill(dataTable);
            //     return dataTable;
            //     
            // }
            DataTable dt = new DataTable();
            return dt;
        }
    }
}
