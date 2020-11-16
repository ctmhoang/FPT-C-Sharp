<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="LAB3.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Student</title>
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
            margin: 0.3em 0;}

        .full-width { width: 100% }

        .btn { font-size: inherit; }

    </style>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <label>
            Name: <asp:TextBox runat="server" ID="txb_name"></asp:TextBox>
        </label>
        <label>
            Roll ID: <asp:TextBox runat="server" ID="txb_Id"></asp:TextBox>
        </label>

        <asp:Button runat="server" Text="Search" ID="btn_ser" OnClick="btn_ser_OnClick"/>
        <asp:Button runat="server" Text="Add" ID="btn_add" OnClick="btn_add_OnClick"/>
        <asp:GridView CssClass="full-width" runat="server" ID="gw_students" BorderColor="peru" BorderWidth="1" CellPadding="3" Font-Names="Roboto" Font-Size="1.2em" AutoGenerateColumns="False" EnablePersistedSelection="True" EnableViewState="False">
            <SelectedRowStyle BackColor="crimson"></SelectedRowStyle>
            <RowStyle HorizontalAlign="Center"></RowStyle>
            <HeaderStyle BackColor="seashell"></HeaderStyle>
            <Columns>
                <asp:BoundField HeaderText="Roll ID" DataField="RollId"/>
                <asp:BoundField HeaderText="Name" DataField="Name"/>
                <asp:TemplateField  HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox runat="server"
                                      ID="cb_checked"
                                      Checked="<%# IsSelected((StudentWrapper) Container.DataItem)%>"/>
                    </ItemTemplate>
                </asp:TemplateField>                
            </Columns>
        </asp:GridView>
    </div>
</form>
</body>
</html>