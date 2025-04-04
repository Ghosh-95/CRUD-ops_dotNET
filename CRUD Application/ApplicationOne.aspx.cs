using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Application
{
    public partial class ApplicationOne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Submit_Database(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["name"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("nameTextBox")).Text;
            SqlDataSource1.InsertParameters["gender"].DefaultValue = ((DropDownList)GridView1.FooterRow.FindControl("genderListNew")).SelectedValue;
            SqlDataSource1.SelectParameters["class"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("classTextBox")).Text;

            int isInserted = SqlDataSource1.Insert();

            if (isInserted > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('New Item Created!')</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Insertion failed. Try again!')</script>");

            }
        }
    }
}