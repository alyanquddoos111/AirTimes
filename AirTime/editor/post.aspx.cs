using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using DAL;

namespace AirTime.editor
{
    public partial class Post : System.Web.UI.Page
    {
        EntPosts entPosts = new EntPosts();
        protected void Page_Load(object sender, EventArgs e)
        {
            getPosts();
        }
        private void getPosts()
        {
            RepeaterShowPost.DataSource = DALPosts.ShowPost();
            RepeaterShowPost.DataBind();
        }

        protected void RepeaterShowPost_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            entPosts.PostId = e.CommandArgument.ToString();
            DALPosts.DeletePost(entPosts);
            getPosts();
        }

    }
}