<%@ Page Title="" Language="C#" MasterPageFile="~/editor/editor.Master" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="AirTime.editor.Post" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="row">
        <div class="col-md-12 mt-3">
            <div class="card">
                <a href="addnewpost.aspx" class="btn btn-danger">Add New</a>
                <div class="card-body">
                    <table class="table table-striped table-hover">

                        <asp:Repeater ID="RepeaterShowPost" runat="server" OnItemCommand="RepeaterShowPost_ItemCommand">

                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("PostTitle") %> </td>
                                    <td><%#Eval("Content") %> </td>
                                    <td><%#Eval("TimePassed") %> </td>
                                   
<%--                                     <td>
                                        <asp:Button ID="ButtonUpdate" runat="server" Text="Update" CommandArgument='<%#Eval("PostID")%>' CommandName="UpdateData" />
                                    </td>--%>
                                    <td>
                                        <asp:Button ID="ButtonDelete" runat="server" Text="Delete" CommandArgument='<%#Eval("postId")%>' CommandName="DeleteData"/>
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
