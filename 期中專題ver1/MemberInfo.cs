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

namespace 期中專題ver1
{
    public partial class MemberInfo : Form
    {
        string myDBConnectionString = "";
        List<int> SearchIDs = new List<int>(); //進階搜尋的結果
        int intSearchMaritalStatus = 0; //0,1,2

        public MemberInfo()
        {
            InitializeComponent();
        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();
            sqlConnectionString.DataSource = @".";
            sqlConnectionString.InitialCatalog = "Mid-Term Project";
            sqlConnectionString.IntegratedSecurity = true;
            myDBConnectionString = sqlConnectionString.ToString();

            //cbox_searchKey.Items.Add("姓名");
            //cbox_searchKey.Items.Add("電話");
            //cbox_searchKey.Items.Add("Email");
            //cbox_searchKey.Items.Add("地址");
            //cbox_searchKey.SelectedIndex = 0;

            showAllMembers();

            lbl_ID.Text = GlobalVar.EmployeeID;
        }

        private void btn_searchInfo_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" || txt_phone.Text != "")
            {
                SqlConnection connection = new SqlConnection(myDBConnectionString);
                connection.Open();
                string strSQL = "select * from Customers where name like @SearchName or phone = @SearchPhone;";
                SqlCommand command = new SqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@SearchName", "%" + txt_name.Text + "%");
                command.Parameters.AddWithValue("@SearchPhone", txt_phone.Text);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lbl_customerID.Text = reader["id"].ToString();
                    txt_name.Text = reader["name"].ToString();
                    txt_phone.Text = reader["phone"].ToString();
                    txt_email.Text = reader["email"].ToString();
                    txt_address.Text = reader["address"].ToString();
                    dtp_birth.Value = Convert.ToDateTime(reader["birthday"]);
                    chb_marital.Checked = Convert.ToBoolean(reader["marital"]);

                }
                else
                {
                    MessageBox.Show("查無此會員");
                    lbl_customerID.Text = "";
                    txt_name.Clear();
                    txt_phone.Clear();
                    txt_email.Clear();
                    txt_address.Clear();
                    dtp_birth.Value = DateTime.Now;
                    chb_marital.Checked = false;
                }
                reader.Close();
                connection.Close();
            }
            else
            {
                MessageBox.Show("請至少輸入姓名或電話好嗎?");
            }
        }

        private void btn_amendInfo_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lbl_customerID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update Customers set name=@Name, phone=@Phone, address=@Address, email=@Email, birthday=@Birthday, marital=@Marital where id =@SearchID";
                SqlCommand command = new SqlCommand(strSQL, con);
                command.Parameters.AddWithValue("@Name", txt_name.Text);
                command.Parameters.AddWithValue("@Phone", txt_phone.Text);
                command.Parameters.AddWithValue("@Address", txt_address.Text);
                command.Parameters.AddWithValue("@Email", txt_email.Text);
                command.Parameters.AddWithValue("@Birthday", dtp_birth.Value);
                command.Parameters.AddWithValue("@Marital", chb_marital.Checked);
                command.Parameters.AddWithValue("@SearchID", intID);

                int row = command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(String.Format("成功修改{0}筆資料~", row));

            }

        }

        private void btn_addInfo_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" || txt_phone.Text != "")
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into Customers values(@NewName,@NewPhone,@NewAddress,@NewEmail,@NewBirthday,@NewMarital);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt_name.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt_phone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt_address.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txt_email.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp_birth.Value);
                cmd.Parameters.AddWithValue("@NewMarital", chb_marital.Checked);

                int row = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(String.Format("成功新增{0}筆資料~", row));

            }
            else
            {
                MessageBox.Show("請至少輸入姓名與電話好嗎?");

            }
        }

        private void btn_deleteInfo_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lbl_customerID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from Customers where id = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int row = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(String.Format("成功刪除{0}筆資料~", row));
                txt_address.Clear();
                txt_email.Clear();
                txt_name.Clear();
                txt_phone.Clear();
                chb_marital.Checked = false;
                dtp_birth.Value = DateTime.Now;

            }

        }

        private void btn_clearField_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {

        }

        private void radio_all_CheckedChanged(object sender, EventArgs e)
        {
            intSearchMaritalStatus = 0;
        }

        private void radio_married_CheckedChanged(object sender, EventArgs e)
        {
            intSearchMaritalStatus = 1;
        }

        private void radio_single_CheckedChanged(object sender, EventArgs e)
        {
            intSearchMaritalStatus = 2;
        }

        private void btn_advSearch_Click(object sender, EventArgs e)
        {
            


            

        }

        private void dgv_memberInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgv_memberInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);

                if (isID)
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "select * from Customers where id = @SearchID;";  //SearchName為參數，須加上@符號
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lbl_customerID.Text = reader["id"].ToString();
                        txt_name.Text = reader["name"].ToString();
                        txt_phone.Text = reader["phone"].ToString();
                        txt_email.Text = reader["email"].ToString();
                        txt_address.Text = reader["address"].ToString();                        
                        dtp_birth.Value = Convert.ToDateTime(reader["birthday"]);
                        chb_marital.Checked = Convert.ToBoolean(reader["marital"]);
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        clearField();
                    }

                    reader.Close();
                    con.Close();

                }
            }
        }
        void showAllMembers()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from Customers";  //可修改此行SQL語法以達到客製化欄位的效果
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows) //只要有reader都能用DataGridView
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgv_memberInfo.DataSource = dataTable;

            }
            reader.Close();
            con.Close();
        }

        void clearField()
        {
            lbl_customerID.Text = "";
            txt_name.Clear();
            txt_phone.Clear();
            txt_email.Clear();
            txt_address.Clear();
            dtp_birth.Value = DateTime.Now;
            chb_marital.Checked = false;
        }
    }
}
