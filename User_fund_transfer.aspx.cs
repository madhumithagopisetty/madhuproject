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
    public partial class User_fund_transfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            get_customer_details();
        }

        
        public void get_customer_details()
        {
            string connectionString = "Data Source=MADHUMITHA-PC;Initial Catalog=User_Transactions; Integrated Security=true;";
            DataTable dsEmployee = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select top 1 * from transactions  ORDER BY Transactions_Id DESC", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter datafdb = new SqlDataAdapter(cmd);
                datafdb.Fill(dsEmployee);
                foreach (DataRow row in dsEmployee.Rows)
                {
                    lblcustomername.Text = row["Customer_name"].ToString();
                    lblaccountnumber.Text = row["Account_number"].ToString();
                    lblaccountbalance.Text = row["Account_balance"].ToString();

                }
            }
        }

        public void update_transactions()
        {
            string connectionString = "Data Source=MADHUMITHA-PC;Initial Catalog=User_Transactions; Integrated Security=true;";
            DataTable dsEmployee = new DataTable();
            double updated_balance = Convert.ToDouble(lblaccountbalance.Text)-Convert.ToDouble(txtfundtransfering.Text);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into transactions values('" + lblaccountnumber.Text + "', '" + lblcustomername.Text+ "',"+ updated_balance+ ", GETDATE(), -"+Convert.ToDouble(txtfundtransfering.Text)+")", con);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        protected void btnfundtransfer_Click(object sender, EventArgs e)
        {
            update_transactions();
            Response.Redirect("~/User_transactions.aspx");
        }
    }
}