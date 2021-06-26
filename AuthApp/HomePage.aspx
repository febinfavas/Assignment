<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="AuthApp.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">Welecome To Authentication App</h1>
            <br />
            <p class="auto-style1">
                Hello&nbsp; <asp:Label ID="LabeluserDetail" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            
            </p>
            <p class="auto-style1">
                <asp:Button ID="ButtonLogout" runat="server" OnClick="ButtonLogout_Click" Text="Logout" />
            <br />
            
            </p>
           

        </div>
    </form>
</body>
</html>
