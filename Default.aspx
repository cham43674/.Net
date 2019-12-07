<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
 
    <asp:Button ID="Button1" runat="server" Text="BtnClick" 
            onclick="Button1_Click" />
 
    </div>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>DEFAULT</asp:ListItem>
            <asp:ListItem>MANGO</asp:ListItem>
            <asp:ListItem>PINEAPPLE</asp:ListItem>
            <asp:ListItem>JACKFRUIT</asp:ListItem>
            <asp:ListItem>APPLE</asp:ListItem>
        </asp:DropDownList>
    </p>
    </form>
</body>
</html>
