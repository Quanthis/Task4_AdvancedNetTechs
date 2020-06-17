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
        </div>

        <div>
            <asp:Button ID="Button1" Text="Sew" runat="server" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text="How much you want to sew?"/>
            <asp:TextBox ID="HowMuchToSew" runat="server" Text="0" />
            <asp:Label ID="SewInfo" runat="server" />
        </div>

        <div>
            <asp:Button ID="Collect" runat="server" Text="Collect" OnClick="Collect_Click" />
            <asp:Label ID="CollectedInfo" runat="server" Text="Collected: " />            
        </div>

        <div>
            <asp:Button ID="Check" runat="server" Text="Check current farm state" OnClick="Check_Click" />
            <asp:Label ID="CurrentState" runat="server" Text="Farm current state: " />
        </div>
    </form>
</body>
</html>
