    <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="second.Registration" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt-5">

        <div class="card">

            <div class="card-header bg-primary text-white">
                <h3>Registration Form</h3>
            </div>

            <div class="card-body">

                <div class="mb-3">
                    <label>Name</label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <label>Email</label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <label>Password</label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="mb-3">
                    <label>Gender</label><br />

                    <asp:RadioButton ID="rbMale" runat="server" GroupName="Gender" Text="Male" />
                    <asp:RadioButton ID="rbFemale" runat="server" GroupName="Gender" Text="Female" />
                </div>

                <div class="mb-3">
                    <label>Course</label>

                    <asp:DropDownList ID="ddlCourse" runat="server" CssClass="form-select">
                        <asp:ListItem>BCA</asp:ListItem>
                        <asp:ListItem>B.Sc</asp:ListItem>
                        <asp:ListItem>B.Com</asp:ListItem>
                        <asp:ListItem>MCA</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="mb-3">
                    <label>Address</label>

                    <asp:TextBox ID="txtAddress" runat="server"
                        TextMode="MultiLine"
                        CssClass="form-control"></asp:TextBox>
                </div>

                <asp:Button ID="btnRegister"
                    runat="server"
                    Text="Register"
                    CssClass="btn btn-success"
                    OnClick="btnRegister_Click" />

                <br /><br />

                <asp:Label ID="lblMessage"
                    runat="server"
                    CssClass="text-success"></asp:Label>

            </div>

        </div>

    </div>

    </asp:Content>