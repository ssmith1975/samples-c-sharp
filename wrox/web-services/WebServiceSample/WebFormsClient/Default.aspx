<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsClient._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Web Forms Client</h2>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:TextBox ID="TextBox1" runat="server" Width="447px"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Reverse Message" Width="454px" OnClick="Button1_Click" />
<br />
<br />
<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="447px"></asp:TextBox>
<br />
</asp:Content>
