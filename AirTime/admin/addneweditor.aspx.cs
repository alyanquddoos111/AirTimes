using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using DAL;

namespace AirTime.admin
{
    public partial class addneweditor : System.Web.UI.Page
    {
        EntEditor editor = new Entities.EntEditor();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

        }

        protected void SaveEditor(object sender, EventArgs e)
        {
            editor.FirstName = TB_EditorFname.Text;
            editor.LastName = TB_EditorLname.Text;
            editor.EditorUserName = TB_EditorUname.Text;
            editor.Email = TB_EditorEmail.Text;
            editor.Password = TB_EditorPass.Text;

            DALEditor.SaveEditor(editor);
            TB_EditorFname.Text = "";
            TB_EditorLname.Text = "";
            TB_EditorUname.Text = "";
            TB_EditorEmail.Text = "";
            TB_EditorPass.Text = "";
            Response.Redirect("editors.aspx");
        }

    }
}