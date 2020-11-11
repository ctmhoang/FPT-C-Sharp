<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LAB3.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show all Courses</title>
    <style>
        body {
            font-family: Roboto;
            font-size: 1.7em;
        }
        .container {
            display: flex;
            flex-flow: row wrap;
            justify-content: space-between;
            align-items: stretch;
            margin: 0.3em 0;
        }
        .text { color: lightseagreen; }
        .full-width {
            width: 100%
        }

        .btn {
            font-size: inherit;
        }

    </style>
</head>
<body>
<form id="form1" runat="server">
    <div class="container">
        <asp:Label runat="server" ID="lb_tot" CssClass="text"/>
        <asp:Button runat="server" ID="btn_create" PostBackUrl="create.aspx" Text="Create new Course" CssClass="btn"/>
    </div>
    <asp:GridView CssClass="full-width" runat="server" EnableViewState="False" ID="dg_display" BorderColor="peru" BorderWidth="1" CellPadding="3" Font-Names="Roboto" Font-Size="1.2em" AutoGenerateColumns="False" EnablePersistedSelection="True">
        <SelectedRowStyle BackColor="crimson"></SelectedRowStyle>
        <RowStyle HorizontalAlign="Center"></RowStyle>
        <HeaderStyle BackColor="seashell"></HeaderStyle>
        <Columns>
            <asp:HyperLinkField HeaderText="Code" DataNavigateUrlFormatString="view.aspx?cid={0}" DataNavigateUrlFields="Id" DataTextField="Code"/>
            <asp:BoundField HeaderText="Description" DataField="Description"/>
            <asp:BoundField HeaderText="Subject" DataField="Sub"/>
            <asp:BoundField HeaderText="Instructor" DataField="Ins"/>
        </Columns>
    </asp:GridView>
</form>
</body>
</html>