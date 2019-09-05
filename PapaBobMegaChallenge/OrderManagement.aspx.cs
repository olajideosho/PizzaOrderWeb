using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobMegaChallenge
{
    public partial class OrderManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = Domain.OrderManagement.DisplayOrder().ToList();

            GridView1.DataSource = db;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridView1.Rows[index].Visible = false;
            var db = Domain.OrderManagement.DisplayOrder().ToList();

            GridView1.DataSource = db;
            GridView1.DataBind();
        }
    }
}