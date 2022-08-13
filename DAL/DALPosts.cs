using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class DALPosts
    {
        public static void SavePost(EntPosts posts)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_savePost", con);
            cmd.Parameters.AddWithValue("@title", posts.title);
            cmd.Parameters.AddWithValue("@content", posts.content);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void DeletePost(EntPosts posts)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_DeletePost", con);
            cmd.Parameters.AddWithValue("@PostId", posts.PostId);
            cmd.CommandType = CommandType.StoredProcedure;
            _ = cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable ShowPost()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_ShowPostData", con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                string id = (string)row["PostId"];
                SqlCommand cmd2 = new SqlCommand("SP_TimeUploaded", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@PostId", id);
                cmd2.ExecuteNonQuery();
            }
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }

        public static DataTable ViewPost(EntPosts posts)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_ViewPost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PostId", posts.PostId);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }
    }
}
