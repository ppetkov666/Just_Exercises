using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Dynamic_Sql_demo
{
    public partial class DynamicSqlInStoreProcedure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            using (SqlConnection dbConnection = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = dbConnection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "spSearchEmployeesGoodDynamicSql";
                // it demonstrate both approaches  how to use dynamic sql in SP
                //spSearchEmployeesBadDynamicSql



                if (inputFirstname.Value.Trim() != string.Empty)
                {
                    SqlParameter param = new SqlParameter("@i_first_name", inputFirstname.Value);
                    command.Parameters.Add(param);
                }
                if (inputLastname.Value.Trim() != string.Empty)
                {

                    SqlParameter param = new SqlParameter("@i_last_name", inputLastname.Value);
                    command.Parameters.Add(param);
                }
                if (inputJobTitle.Value.Trim() != string.Empty)
                {

                    SqlParameter param = new SqlParameter("@i_job_title", inputJobTitle.Value);
                    command.Parameters.Add(param);
                }
                if (inputSalary.Value.Trim() != string.Empty)
                {

                    SqlParameter param = new SqlParameter("@i_salary", inputSalary.Value);
                    command.Parameters.Add(param);
                }
                dbConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                gvSearchResults.DataSource = reader;
                gvSearchResults.DataBind();
            }
        }
    }
}