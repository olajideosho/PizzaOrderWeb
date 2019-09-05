<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobMegaChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        
        <h1>Papa Bob's Pizza</h1>
        <div class="alert-danger" role="alert">
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
        <p class="auto-style1">Pizza to code by</p>
        <br />
        <asp:Button ID="orderManageButton" Text="Order Management Page" runat="server" CssClass="btn btn-lg btn-secondary" OnClick="orderManageButton_Click"/>
        <br />
        <hr />
        <div class="form-group">
            <label>
                <strong>Size:</strong>
                <asp:DropDownList ID="sizeDropDown" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Small (12 inch - $12)" Value="small"></asp:ListItem>
                    <asp:ListItem Text="Medium (14 inch - $14)" Value="medium"></asp:ListItem>
                    <asp:ListItem Text="Large (16 inch - $16)" Value="large"></asp:ListItem>
                </asp:DropDownList>
            </label>
            <br />
            <label>
                Crust:
                <asp:DropDownList ID="crustDropDown" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Regular" Value="regular"></asp:ListItem>
                    <asp:ListItem Text="Thin" Value="thin"></asp:ListItem>
                    <asp:ListItem Text="Thick" Value="thick"></asp:ListItem>
                </asp:DropDownList>
            </label>
        </div>
        <div class="form-check">
            <asp:CheckBox ID="sausageCheckBox" runat="server" CssClass="form-check-input"/>  <strong>Sausage</strong><br />
            <asp:CheckBox ID="pepperoniCheckBox" runat="server" CssClass="form-check-input"/>  <strong>Pepperoni</strong><br />
            <asp:CheckBox ID="onionsCheckBox" runat="server" CssClass="form-check-input"/>  <strong>Onions</strong><br />
            <asp:CheckBox ID="gpCheckBox" runat="server" CssClass="form-check-input"/>  <strong>Green Pepper</strong><br />
        </div>
        <h2>Deliver To: </h2>
            <strong>Name:  
            </strong>  
            <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
            <strong>Address:  
            </strong>  
            <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
            <strong>Zip:</strong>  
            <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
            <strong>Phone:  
            </strong>  
            <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <h2>Payment: </h2>
        <div class="form-check">
                <asp:RadioButton ID="cashRadio" runat="server" CssClass="form-check-input" GroupName="pay"/><strong>Cash
        </strong>
        </div>
        <div class="form-check">
                <asp:RadioButton ID="creditRadio" runat="server" CssClass="form-check-input" GroupName="pay"/><strong>Credit
        </strong>
        </div>
        <br />
        <asp:Button ID="orderButton" runat="server" CssClass="btn btn-lg btn-primary" Text="Order" OnClick="orderButton_Click"/>
        <br />
        <h2>Total Cost: <asp:Label ID="totalLabel" runat="server"></asp:Label></h2>
    </div>
    </form>
</body>
</html>
