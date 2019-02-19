<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JobTest.aspx.cs" Inherits="JobTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="SortingType" runat="server">
                <asp:ListItem Value ="Bubble Sort"></asp:ListItem>
                <asp:ListItem Value = "List Sort"></asp:ListItem>
            </asp:DropDownList>

            <asp:TextBox ID="Values" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID ="txtVld" runat ="server" ErrorMessage ="Please enter a Value" ControlToValidate = "Values"/>
            <asp:RegularExpressionValidator ID ="vldTxt" runat ="server" ErrorMessage ="Your Values are not correct" ValidationExpression = "[1-9+\,\S+]{1,500}" ControlToValidate ="Values" ForeColor ="Red"/>


            <br />
            <asp:Button ID="Sort" runat="server" Text="Sort" onClick = "Check"/>
            <br />
            
            <asp:ListBox ID = "results" runat ="server" Height ="240px" Width ="240px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
