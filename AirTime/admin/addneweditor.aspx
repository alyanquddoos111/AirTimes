<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="addneweditor.aspx.cs" Inherits="AirTime.admin.addneweditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-4">
            <h3>Editor information</h3>
            <table class="table">
                <tr>
                    <td>First Name</td>
                    <td>
                        <asp:TextBox ID="TB_EditorFname" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>Last Name</td>
                    <td>
                        <asp:TextBox ID="TB_EditorLname" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox ID="TB_EditorUname" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="TB_EditorEmail" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>password</td>
                    <td>
                        <asp:TextBox ID="TB_EditorPass" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="EditorSave" runat="server" Text="Save" OnClick="SaveEditor"  CssClass="btn btn-success form-control" /></td>
                </tr>
            </table>
        </div>
    </div>




   

</asp:Content>
