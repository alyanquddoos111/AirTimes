using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTime.admin
{
    public partial class updateeditor : System.Web.UI.Page
    {
        EntEditor editor = new Entities.EntEditor();
        EntEditor upEditor = new Entities.EntEditor();
        protected void Page_Load(object sender, EventArgs e)
        {
            updateEditor();
        }

        public void updateEditor()
        {
            upEditor = DALEditor.ShowEditor(editor);
            TB_UpdateEditorFname.Text = upEditor.FirstName;
            TB_UpdateEditorLname.Text = upEditor.LastName;
            TB_UpdateEditorUname.Text = upEditor.EditorUserName;
            TB_UpdateEditorEmail.Text = upEditor.Email;
        }

        protected void EditorUpdate_Click(object sender, EventArgs e)

        {
            editor.FirstName = TB_UpdateEditorFname.Text;
            editor.LastName = TB_UpdateEditorLname.Text;
            editor.EditorUserName = TB_UpdateEditorUname.Text;
            editor.Email = TB_UpdateEditorEmail.Text;
            editor.Password = TB_UpdateEditorPass.Text;

            DALEditor.ShowEditor();
            TB_UpdateEditorFname.Text = "";
            TB_UpdateEditorLname.Text = "";
            TB_UpdateEditorUname.Text = "";
            TB_UpdateEditorEmail.Text = "";
            TB_UpdateEditorPass.Text = "";
            Response.Redirect("editors.aspx");
        }
    }
}