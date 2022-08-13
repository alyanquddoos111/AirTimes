using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace DAL
{
   public  class DALEditor
    {
        public static void SaveEditor(EntEditor editor)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_SaveEditorData", con);
            cmd.Parameters.AddWithValue("@FirstName", editor.FirstName);
            cmd.Parameters.AddWithValue("@LastName", editor.LastName);
            cmd.Parameters.AddWithValue("@Username", editor.EditorUserName);
            cmd.Parameters.AddWithValue("@Email", editor.Email);
            cmd.Parameters.AddWithValue("@Password", editor.Password);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable ShowEditor()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_showEditorData", con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;
        }

        public static void DeleteEditor(EntEditor editor)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_DeleteEditor", con);
            cmd.Parameters.AddWithValue("@EditorId", editor.EditorID);
            cmd.CommandType = CommandType.StoredProcedure;
            _ = cmd.ExecuteNonQuery();
            con.Close();
        }

        public static EntEditor ShowEditor(EntEditor editor)
        {
            EntEditor updateEditor = new Entities.EntEditor();
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_showEditorData", con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                updateEditor.FirstName = dr["FirstName"].ToString();
                updateEditor.LastName = dr["LastName"].ToString();
                updateEditor.EditorUserName = dr["EditorUserName"].ToString();
                updateEditor.Email = dr["Email"].ToString();
            }
            return updateEditor;
        }
        public static EntEditor ProfileEditor()
        {
            EntEditor ProfileEditor = new Entities.EntEditor();
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_EditorProfile", con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ProfileEditor.FirstName = dr["FirstName"].ToString();
                ProfileEditor.LastName = dr["LastName"].ToString();
                ProfileEditor.EditorUserName = dr["EditorUserName"].ToString();
                ProfileEditor.Email = dr["Email"].ToString();
                ProfileEditor.DOB = dr["DOB"].ToString();
                ProfileEditor.MobileNumber = dr["MobileNumber"].ToString();
                ProfileEditor.Reg_Date = dr["Reg_Date"].ToString();
                ProfileEditor.Last_Login = dr["Last_Login"].ToString();
                ProfileEditor.DisplayPicture = dr["DisplayPicture"].ToString();
            }
            return ProfileEditor;
        }
    }
}
