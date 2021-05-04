<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authentication.aspx.cs" Inherits="WebApplication5.Forms.Authentication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         <asp:Button ID="Stor" runat="server" Text="Stor" OnClick="Button1_Click" />
    
        <br />
                 <asp:Button ID="read" runat="server" Text="Read" OnClick="click" />
         <asp:Label ID="Label2" runat="server" Text="name"></asp:Label>
        <br />
                 <asp:Button ID="lien_" runat="server" Text="Lien" OnClick="lien" style="margin-bottom: 0px" />

    
    </div>
    </form>
</body>
</html>
