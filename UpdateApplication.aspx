<%@ Page Title="Update Application" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateApplication.aspx.cs" Inherits="database.UpdateApplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center; font-weight: bold; font-size: 16px; margin-bottom: 15px;">
        UPDATE LOAN APPLICATION
    </div>
    
    <table class="form-table" style="margin: 0 auto;">
        <tr>
            <td style="text-align: right;">Loan No :</td>
            <td>
                <asp:TextBox ID="txtLoanNo" runat="server" Width="120px"></asp:TextBox>
                <asp:Button ID="btnGetDetails" runat="server" Text="Get Loan Details" OnClick="btnGetDetails_Click" CausesValidation="false" />
            </td>
        </tr>
        <tr>
            <td style="text-align: right;">Saving Account No :</td>
            <td>
                <asp:TextBox ID="txtSavingActNo" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right;">Account Holder Name :</td>
            <td>
                <asp:TextBox ID="txtActHolderName" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right;">Loan Category :</td>
            <td>
                <asp:DropDownList ID="ddlLoanCategory" runat="server" Width="188px">
                    <asp:ListItem Text="Property Loan" Value="Property Loan"></asp:ListItem>
                    <asp:ListItem Text="Personal Loan" Value="Personal Loan"></asp:ListItem>
                    <asp:ListItem Text="Home Loan" Value="Home Loan"></asp:ListItem>
                    <asp:ListItem Text="Vehicle Loan" Value="Vehicle Loan"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align: right;">Loan Type :</td>
            <td>
                <asp:DropDownList ID="ddlLoanType" runat="server" Width="188px">
                    <asp:ListItem Text="Education Loan" Value="Education Loan"></asp:ListItem>
                    <asp:ListItem Text="Gold Loan" Value="Gold Loan"></asp:ListItem>
                    <asp:ListItem Text="Car Loan" Value="Car Loan"></asp:ListItem>
                    <asp:ListItem Text="Business Loan" Value="Business Loan"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align: right;">Loan Issue Date :</td>
            <td>
                <asp:TextBox ID="txtIssueDate" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right;">Loan Amount :</td>
            <td>
                <asp:TextBox ID="txtAmount" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; vertical-align: top;">Current Address :</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Rows="2" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; vertical-align: top;">Loan Remarks :</td>
            <td>
                <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine" Rows="2" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center; padding-top: 10px;">
                <asp:Button ID="btnUpdate" runat="server" Text="Update Application" OnClick="btnUpdate_Click" />
            </td>
        </tr>
    </table>

    <asp:Label ID="lblMsg" runat="server" CssClass="success"></asp:Label>
</asp:Content>
