<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Form.aspx.cs" Inherits="Form" %>

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
    </style>
    <title>Task 4 Of Advanced Net Techs</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" Text="Click here!" runat="server" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text="Not changed" />
        </div>
    </form>
</body>
</html>
