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
    public partial class ProductManagement : Form
    {
        string myDBConnectionString = "";
        public int productID = 0; //0為新增商品
        
        string img_direction = @"images\";
        string img_name = "";
        bool isAmendedImg = false;

        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Mid-Term Project";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            if(productID == 0)
            {
                gb_addNew.Visible = true;
                gb_amendProduct.Visible = false;
            }
            else
            {
                gb_addNew.Visible = false;
                gb_amendProduct.Visible = true;
                showProductDetail();
            }

            lbl_employeeID.Text = GlobalVar.EmployeeID;
        }

        void showProductDetail()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select * from Products where id = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", productID);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                lbl_ID.Text = reader["id"].ToString();
                txt_product.Text = reader["product"].ToString();
                txt_price.Text = reader["price"].ToString();
                txt_description.Text = reader["description"].ToString();
                img_name = reader["image"].ToString();
                pb_product.Image = Image.FromFile(img_direction + img_name);
                i += 1;
            }
            Console.WriteLine("顯示" + i + "筆資料");
            reader.Close();
            con.Close();
        }



        private void btn_clearField_Click(object sender, EventArgs e)
        {
            lbl_ID.Text = "";
            txt_description.Clear();
            txt_price.Clear();
            txt_product.Clear();
            pb_product.Image = null;
        }


        private void btn_saveNew_Click(object sender, EventArgs e)
        {
            if((txt_description.Text != "") && (txt_price.Text != "") && (txt_product.Text != "") && (pb_product != null))
            {
                if (isAmendedImg)
                {
                    pb_product.Image.Save(img_direction + img_name);
                    isAmendedImg = false;
                }
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "insert into Products values(@NewName, @NewPrice, @NewDescription, @NewImageName);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", productID);
                cmd.Parameters.AddWithValue("@NewName", txt_product.Text);
                int newPrice = 0;
                Int32.TryParse(txt_price.Text, out newPrice);
                cmd.Parameters.AddWithValue("@NewPrice", newPrice);
                cmd.Parameters.AddWithValue("@NewDescription", txt_description.Text);
                cmd.Parameters.AddWithValue("@NewImageName", img_name);
                int row = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("已儲存新增的" + row + "筆資料~");

            }
            else
            {
                MessageBox.Show("東西都不填是要新增三X?");

            }
        }

        private void btn_pickPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pb_product.Image = Image.FromFile(fileDialog.FileName);
                string fileExtension = System.IO.Path.GetExtension(fileDialog.SafeFileName);
                Random randNum = new Random();
                img_name = DateTime.Now.ToString("yyyMMdd") + randNum.Next(1000, 10000).ToString() + fileExtension;
                isAmendedImg = true;
            }

        }

        private void btn_saveAmend_Click(object sender, EventArgs e)
        {
            if ((txt_description.Text != "") && (txt_price.Text != "") && (txt_product.Text != "") && (pb_product != null))
            {
                if (isAmendedImg)
                {
                    pb_product.Image.Save(img_direction + img_name);
                    isAmendedImg=false;
                }
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "update Products set product=@NewName, price=@NewPrice, description=@NewDescription, image=@NewImageName where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", productID);
                cmd.Parameters.AddWithValue("@NewName", txt_product);
                int intPrice = 0;
                Int32.TryParse(txt_price.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewDescription", txt_description.Text);
                cmd.Parameters.AddWithValue("@NewImageName", img_name);
                int row = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料" + row + "筆新增成功~");

            }
            else
            {
                MessageBox.Show("請完成所有欄位");
            }
            
                
        }

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lbl_ID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "delete from Products where id = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int row = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(String.Format("成功刪除{0}筆資料~", row));
                txt_product.Clear();
                txt_price.Clear();
                txt_description.Clear();
                lbl_ID.Text = "";
                pb_product.Image = null;
            }
        }
    }
}
