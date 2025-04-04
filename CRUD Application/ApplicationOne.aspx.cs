using System;
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
            SqlDataSource1.InsertParameters["class"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("classTextBox")).Text;

            SqlDataSource1.Insert();
        }
    }
}