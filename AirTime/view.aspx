<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="AirTime.fullpost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="RepeaterFullPost" runat="server">
        <ItemTemplate>
            <div>
                <h3>
                    <%#Eval("PostTitle") %> 
                </h3>

                <p>
                    <%#Eval("Content") %>
                </p>
            </div>
        </ItemTemplate>


    </asp:Repeater>


</asp:Content>
