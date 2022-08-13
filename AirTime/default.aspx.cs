using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Entities;

namespace AirTime
{
    
    public partial class _default : System.Web.UI.Page
    {
        EntPosts post = new Entities.EntPosts();
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

        }
    }
}