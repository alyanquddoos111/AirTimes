using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;

namespace AirTime.editor
{
    public partial class Profile : System.Web.UI.Page
    {
        EntEditor editor = new Entities.EntEditor();
        protected void Page_Load(object sender, EventArgs e)
        {
            getEditorProfile();
        }
        public void getEditorProfile ()
        {
            editor = DALEditor.ProfileEditor();
            ProfileFnAme.Text = editor.FirstName;
            ProfileLname.Text = editor.LastName;
            ProfileEmail.Text = editor.Email;
            ProfileUname.Text = editor.EditorUserName;
            ProfileRegDate.Text = editor.Reg_Date;
            ProfileLastVisit.Text = editor.Last_Login;
            ProfileDOB.Text = editor.DOB;
            ProfileMobile.Text = editor.MobileNumber;
            ProfileImage.Text = editor.DisplayPicture;
        }

        protected void ButtonUpdateProfile_Click(object sender, EventArgs e)
        {
            if (FileUploadDP.HasFile)
            {
                string filepath = "../content/dp/";
                string filename = FileUploadDP.FileName;
                FileUploadDP.SaveAs(Server.MapPath(filepath + filename));
                string dpurl = filepath + filename;
            }

        }
    }
}