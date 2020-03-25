<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Book.aspx.cs" Inherits="Lab4PRN.View.details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<html lang="en">
<head runat="server">
    <title>Bootstrap Example</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

    <style>
        body {
            background-color: whitesmoke;
            color: dodgerblue;
        }

       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container col-11">
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="text-danger"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label" CssClass="text-success"></asp:Label>
           
        </div>
    </form>
</body>
</html>
