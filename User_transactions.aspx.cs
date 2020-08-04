using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Transactions_track
{
    public partial class Fund_Transfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            get_transactions();
        }

        public void get_transactions()
        {
            string connectionString = "Data Source=MADHUMITHA-PC;Initial Catalog=User_Transactions; Integrated Security=true;";
            DataTable dsEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select top 5 * from transactions  ORDER BY Transactions_Id DESC", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter datafdb = new SqlDataAdapter(cmd);
                datafdb.Fill(dsEmployee);

                Transactions_grid.DataSource = dsEmployee;
                Transactions_grid.DataBind();
               
            }

        }

        protected void btn_fundtransfer_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_fund_transfer.aspx");
        }
    }
}