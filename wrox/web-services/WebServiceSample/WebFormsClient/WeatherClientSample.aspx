<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WeatherClientSample.aspx.cs" Inherits="WebFormsClient.WeatherClientSample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
 <h1>Weather Client</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
   
      

       <div>          
           <h3>Input</h3>
            <fieldset style="width: 350px;"> <legend>Temperature Type</legend>
            <asp:RadioButton ID="RadioButtonFahrenheit" runat="server" Text="Fahrenheit" GroupName="TemperatureType" Width="150px" />&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButtonCelsius" runat="server" Text="Celsius" GroupName="TemperatureType" Width="150px" />

            </fieldset> 
            <br /> <br />
            <asp:Label ID="labelCity" runat="server" Text="City:" Font-Bold="True"></asp:Label>
            <br />
            <asp:TextBox ID="textCity" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="buttonGetWeather" runat="server" Text="Get Weather" OnClick="OnGetWeather" />
      </div>
 <br /><br />

       <div>

           <h3>Output</h3>
           <asp:Label ID="labelWeatherCondition" runat="server" Font-Bold="True" Text="Weather Condition:"></asp:Label>
           <br />
           <asp:TextBox ID="textWeatherCondition" runat="server"></asp:TextBox>
           <br />
           <br />
           <asp:Label ID="labelTemperature" runat="server" Font-Bold="True" Text="Temperature:"></asp:Label>
           <br />
           <asp:TextBox ID="textTemperature" runat="server"></asp:TextBox>
           </div>

</asp:Content>
