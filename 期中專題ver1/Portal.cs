using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace 期中專題ver1
{
    public partial class Portal : Form
    {
        string myDBConnectionString = "";


        public Portal()
        {
            InitializeComponent();
        }

        private void Portal_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Mid-Term Project";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if(txt_accountNum.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("請輸入帳號密碼");
            }
            else
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from Employees where accountNum = @userAccount and password =@userPassword ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@userAccount", txt_accountNum.Text);
                cmd.Parameters.AddWithValue("@userPassword", txt_password.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    //log in
                    MessageBox.Show("登入成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("幾歲了帳密還打錯ㄏㄏ");
                    //no account
                }

                reader.Close();
                con.Close();
            }
            GlobalVar.EmployeeID = txt_accountNum.Text;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_visitor_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            GlobalVar.visitorID = 0;
            MessageBox.Show("進入訪客模式?", "Question", MessageBoxButtons.YesNo);            
            product.ShowDialog();
        }
    }
}
