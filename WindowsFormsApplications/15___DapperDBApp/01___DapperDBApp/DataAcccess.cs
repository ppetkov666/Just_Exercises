
namespace DapperConnectionApp
{
    using DapperConnectionApp.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using Dapper;
    using System.Windows.Forms;

    public class DataAcccess
    {
        public List<Person> GetPeople(string lastname)
        {   
            using (IDbConnection  connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringValue("PetkoDataBase")))
            {

                // this option is vulnerable to sql injection so it is a bad practice
                //List<Person> output = connection.Query<Person>($"Select * from People where Lastname = '{lastname}'").ToList();
                // this is the second option
                //List<Person> output = connection.Query<Person>($"spe_PeopleGetByLastName {lastname}").ToList();
                // third option with creating dynamic class and Dapper helps to map LastName property of the dynamic class to the variable @LastName
                List<Person> output = connection.Query<Person>($"spe_PeopleGetByLastName @LastName", new { LastName = lastname}).ToList();
                return output; 
            }
        }
        internal void InsertIntoDB(string firstname, string lastname, string age, string country)
        {
            Person person = new Person { Firstname = firstname, Lastname = lastname, Age = int.Parse(age), Country = country };
            //List<Person> listOfPersons = new List<Person>();
            //listOfPersons.Add(person);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnStringValue("PetkoDataBase")))
            {
                connection.Execute("spe_InsertData @Firstname, @LastName, @Age, @Country", person);
            }
        }
    }
}
