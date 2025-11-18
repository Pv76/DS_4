<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio154.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Num1<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Num2<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Resultado: "></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sumar" />
        </p>
    </form>
</body>
</html>
