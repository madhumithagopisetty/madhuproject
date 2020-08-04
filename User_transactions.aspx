<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_transactions.aspx.cs" Inherits="Transactions_track.Fund_Transfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <h1>Customer Transactions</h1>
            <br />
            <br />
            <asp:GridView ID="Transactions_grid" runat="server"></asp:GridView>
        </div>
        <asp:Button ID="btn_fundtransfer" runat="server" Text="FUND TRANSFER" OnClick="btn_fundtransfer_Click" />
    </form>
</body>
</html>
