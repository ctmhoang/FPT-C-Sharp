<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="LAB3.create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Course</title>
    <style>
        body {
            font-family: Roboto;
            font-size: 1.7em;
        }
    </style>
</head>
<body>
    <form runat="server">
        <div>
            <label>
                Code: <asp:TextBox runat="server" ID="txb_code"></asp:TextBox>
            </label>
            <label>
                Description: <asp:TextBox runat="server" ID="txb_des"></asp:TextBox>
            </label>
            <label>
                Subject <asp:DropDownList runat="server" ID="ddl_sub"/>
            </label>
            <label>
                Instructor: <asp:DropDownList runat="server" ID="ddl_ins"/>
            </label>
            Students:
            <asp:DataGrid runat="server">

            </asp:DataGrid>
        </div>
    </form>
</body>
</html>
