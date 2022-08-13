using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AirTime.admin
{
    public partial class editors : System.Web.UI.Page
    {
        EntEditor editor = new Entities.EntEditor();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getEditor();
            }

        }
        private void getEditor()
        {
            RepeaterShowEditor.DataSource = DALEditor.ShowEditor();
            RepeaterShowEditor.DataBind();
        }

        protected void RepeaterShowEditor_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            editor.EditorID = int.Parse(e.CommandArgument.ToString());
            DALEditor.DeleteEditor(editor);
            getEditor();
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("updateeditor.aspx");
        }
    }
}