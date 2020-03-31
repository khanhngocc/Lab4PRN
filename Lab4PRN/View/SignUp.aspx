<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Lab4PRN.View.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<html lang="en">
<head>
    
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css"
        integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <style>
        body {
            background-color: whitesmoke;
            color: dodgerblue;
        }

        .agile_block {
            margin-top: 70px;
        }
    </style>
    <body>
        <form id="form1" runat="server">
            <div class="container col-4 agile_block">
                <asp:LinkButton ID="linkEntry" runat="server" OnClick="linkEntry_Click"><i class="fa fa-arrow-left" aria-hidden="true"></i> Back to Login</asp:LinkButton>
                <br />
                <br />
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="UserName:"></asp:Label>
                    <asp:TextBox ID="txt_user" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="PassWord"></asp:Label>
                    <asp:TextBox ID="txt_pass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="First Name:"></asp:Label>
                    <asp:TextBox ID="txt_fname" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Last Name:"></asp:Label>
                    <asp:TextBox ID="txt_lname" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="Dob:"></asp:Label>
                    <asp:Calendar ID="calendar" runat="server"></asp:Calendar>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label6" runat="server" Text="Email:"></asp:Label>
                    <asp:TextBox ID="txt_email" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label7" runat="server" Text="Phone:"></asp:Label>
                    <asp:TextBox ID="txt_phone" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                 <br />
                <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" CssClass="btn btn-primary" OnClick="btnSignUp_Click" />
                <br />
                <br />
                <asp:Label ID="lb_message" runat="server" CssClass="text-success"></asp:Label>
            </div>
        </form>
    </body>
</html>
