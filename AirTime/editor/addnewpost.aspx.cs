using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Entities;

namespace AirTime.editor
{
    public partial class addnewpost : System.Web.UI.Page
    {
        EntPosts entPosts = new Entities.EntPosts();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            entPosts.title = TextBoxTitle.Text;
            entPosts.content = txtContent.Text;
            DALPosts.SavePost(entPosts);
            TextBoxTitle.Text = "";
            txtContent.Text = "";
            Response.Redirect("post.aspx");
        }
    }
}