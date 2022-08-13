<%@ Page Title="" Language="C#" MasterPageFile="~/editor/editor.Master" AutoEventWireup="true" CodeBehind="addnewpost.aspx.cs" Inherits="AirTime.editor.addnewpost" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>CkEdtior</div>
    
    <asp:TextBox ID="TextBoxTitle" placeholder="Title" runat="server" Height="40px" Width="832px" class="ckeditor"></asp:TextBox>
    
    <div>
        <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" Columns="60" Rows="10" class="ckeditor"></asp:TextBox>
    </div>

    <br />
    <asp:Label ID="Label1" runat="server">
    </asp:Label>

    <script>
        $(document).ready(function () {

            CKEDITOR.replace('txtContent', {
                htmlEncodeOutput: true
            });
        })
    </script>
    <asp:Button ID="ButtonSave" runat="server" Text="ButtonSave" OnClick="ButtonSave_Click"/>

     <%--<p>
    </p>

        <asp:TextBox ID="TextBoxContent" placeholder="Content" runat="server" Height="159px" Width="837px"></asp:TextBox>
    </p>
    <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />
    <hr />--%>


</asp:Content>
