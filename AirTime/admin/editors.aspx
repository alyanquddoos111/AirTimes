<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="editors.aspx.cs" Inherits="AirTime.admin.editors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12 mt-3">
            <div class="card">
                <a href="addneweditor.aspx" class="btn btn-danger">Add New</a>
                <div class="card-body">
                    <table class="table table-striped table-hover">

                        <asp:Repeater ID="RepeaterShowEditor" runat="server" OnItemCommand="RepeaterShowEditor_ItemCommand">

                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("FirstName") %> </td>
                                    <td><%#Eval("LastName") %> </td>
                                    <td><%#Eval("EditorUserName") %> </td>
                                    <td><%#Eval("Email") %> </td>
                                   
                                     <td>
                                        <asp:Button ID="ButtonUpdate" runat="server" Text="Update" CommandArgument='<%#Eval("EditorID")%>' CommandName="UpdateData" />
                                    </td>
                                    <td>
                                        <asp:Button ID="ButtonDelete" runat="server" Text="Delete" CommandArgument='<%#Eval("EditorID")%>' CommandName="DeleteData"/>
                                    </td>
                      
                                </tr>
                            </ItemTemplate>

                        </asp:Repeater>

                    </table>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
