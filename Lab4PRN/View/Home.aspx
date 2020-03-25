<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Lab4PRN.View.Home" %>

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
     <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css"
        integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <style>
        body {
            background-color: whitesmoke;
            color: dodgerblue;
        }

        .brand_footer {
            margin: 30px 0 0;
            padding: 20px;
            text-align: center;
        }

        .background_header{
            background-color:#e9ecef;
            padding:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container col-11">
            <ul class="nav justify-content-end background_header">
                <li class="nav-item">
                   
                    <asp:LinkButton ID="linkMyTicket" runat="server" CssClass="nav-link" OnClick="linkMyTicket_Click"><i class="fa fa-ticket" aria-hidden="true"></i> My Ticket</asp:LinkButton>
                </li>
                <li class="nav-item">
                    
                    <asp:LinkButton ID="linkPayment" runat="server" CssClass="nav-link" OnClick="linkPayment_Click"><i class="fa fa-money" aria-hidden="true"></i> Payment</asp:LinkButton>
                </li>
                <li class="nav-item">
                    <asp:Label ID="lb_fullname" runat="server" CssClass="nav-link"></asp:Label>
                </li>
                <li class="nav-item">
                    <asp:LinkButton ID="linkLogout" runat="server"  CssClass="nav-link" OnClick="linkLogout_Click">LogOut</asp:LinkButton>
                </li>
            </ul>
            <br />
            <br />
            <h3>Finding Ticket</h3>

            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Depart_Date"></asp:Label>

            <br />

            <asp:Calendar ID="calendar_depart" runat="server"></asp:Calendar>
            <br />
            &nbsp;<asp:Label ID="Label3" runat="server" Text="Arrival Date"></asp:Label>
            <br />
            <asp:Calendar ID="calendar_arrival" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Depart Country"></asp:Label>
            &nbsp;
            &nbsp;
            <asp:TextBox ID="txt_depart_country" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Arrival Country"></asp:Label>
            &nbsp;
            &nbsp;
            <asp:TextBox ID="txt_arrival_country" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
            <br />
            <br />
            <asp:GridView ID="tableTicket" runat="server" EmptyDataText="No data found!"
                CssClass="auto-style2" Width="1057px" AutoGenerateColumns="False"
                ViewStateMode="Enabled" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" EnableModelValidation="True" ForeColor="Black">
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
                    <asp:BoundField HeaderText="airplane_name" DataField="airplane_name" />
                    <asp:HyperLinkField HeaderText="Booking" Text="Book" DataNavigateUrlFormatString="Book.aspx?fid={0}&fname={1}&aname={2}"
                        DataNavigateUrlFields="id,flight_name,airplane_name" />

                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            </asp:GridView>
            <div class="jumbotron brand_footer">
                <p class="agile_footer_text"><i class="fa fa-copyright" aria-hidden="true"></i>2020: bookinginternalflight.com</p>
            </div>
        </div>
    </form>
</body>
</html>
