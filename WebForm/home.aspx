<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebForm.home" %>
<%@ Import Namespace="System.ComponentModel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>My Home Page</h1>
        <div style ="display: flex; flex-flow: row wrap">
            <div style="flex: 1">
                <asp:HyperLink NavigateUrl="viewcart.aspx" runat="server" Text="View Cart" EnableViewState="False"/>
            </div>
            <div style="flex: 4">
                <asp:DropDownList runat="server" ID="ddl_cat_sel" AutoPostBack="True" OnSelectedIndexChanged="ddl_cat_sel_OnSelectedIndexChanged"/>
                <asp:DataGrid runat="server" ID="dg_product_display" EnableViewState="False" AutoGenerateColumns="False" OnItemCommand="dg_product_display_OnItemCommand">
                    <Columns>
                        <asp:BoundColumn DataField="pId" Visible="False"/>
                        <asp:BoundColumn DataField="Name" HeaderText="Product Name" ReadOnly="True"/>
                        <asp:BoundColumn DataField="Price" HeaderText="Unit Price"/>
                        <asp:ButtonColumn HeaderText="Action" Text="Delete" CommandName="Delete"/>
                        <asp:ButtonColumn HeaderText="Add to cart" Text="Add" ButtonType="PushButton" CommandName="Add">
                            <ItemStyle HorizontalAlign="Center"/>
                        </asp:ButtonColumn>
                    </Columns>
                </asp:DataGrid>
                
                <asp:Repeater runat="server" ID="pager">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" OnCommand="SetCurrentPage" CommandArgument="<%#Container.DataItem%>" Text="<%#Container.DataItem%>"/>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
