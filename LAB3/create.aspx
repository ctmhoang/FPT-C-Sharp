<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="LAB3.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Course</title>
    <style>
        body {
            font-family: Roboto;
            font-size: 1.7em;
        }
        label {
            display: block;
            margin: 1em 0;
        }
        input, select {
            font-size: 1.3em;
            font-family: inherit
        }
        .full-width {
            width: 100%
        }
    </style>
</head>
<body>
<form runat="server">
    <div>
        <label>
            Code: <asp:TextBox runat="server" ID="txb_code"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Not empty" ControlToValidate="txb_code"></asp:RequiredFieldValidator>
        </label>
        <label>
            Description: <asp:TextBox runat="server" ID="txb_des"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Not empty" ControlToValidate="txb_des"></asp:RequiredFieldValidator>
        </label>
        <label>
            Subject <asp:DropDownList runat="server" ID="ddl_sub"/>
        </label>
        <label>
            Instructor: <asp:DropDownList runat="server" ID="ddl_ins"/>
        </label>
        Students:
        <asp:GridView CssClass="full-width" runat="server" ID="gw_students" EnableViewState="False" BorderColor="peru" BorderWidth="1" CellPadding="3" Font-Names="Roboto" Font-Size="1.2em" AutoGenerateColumns="False" EnablePersistedSelection="True">
            <SelectedRowStyle BackColor="crimson"></SelectedRowStyle>
            <RowStyle HorizontalAlign="Center"></RowStyle>
            <HeaderStyle BackColor="seashell"></HeaderStyle>
            <Columns>
                <asp:TemplateField HeaderText="Roll ID & Name">
                    <ItemTemplate>
                        <p><%#DataBinder.Eval(Container.DataItem,"RollId") + " - " + DataBinder.Eval(Container.DataItem, "Name")%></p>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox runat="server"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button runat="server" ID="btn_submit" Text="Create"  OnClick="btn_submit_OnClick"/>
    </div>
</form>
</body>
</html>