<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_fund_transfer.aspx.cs" Inherits="Transactions_track.User_fund_transfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
               FUND TRANSFER
            </h1>
            <div>
                <table>
                    <tr>
                        <td>Customer Name:-</td>
                        <td>
                            <asp:Label ID="lblcustomername" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Account number</td>
                        <td>
                            <asp:Label ID="lblaccountnumber" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Account balance</td>
                        <td>
                            <asp:Label ID="lblaccountbalance" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Amount Transferring</td>
                        <td>
                            <asp:TextBox ID="txtfundtransfering" runat="server" Text="0"></asp:TextBox></td>
                    </tr>
                </table>
            </div>
            <asp:Button ID="btnfundtransfer" runat="server" Text="Transfer" OnClick="btnfundtransfer_Click" />
        </div>
    </form>
</body>
</html>
