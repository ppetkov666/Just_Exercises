using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Dynamic_Sql_demo
{
    public partial class SearchPageWithDynamicSql : System.Web.UI.Page
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

                StringBuilder sb = new StringBuilder("Select * from Employees where 1 = 1");

                if (inputFirstname.Value.Trim() != string.Empty)
                {
                    sb.Append(" AND Firstname=@i_first_name");
                    SqlParameter param = new SqlParameter("@i_first_name", inputFirstname.Value);
                    command.Parameters.Add(param);
                }
                if (inputLastname.Value.Trim() != string.Empty)
                {
                    sb.Append(" AND Lastname=@i_last_name");
                    SqlParameter param = new SqlParameter("@i_last_name", inputLastname.Value);
                    command.Parameters.Add(param);
                }
                if (inputJobTitle.Value.Trim() != string.Empty)
                {
                    sb.Append(" AND JobTitle=@i_job_title");
                    SqlParameter param = new SqlParameter("@i_job_title", inputJobTitle.Value);
                    command.Parameters.Add(param);
                }
                if (inputSalary.Value.Trim() != string.Empty)
                {
                    sb.Append(" AND Salary=@i_salary");
                    SqlParameter param = new SqlParameter("@i_salary", inputSalary.Value);
                    command.Parameters.Add(param);
                }

                command.CommandText = sb.ToString();
                command.CommandType = CommandType.Text;
                dbConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                gvSearchResults.DataSource = reader;
                gvSearchResults.DataBind();
            }
        }
    }
}