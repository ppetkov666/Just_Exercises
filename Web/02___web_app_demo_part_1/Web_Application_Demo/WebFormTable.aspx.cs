
namespace Web_Application_Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Data;
    using System.Data.SqlClient;
    using System.Configuration;
    public partial class WebFormTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }

        protected void buttonSearch_Click(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            string cs = ConfigurationManager.ConnectionStrings["MyDataBaseSample"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("sp__search_users",connection);
                cmd.CommandType = CommandType.StoredProcedure;

                AttachParams(cmd, "@user_name", txtName);
                AttachParams(cmd, "@email", txtEmail);
                AttachParams(cmd, "@town", txtTown);

                connection.Open();
                gvUsers.DataSource = cmd.ExecuteReader();
                gvUsers.DataBind();
            }
        }
        private void AttachParams(SqlCommand command, string paramName, Control control)
        {
            if (control is TextBox && ((TextBox)control).Text != string.Empty)
            {
                SqlParameter param = new SqlParameter(paramName, ((TextBox)control).Text);
                command.Parameters.Add(param);
            }
        }
    }
}