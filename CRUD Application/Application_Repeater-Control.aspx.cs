using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_Application
{
    public partial class Application_Repeater_Control : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RepeaterConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dataTable = GetData();

            // Set the data source of the GridView
            GridView2.DataSource = dataTable;

            // Bind the data to the GridView
            GridView2.DataBind();

            // Set the data source of the Repeater
            Repeater1.DataSource = dataTable;

            // Bind the data to the Repeater
            Repeater1.DataBind();
        }

        DataTable GetData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "SELECT * FROM Employee";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }

    }
}