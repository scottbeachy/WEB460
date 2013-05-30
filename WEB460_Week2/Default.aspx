<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Lets Do Some Math</h2>
        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnSub" runat="server" Text="Subtract" OnClick="btnSub_Click" />
        <asp:Button ID="btnMult" runat="server" Text="Multiply" OnClick="btnMult_Click" />
        <asp:Button ID="btnDiv" runat="server" Text="Divide" OnClick="btnDiv_Click" /><br />
        <asp:Label ID="lblAnswer" runat="server" Text="" Visible="false"  Font-Size="10em" Font-Bold="true" ></asp:Label><br />
        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" /><br />  
    </div>
    </form>
</body>
</html>
