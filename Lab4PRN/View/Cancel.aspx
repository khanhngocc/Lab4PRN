<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cancel.aspx.cs" Inherits="Lab4PRN.View.Cancel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<html lang="en">
<head>
    <title>Bootstrap Example</title>
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

        .background_header {
            background-color: #e9ecef;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container col-11">
            <asp:LinkButton ID="linkPayment" runat="server" CssClass="background_header" OnClick="linkPayment_Click"><i class="fa fa-money" aria-hidden="true"></i> Payment</asp:LinkButton>
             <p>
                 &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="text-success"></asp:Label>
            </p>
        </div>
       
    </form>
</body>
</html>
