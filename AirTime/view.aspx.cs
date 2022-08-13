using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace AirTime
{
    public partial class fullpost : System.Web.UI.Page
    {
        EntPosts posts = new EntPosts();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                posts.PostId = Request.QueryString["id"].ToString();
            }
            getFullPost(posts.PostId);
        }

        public void getFullPost(string postId)
        {
            RepeaterFullPost.DataSource = DALPosts.ViewPost(posts);
            RepeaterFullPost.DataBind();
        }
    }
}