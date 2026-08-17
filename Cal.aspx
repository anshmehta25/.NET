<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cal.aspx.cs" Inherits="second.Cal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar Example</title>
</head>

<body>
    <form id="form1" runat="server">

        <h2>Current Day and Selected Date</h2>

        <asp:Label
            ID="lblCurrentDay"
            runat="server">
        </asp:Label>

        <br /><br />

        <asp:Calendar
            ID="Calendar1"
            runat="server"
            OnSelectionChanged="Calendar1_SelectionChanged">
        </asp:Calendar>

        <br />

        <asp:Label
            ID="lblSelectedDate"
            runat="server">
        </asp:Label>

    </form>
</body>
</html>