
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
        internal List<Drink> GetCustomPerson(string firstName, string lastName)
        {
            List<Drink> drinkList = new List<Drink>();
            SqlConnection connection = new SqlConnection(Helper.CnnStringValue("PetkoDataBase"));
           
            using (connection)
            {
                connection.Open();
                string query = "spe_get_custom_report";
                SqlCommand command = new SqlCommand(query, connection);
                using (command)
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@first_name",firstName);
                    command.Parameters.AddWithValue("@last_name",lastName);
                    SqlDataReader reader = command.ExecuteReader();
                    //using (reader)
                    //{
                    //    while (reader.Read())
                    //    {
                    //        Drink drink = new Drink();
                    //        drink.DrinkName = reader.GetSqlValue(0).ToString();
                    //        drink.DrinkQuantity = decimal.Parse(reader.GetSqlValue(1).ToString());
                    //        drink.Total = decimal.Parse(reader.GetSqlValue(3).ToString());

                    //        drinkList.Add(drink);
                    //    }
                    //}
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            Drink drink = new Drink();
                            drink.DrinkName = (string)reader["type of drink"];
                            drink.Total = (decimal)reader["total"];
                            drink.DrinkQuantity = (decimal)reader["quantity"];

                            drinkList.Add(drink);
                        }
                    }
                }
            }
            return drinkList;
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
        internal DataTable GetDataSet()
        {
            SqlConnection connection = new SqlConnection(Helper.CnnStringValue("PetkoDataBase"));
            using (connection)
            {
                connection.Open();
                string query = $"spe_get_report";
                // we dont need command because we use SqlDataAdapter and pass the same params
                //SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                return dataTable;

            }
        }

        internal void InsertIntoDB(string fullName, string typeOfDrink, int quantity)
        {
            SqlConnection connection = new SqlConnection(Helper.CnnStringValue("PetkoDataBase"));
            string[] splitName = fullName.Split().ToArray();
            string firstName = splitName[0];
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
                            command.Parameters.AddWithValue("@first_name", firstName);
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
        internal void InsertUserIntoDB(string firstName, string lastName)
        {
            SqlConnection connection = new SqlConnection(Helper.CnnStringValue("PetkoDataBase"));
            using (connection)
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = $"spe_insert_user_name";
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@first_name", firstName);
                            command.Parameters.AddWithValue("@last_name", lastName);
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
        internal void InsertDrinks(string drinkName, double price)
        {
            SqlConnection connection = new SqlConnection(Helper.CnnStringValue("PetkoDataBase"));
            using (connection)
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = $"spe_insert_drink";
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@drink_name", drinkName);
                            command.Parameters.AddWithValue("@price", price);
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
    }
}
