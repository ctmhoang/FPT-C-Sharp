<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="LAB3.view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Course</title>
    <style>
        body {
            font-family: Roboto;
            font-size: 1.7em;
        }

        .full-width { width: 100% }
    </style>
</head>
<body>
<form runat="server">
    <asp:Label runat="server" ID="lb_notify" Text="Do not have any students"></asp:Label>
    <asp:GridView runat="server" Visible="False" CssClass="full-width" ID="gw_display" AutoGenerateColumns="False" EnableViewState="False" BorderColor="peru" BorderWidth="1" CellPadding="3" Font-Names="Roboto" Font-Size="1.2em">
        <SelectedRowStyle BackColor="crimson"></SelectedRowStyle>
        <RowStyle HorizontalAlign="Center"></RowStyle>
        <HeaderStyle BackColor="seashell"></HeaderStyle>
        <Columns>
            <asp:BoundField HeaderText="Roll ID" DataField="RollId"/>
            <asp:BoundField HeaderText="Name" DataField="Name"/>
        </Columns>
    </asp:GridView>
</form>
</body>
</html>