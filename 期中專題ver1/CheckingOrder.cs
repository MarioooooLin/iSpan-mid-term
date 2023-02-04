using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題ver1
{
    public partial class CheckingOrder : Form
    {
        string myDBConnectionString = "";
        List<ArrayList> arrayList = new List<ArrayList>();

        public CheckingOrder()
        {
            InitializeComponent();
        }

        private void CheckingOrder_Load(object sender, EventArgs e)
        {
            lbl_employeeID.Text = GlobalVar.EmployeeID;

            //SQL連線字串
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();
            sqlConnectionString.DataSource = @".";
            sqlConnectionString.InitialCatalog = "Mid-Term Project";
            sqlConnectionString.IntegratedSecurity = true;
            myDBConnectionString = sqlConnectionString.ToString();

        }

        private void btn_searchOrder_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" || txt_phone.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from Orders where orderBuyer like @SearchName or orderPhone = @SearchPhone;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName",   txt_name.Text );
                cmd.Parameters.AddWithValue("@SearchPhone", txt_phone.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    MessageBox.Show("查無此訂單");
                    lbl_orderID.Text = "";
                    txt_name.Clear();
                    txt_phone.Clear();
                    lsb_orderList.Text = "";
                    lbl_orderTotal.Text = "";
                }
                while (reader.Read())
                {
                    lbl_orderID.Text = reader["orderNum"].ToString();
                    txt_name.Text = reader["orderBuyer"].ToString();
                    txt_phone.Text = reader["orderPhone"].ToString();
                    string orderProduct = reader["orderProduct"].ToString();
                    //lsb_orderList.Items.Add(reader["orderPorduct"].ToString());  不能直接加reader
                    lsb_orderList.Items.Add(orderProduct);
                    lbl_orderTotal.Text = GlobalVar.OrderPrice + "元";
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入查詢關鍵字");
            }
        }

        private void btn_newOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
            
        }

        private void btn_amendOrder_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelOrder_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lbl_orderID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from Orders where id = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int row = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(String.Format("成功刪除{0}筆訂單~", row));
                txt_address.Clear();
                txt_name.Clear();
                txt_phone.Clear();
                lbl_orderID.Text = "";
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select SUM(itemTotal) from Order1 ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            int totalPrice = reader.GetInt32(0); //有問題
            Console.WriteLine(totalPrice);
            MessageBox.Show(totalPrice.ToString());

            reader.Close();
            con.Close();
        }
    }
}
