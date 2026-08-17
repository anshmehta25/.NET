<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="second.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container mt-5">
    <div class="card">
        <div class="card-header bg-primary text-white">
            <h3>Login</h3>
        </div>

        <div class="card-body">

            <div class="mb-3">
                <label>Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="mb-3">
                <label>Password</label>
                <asp:TextBox ID="txtPassword" runat="server"
                    TextMode="Password"
                    CssClass="form-control"></asp:TextBox>
            </div>

            <asp:Button ID="btnLogin"
                runat="server"
                Text="Login"
                CssClass="btn btn-success"
                OnClick="btnLogin_Click" />

            <br /><br />

            <asp:Label ID="lblMessage"
                runat="server"
                CssClass="text-danger"></asp:Label>

        </div>
    </div>
</div>
<asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile1.xml" />
</asp:Content>