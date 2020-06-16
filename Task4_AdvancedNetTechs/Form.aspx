﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Form.aspx.cs" Inherits="Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <style>
        body
        {
            background-color:black;
            color:white;
        }
        p
        {
            width: 100%;
        }
        .wide
        {
            width:100%;
        }
    </style>
    <title>Task 4 Of Advanced Net Techs</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p><asp:TextBox CssClass ="wide" ID="TextBox1" runat="server" Text="Type your SQL Connection string here (e.g. (Data Source=DESKTOP-EPR1T48;Initial Catalog=CIAPAGI;Trusted_Connection = True;))"></asp:TextBox></p>
            <p><asp:Button ID="Button1" Text="Click here!" runat="server" OnClick="Button1_Click" /></p>
            <p><asp:Label ID="Label1" runat="server" Text="Not changed" /></p>
        </div>
    </form>
</body>
</html>
