
namespace AdoConnectionApp
{
    using AdoConnectionApp.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Windows.Forms;
    using System.Data.SqlClient;

    public class DataAcccess
    {
        public List<Person> GetPeople(string lastname)
        {
            SqlConnection connection = new SqlConnection(Helper.CnnStringValue("PetkoDataBase"));
            List<Person> personList = new List<Person>(); 
            // this is the first Option to open and close a connection to the DB
            //connection.Open();
            //connection.Close();
            // the second option is  to use Using with inherited  interface IDisposable 
            using (connection)
            {
                connection.Open();
                // it is wrong ! 
                //string query = $"spe_PeopleGetByLastName {lastname}";
                string query = "spe_PeopleGetByLastName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Lastname", lastname);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Person person = new Person();
                            {
                                person.Firstname = (string)reader["Firstname"];
                                person.Lastname = (string)reader["Lastname"];
                                person.Age = (int)reader["Age"];
                                person.Country = (string)reader["Country"];
                            };
                            personList.Add(person);
                        }
                        
                    }
                }

            }
            return personList;
        }
        internal void InsertIntoDB(string firstname, string lastname, string age, string country)
        {
            SqlConnection connection = new SqlConnection(Helper.CnnStringValue("PetkoDataBase"));
            Person person = new Person { Firstname = firstname, Lastname = lastname, Age = int.Parse(age), Country = country };
            using (connection)
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string query = $"spe_InsertData {person.Firstname},{person.Lastname},{person.Age},{person.Country}";
                        using (SqlCommand command = new SqlCommand(query, connection,transaction))
                        {
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

