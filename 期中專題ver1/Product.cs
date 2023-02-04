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
    public partial class Product : Form
    {
        string myDBConnectionString = "";
        List<int>listPrice=new List<int>();
        List<string>listProduct=new List<string>();
        List<int>listID=new List<int>();
        


        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Mid-Term Project";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            LoadDB();

            //訪客模式
            //if (GlobalVar.visitorID == 0)
            //{
              //  btn_addNew.Visible = false;
                //btn_reload.Visible = false;
            //}

            lbl_ID.Text = GlobalVar.EmployeeID;
        }

        void LoadDB()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select top 100 * from Products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            string img_direction = @"images\"; //圖檔目錄;待匯入圖片,確認路徑
            string img_name = ""; //圖檔名稱;
            int i = 0;  //檢查用

            while (reader.Read())
            {
                listID.Add((int)reader["id"]);
                listProduct.Add(reader["product"].ToString());
                listPrice.Add((int)reader["price"]);
                img_name = reader["image"].ToString();
                //imgl_productPhoto.Images.Add(Image.FromFile(img_direction+"mocha"+".png"));
                imgl_productPhoto.Images.Add(Image.FromFile(img_direction + img_name));
                i += 1;  //檢查用
            }
            Console.WriteLine("讀取{0}筆資料", i);  //檢查用
            reader.Close();
            con.Close();
        }

        private void btn_photoMode_Click(object sender, EventArgs e)
        {
            showPhotoMode();
        }

        void showPhotoMode()
        {
            lsv_product.Clear();
            lsv_product.View = View.LargeIcon;
            imgl_productPhoto.ImageSize = new Size(150, 150);
            lsv_product.LargeImageList = imgl_productPhoto;
            lsv_product.SmallImageList = imgl_productPhoto;

            for (int i = 0; i < imgl_productPhoto.Images.Count; i += 1)
            {
                ListViewItem product = new ListViewItem();
                product.ImageIndex = i;
                product.Font = new Font("細明體", 10, FontStyle.Bold);
                product.Text = listProduct[i] + " " + listPrice[i] + "元";
                product.Tag = listID[i];
                lsv_product.Items.Add(product);

            }

        }

        private void btn_listMode_Click(object sender, EventArgs e)
        {
            showListMode();
        }

        void showListMode()
        {
            lsv_product.Clear();
            lsv_product.LargeImageList = null;
            lsv_product.SmallImageList = null;
            lsv_product.View = View.Details;
            lsv_product.Columns.Add("id", 100);
            lsv_product.Columns.Add("商品名稱", 200);
            lsv_product.Columns.Add("商品價格", 80);
            lsv_product.FullRowSelect = true;
            lsv_product.GridLines = true;

            for (int i = 0; i < listID.Count; i += 1)
            {
                ListViewItem product = new ListViewItem();
                product.Font = new Font("細明體", 10, FontStyle.Bold);
                product.Text = listID[i].ToString();
                product.SubItems.Add(listProduct[i]);
                product.SubItems.Add(listPrice[i].ToString());
                product.Tag = listID[i];

                lsv_product.Items.Add(product);
            }
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.ShowDialog();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            listID.Clear();
            listPrice.Clear();
            lsv_product.Clear();
            imgl_productPhoto.Images.Clear();
            LoadDB();

            if(lsv_product.View == View.Details)
            {
                showListMode();
            }
            else
            {
                showPhotoMode();
            }
        }

        private void lsv_product_ItemActivate(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.productID = Convert.ToInt32(lsv_product.SelectedItems[0].Tag);
            productManagement.ShowDialog();
            
        }
    }
}
