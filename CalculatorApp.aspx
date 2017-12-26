<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalculatorApp.aspx.cs" Inherits="CalculatorApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <table>
                <tr>
                    <td>First Number:</td>
                    <td><asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Second Number:</td>
                    <td><asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Result:</td>
                    <td><asp:Label ID="lblResult" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2">

                        <asp:GridView ID="gridCalcHistory" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                            <AlternatingRowStyle BackColor="PaleGoldenrod" />
                            <FooterStyle BackColor="Tan" />
                            <HeaderStyle BackColor="Tan" Font-Bold="True" />
                            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                            <SortedAscendingCellStyle BackColor="#FAFAE7" />
                            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                            <SortedDescendingCellStyle BackColor="#E1DB9C" />
                            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                        </asp:GridView>

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
