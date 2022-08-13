<%@ Page Title="" Language="C#" MasterPageFile="~/editor/editor.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="AirTime.editor.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="row">
        <div class="col-md-4">
            <h3>Editor's Profile </h3>
            <img src="../content/dp/Final-04.jpg" width="40px" />
            <table class="table" width="100%">
              
                <tr>
                 
                    <td>
                        <asp:TextBox ID="ProfileFnAme" runat="server" CssClass="form-control"  ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
               
                    <td>
                        <asp:TextBox ID="ProfileLname" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>
                        <asp:TextBox ID="ProfileUname" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="ProfileEmail" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>
                        <asp:TextBox ID="ProfileRegDate" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox></td>
                </tr>
 <tr>
                    <td>
                        <asp:TextBox ID="ProfileLastVisit" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="ProfileDOB" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="ProfileMobile" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox></td>
                </tr>
               </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="ProfileImage" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:FileUpload ID="FileUploadDP" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ButtonUpdateProfile" runat="server" Text="Button" OnClick="ButtonUpdateProfile_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>


</asp:Content>
                               