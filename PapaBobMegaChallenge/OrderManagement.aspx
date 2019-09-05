<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderManagement.aspx.cs" Inherits="PapaBobMegaChallenge.OrderManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="OrderId" HeaderText="ID" />
                <asp:BoundField DataField="Size" HeaderText="Pizza Size" />
                <asp:BoundField DataField="Crust" HeaderText="Crust Type" />
                <asp:BoundField DataField="Extras" HeaderText="Extras" />
                <asp:BoundField DataField="Name" HeaderText="Cust Name" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="Zip" HeaderText="Zip Code" />
                <asp:BoundField DataField="Phone" HeaderText="Phone No." />
                <asp:BoundField DataField="PayType" HeaderText="Pay Method" />
                <asp:BoundField DataField="Price" HeaderText="Cost" />
                <asp:ButtonField ButtonType="Button" Text="Finish Order" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
