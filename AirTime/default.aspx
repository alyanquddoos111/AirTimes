<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="AirTime._default" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Repeater ID="RepeaterShowPost" runat="server" OnItemCommand="RepeaterShowPost_ItemCommand">
                <ItemTemplate>
                    <div class="col-md-4 nav-item">
                        <a href="view.aspx?id=<%#Eval("PostId")%>" class="nav-link">
                            <div class="card mb-2">
                                <div class="card-body">
                                    <h3>
                                        <%#Eval("PostTitle") %> 
                                    </h3>

                                    <p>
                                        <%#Eval("Content") %>
                                    </p>

                                    <p class="small text-secondary">
                                        <%#Eval("TimePassed") %>
                                    </p>
                                </div>
                            </div>
                        </a>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

</asp:Content>
