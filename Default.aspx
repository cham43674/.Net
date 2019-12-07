<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<center>
    <form id="form1" runat="server">
        Login ID<asp:TextBox 
            ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged" Width="206px" 
            BackColor="#99FF99" BorderColor="#66FF33" BorderStyle="Dashed" 
            ForeColor="#FF0066">Login ID</asp:TextBox>
        <br />
    <br />
    <div>
        Password<asp:TextBox ID="TextBox2" runat="server" Width="203px" 
            BackColor="#99FF99" BorderColor="#66FF33" BorderStyle="Dashed" 
            ForeColor="#FF0066">Password</asp:TextBox>
        <br />
    </div>
    <p>
                                  <asp:Button ID="Button1" runat="server" Height="32px" onclick="Button1_Click" 
            Text="Sign In" Width="77px" BackColor="Yellow" BorderColor="Red" BorderStyle="Groove" 
                                      ForeColor="#CC33FF" />
    </p>
    </form>
    </center>
</body>
</html>
