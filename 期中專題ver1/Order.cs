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
using System.Collections;
using System.Text.RegularExpressions;

namespace 期中專題ver1
{
    public partial class Order : Form
    {

        List<int> list_ID = new List<int>();
        List<string> list_Product = new List<string>();
        List<int> list_Price = new List<int>();
        List<string> list_Description = new List<string>();
        List<string> list_Sauce = new List<string>();
        List<string> list_Sugar = new List<string>();
        List<string> list_Size = new List<string>();

        int selectedBowl;
        int selectedProductPrice;
        int selectedTotalPrice;
        string selectedProduct;
        string selectedSugar;
        string selectedSize;
        string selectedSauce;

        /*string Product;
        string Description;
        Int32 Price;*/

        string myDBConnectionString = "";

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Mid-Term Project";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            LoadDB();

            
            //糖水
            list_Sauce.Add("黑糖");
            list_Sauce.Add("煉乳");
            list_Sauce.Add("蜂蜜");
            foreach(string sauce in list_Sauce)
            {
                cbox_sauce.Items.Add(sauce);
            }

            //甜度
            list_Sugar.Add("螞蟻人加爆");
            list_Sugar.Add("正常就好");
            list_Sugar.Add("我糖尿病");
            foreach(string sugar in list_Sugar)
            {
                cbox_sugar.Items.Add(sugar);
            }

            //份量
            list_Size.Add("用臉盆裝");
            list_Size.Add("用碗公裝");
            list_Size.Add("用布丁盒裝");
            foreach(string size in list_Size)
            {
                cbox_size.Items.Add(size);
            }

            //listbox預設值
            txt_bowl.Text = "1";
            cbox_sauce.SelectedIndex = 0;
            cbox_size.SelectedIndex = 0;
            cbox_sugar.SelectedIndex = 0;
            

            txt_phoneNum.ShortcutsEnabled = false;

            lbl_employeeID.Text = GlobalVar.EmployeeID;
        }

        void LoadDB()
        {
            SqlConnection con = new SqlConnection(myDBConnectionString); 
            con.Open();
            string strSQL = "select product, price, description from Products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();          
            
            while (reader.Read())
                {
                    list_Product.Add(Convert.ToString(reader["Product"]).PadRight(10,'　'));
                    list_Price.Add(Convert.ToInt32(reader["Price"]));
                    list_Description.Add(Convert.ToString(reader["Description"]));
                string strProduct = "";
                for (int i = 0; i < list_Product.Count; i++)
                    {                     
                     strProduct = list_Product[i] + "     " + list_Price[i] + "元     " + list_Description[i];                        
                    }
                lsb_product.Items.Add(strProduct);
            }
            
            reader.Close();
            con.Close();
        }

        void countTotalPrice()
        {
            selectedTotalPrice = selectedProductPrice * selectedBowl;
            lbl_totalPrice.Text = selectedTotalPrice.ToString() + "元";

        }

        private void lsb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsb_product.SelectedIndex > -1)
            {
                selectedProduct = list_Product[lsb_product.SelectedIndex];
                selectedProductPrice = list_Price[lsb_product.SelectedIndex];
            }
            lbl_unitPrice.Text = selectedProductPrice.ToString() + "元";
            countTotalPrice();

        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            

            if (txt_buyer.Text != "" && txt_phoneNum.Text != "" && txt_orderNum.Text != "")
            {
                //電話檢查
                string phoneNum = txt_phoneNum.Text;
                bool telcheck = Regex.IsMatch(phoneNum, @"^09[0-9]{8}$");
                if (telcheck)
                {
                    ArrayList orderItemInfo = new ArrayList();
                    orderItemInfo.Add(selectedProduct);
                    orderItemInfo.Add(selectedProductPrice);
                    orderItemInfo.Add(selectedBowl);
                    orderItemInfo.Add(selectedTotalPrice);
                    orderItemInfo.Add(selectedSauce);
                    orderItemInfo.Add(selectedSugar);
                    orderItemInfo.Add(selectedSize);

                    //methods();
                    check();
                    GlobalVar.OrderItemList.Add(orderItemInfo);
                    MessageBox.Show("已新增此商品，記得去確認送單");
                }
                else
                {
                    MessageBox.Show("請輸入正確電話號碼");
                }
            }
            else
            {
                MessageBox.Show("請輸入訂單號,訂購人,電話");
            }
            
        }

        private void btn_checkOrder_Click(object sender, EventArgs e)
        {
            TempOrder tempOrder = new TempOrder();
            tempOrder.ShowDialog();
        }

        private void txt_bowl_TextChanged(object sender, EventArgs e)
        {
            if (txt_bowl.Text.Length > 0)
            {
                selectedBowl = Convert.ToInt32(txt_bowl.Text);
                countTotalPrice();
            }
        }

        private void cbox_sauce_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSauce = list_Sauce[cbox_sauce.SelectedIndex];
        }

        private void cbox_sugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSugar = list_Sugar[cbox_sugar.SelectedIndex];                                
        }

        private void cbox_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSize = list_Size[cbox_size.SelectedIndex];
        }

        public void check()
        {
            if (Convert.ToInt32(txt_bowl.Text) <= 0)
            {
                MessageBox.Show("你這碗數是來亂的?");
            }
        }

        private void txt_orderNum_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.OrderNum = txt_orderNum.Text;
        }

        private void txt_buyer_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.BuyerName = txt_buyer.Text;
        }

        private void txt_phoneNum_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.BuyerPhone = txt_phoneNum.Text;
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.BuyerAddress = txt_address.Text;
        }
    }
}
