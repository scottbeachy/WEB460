<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        $(document).ready(function(){
            $(".txtExp").datepicker();
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Please enter your information below to complete your purchase</h2>
    <div class="custInfo">
        <asp:Label ID="Label1" CssClass="lblInfo" runat="server" Text="First Name:" AssociatedControlID="txtFname"></asp:Label>
        <asp:TextBox ID="txtFName" runat="server" CssClass="txtInfo" ></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" CssClass="lblInfo" Text="Last Name:" AssociatedControlID="txtLName"></asp:Label>
        <asp:TextBox ID="txtLName" runat="server" CssClass="txtInfo"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" CssClass="lblInfo" Text="Street Address:" AssociatedControlID="txtAddr"></asp:Label>
        <asp:TextBox ID="txtAddr" runat="server" CssClass="txtInfo"></asp:TextBox><br />
        <asp:Label ID="Label4" runat="server" CssClass="lblInfo" Text="City:" AssociatedControlID="txtCity"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" CssClass="txtInfo"></asp:TextBox><br />
        <asp:Label ID="Label5" runat="server" CssClass="lblInfo" Text="State:" AssociatedControlID="txtState"></asp:Label>
        <asp:TextBox ID="txtState" runat="server" CssClass="txtInfo"></asp:TextBox><br />
        <asp:Label ID="Label6" runat="server" CssClass="lblInfo" Text="Zip:" AssociatedControlID="txtZip"></asp:Label>
        <asp:TextBox ID="txtZip" runat="server" CssClass="txtInfo"></asp:TextBox><br />
        <asp:Label ID="Label7" runat="server" CssClass="lblInfo" Text="Email:" AssociatedControlID="txtEmail"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="txtInfo"></asp:TextBox><br />
    </div>
    <div class="custInfo">
        <h2>Payment Info</h2><br />
        <asp:Label ID="Label8" runat="server" CssClass="lblInfo" Text="Credit Card Number:" AssociatedControlID="txtCardNum"></asp:Label>
        <asp:TextBox ID="txtCardNum" runat="server" CssClass="txtInfo"></asp:TextBox><br />
        <asp:Label ID="Label9" runat="server" CssClass="lblInfo" Text="Expiration Date:" AssociatedControlID="txtExpDate"></asp:Label>
        <asp:TextBox ID="txtExpDate" runat="server" CssClass="txtExp" ></asp:TextBox><br />
        <asp:Button ID="btnPurchase" runat="server" Text="Authorize Transaction" OnClick="btnPurchase_Click" CssClass="btnPurchase" />

    </div>



</asp:Content>

