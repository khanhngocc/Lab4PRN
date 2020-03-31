<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Entry.aspx.cs" Inherits="Lab4PRN.View.Entry" %>

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
</head>
<body>
    <form id="form1" runat="server">
        <div class="container col-4 agile_block">

            <div class="jumbotron">
                <h1>Booking Flight <i class="fa fa-plane" aria-hidden="true"></i></h1>
                <p>Enjoy the trip</p>
            </div>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="UserName:"></asp:Label>
                <asp:TextBox ID="txtuser" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="PassWord"></asp:Label>
                <asp:TextBox ID="txtpass" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <asp:LinkButton ID="linkSignUp" runat="server" OnClick="linkSignUp_Click">Sign up <i class="fa fa-arrow-right" aria-hidden="true"></i>
            </asp:LinkButton>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" CssClass="btn btn-primary" />
            <br />
            <br />
            <asp:Label ID="lb_message" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
