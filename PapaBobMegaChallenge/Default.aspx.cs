using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobMegaChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        double total = 0.0;
        string result = "";
        string topping = "";
        long number = 0;
        string pay = "";
        string price = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void orderButton_Click(object sender, EventArgs e)
        {
            
            if (sizeDropDown.SelectedValue == "small")
                total += 12.0;
            else if(sizeDropDown.SelectedValue == "medium")
                total += 14.0;
            else if(sizeDropDown.SelectedValue == "large")
                total += 16.0;

            if (crustDropDown.SelectedValue == "thick")
                total += 2.0;

            if (sausageCheckBox.Checked)
            {
                total += 2.0;
                topping += "S";
            }


            if (pepperoniCheckBox.Checked)
            {
                total += 1.5;
                topping += "P";
            }

            if(onionsCheckBox.Checked)
            {
                total += 1.5;
                topping += "O";
            }

            if(gpCheckBox.Checked)
            {
                total += 1.0;
                topping = "G";
            }

            if (nameTextBox.Text == "")
            {
                resultLabel.Text = "<p>Please Enter a Name</p>";
                return;
            }

            if(addressTextBox.Text == "")
            {
                resultLabel.Text = "<p>Please Enter an Address</p>";
                return;
            }

            if (zipTextBox.Text == "")
            {
                resultLabel.Text = "<p>Please Enter a valid Zip Code</p>";
                return;
            }

            if (phoneTextBox.Text == "" || (phoneTextBox.Text.Length > 13) || !(long.TryParse(phoneTextBox.Text, out number)) )
            {
                resultLabel.Text = "<p>Please Enter a valid Phone Number</p>";
                return;
            }

            if(cashRadio.Checked)
            {
                pay = "cash";
            }
            else if(creditRadio.Checked)
            {
                pay = "credit";
            }
            else
            {
                resultLabel.Text = "<p>Please Select a payment method</p>";
                return;
            }

            price = "$" + total.ToString();


            try
            {
                var newOrder = new DTO.Order();

                newOrder.Size = sizeDropDown.SelectedValue;
                newOrder.Crust = crustDropDown.SelectedValue;
                newOrder.Extras = topping;
                newOrder.Name = nameTextBox.Text;
                newOrder.Address = addressTextBox.Text;
                newOrder.Zip = zipTextBox.Text;
                newOrder.Phone = phoneTextBox.Text;
                newOrder.PayType = pay;
                newOrder.Price = price;

                Domain.OrderManagement.AddOrder(newOrder);

                Server.Transfer("Success.aspx");

            }
            catch(Exception ex)
            {
                resultLabel.Text = "<p>There was an error Processing your Request. Please Try Later.</p>" +
                    "<p>Error: " + ex.Message + "</p>";
                return;
            }
            
        }

        protected void orderManageButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("OrderManagement.aspx");
        }
    }
}