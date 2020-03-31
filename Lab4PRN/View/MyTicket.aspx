<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyTicket.aspx.cs" Inherits="Lab4PRN.View.MyTicket" %>

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

       
        .background_header {
            background-color: #e9ecef;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container col-11">
            <asp:LinkButton ID="homePage" runat="server" OnClick="homePage_Click" CssClass="background_header"><i class="fa fa-home" aria-hidden="true"></i> Home</asp:LinkButton>
            <br />
            <br />
            <asp:Label ID="lb_message" runat="server"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="gridViewTicketBooked" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" EnableModelValidation="True" ForeColor="Black" AutoGenerateColumns="False" EmptyDataText="None result">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="depart_time" DataField="depart_time" />
                    <asp:BoundField HeaderText="depart_date" DataField="depart_date" />
                    <asp:BoundField HeaderText="arrival_time" DataField="arrival_time" />
                    <asp:BoundField HeaderText="arrival_date" DataField="arrival_date" />
                    <asp:BoundField HeaderText="depart_country" DataField="depart_country" />
                    <asp:BoundField HeaderText="arrival_country" DataField="arrival_country" />
                    <asp:BoundField HeaderText="direction" DataField="direction" />
                    <asp:BoundField HeaderText="type" DataField="type" />
                    <asp:BoundField HeaderText="price" DataField="price" />
                    <asp:BoundField HeaderText="no_seat" DataField="no_seat" />
                    <asp:BoundField HeaderText="flight_name" DataField="flight_name" />
                    <asp:BoundField HeaderText="airway_station" DataField="airway_station" />
                    <asp:BoundField HeaderText="airplane_name" DataField="airplane_name" />
                    <asp:BoundField HeaderText="dateTime_booked" DataField="dateTime_booked" />
                  
                </Columns>
            </asp:GridView>
           
        </div>
    </form>
</body>
</html>
