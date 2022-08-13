<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="updateeditor.aspx.cs" Inherits="AirTime.admin.updateeditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="row">
        <div class="col-md-4">
            <h3>Update Information</h3>
            <table class="table" width="100%">
                <tr>
                    <td>First Name</td>
                    <td>
                        <asp:TextBox ID="TB_UpdateEditorFname" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>Last Name</td>
                    <td>
                        <asp:TextBox ID="TB_UpdateEditorLname" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox ID="TB_UpdateEditorUname" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="TB_UpdateEditorEmail" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>password</td>
                    <td>
                        <asp:TextBox ID="TB_UpdateEditorPass" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>

                <tr>
                    <td></td>
                    <td>
                       <asp:Button ID="EditorUpdate" runat="server" Text="Update" OnClick="EditorUpdate_Click" CssClass="btn btn-success form-control" /></td>
                </tr>
            </table>
        </div>
    </div>


</asp:Content>
