
namespace _01___WFDinamicallyCreatedButtons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.SqlClient;
    using _01___WFDinamicallyCreatedButtons.Model;

    public class DataAccess
    {
        public void ChangeState()
        {
            SqlConnection connection = new SqlConnection(Helper.ConnectionStringValue("PetkoTestDB"));


            using (connection)
            {
                connection.Open();

                string spquery = "dbo.sp_ChangeActiveState";
                using (SqlCommand command = new SqlCommand(spquery,connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool GetState()
        {
            SqlConnection connection = new SqlConnection(Helper.ConnectionStringValue("PetkoTestDB"));
            bool isactive = false;

            using (connection)
            {
                connection.Open();

                string spquery = "dbo.sp_GetState";
                using (SqlCommand command = new SqlCommand(spquery, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            isactive =  (bool)reader["Active"];
                        }
                    }
                }
            }
            return isactive;
        }
    }
}
