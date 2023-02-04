using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace 期中專題ver1
{
    public partial class TempOrder : Form
    {
        List<string> list_payMethod = new List<string>();
        string myDBConnection = "";
        int OrderTotalPrice = 0;
        List<string> tempOrder = new List<string>();        

        public TempOrder()
        {
            InitializeComponent();
        }

        private void TempOrder_Load(object sender, EventArgs e)
        {
            //預設
            radio_forHere.Checked = true;
            //付款方式
            list_payMethod.Add("魔法小卡");
            list_payMethod.Add("比爾蓋茲的擦手紙");
            list_payMethod.Add("腎");
            list_payMethod.Add("眼角膜");

            foreach (string payMethod in list_payMethod)
            {
                comboBox_payMethod.Items.Add(payMethod);
            }

            //購買者資訊
            lbl_orderNum.Text = GlobalVar.OrderNum;
            lbl_buyerName.Text = GlobalVar.BuyerName;
            lbl_buyerPhone.Text = GlobalVar.BuyerPhone;
            lbl_buyerAddress.Text = GlobalVar.BuyerAddress;

            foreach (ArrayList OrderItem in GlobalVar.OrderItemList)
            {
                string Item = (string)OrderItem[0];
                int UnitPrice = (int)OrderItem[1];
                int Bowls = (int)OrderItem[2];
                int ItemTotalPrice = (int)OrderItem[3];
                string Sauce = (string)OrderItem[4];
                string Sugar = (string)OrderItem[5];
                string Size = (string)OrderItem[6];

                string strItemInfo = string.Format("{0}, 單價:{1}元, {2}碗, 品項總價:{3}元, 糖水:{4}, 甜度:{5}, {6}\n" + "\n", Item, UnitPrice, Bowls, ItemTotalPrice, Sauce, Sugar, Size);

                lsb_orderList.Items.Add(strItemInfo);
            }

            CountTotalPrice(100);

            lbl_employeeID.Text = GlobalVar.EmployeeID;
        }

        void CountTotalPrice(int d)
        {
            foreach (ArrayList OrderItem in GlobalVar.OrderItemList)
            {
                string Item = (string)OrderItem[0];
                int UnitPrice = (int)OrderItem[1];
                int Bowls = (int)OrderItem[2];
                int ItemTotalPrice = (int)OrderItem[3];
                string Sauce = (string)OrderItem[4];
                string Sugar = (string)OrderItem[5];
                string Size = (string)OrderItem[6];

                OrderTotalPrice += ItemTotalPrice;
                OrderTotalPrice = Convert.ToInt32(OrderTotalPrice * d)/100;
            }            

            lbl_orderTotalPrice.Text = String.Format("訂單總價: {0}元", OrderTotalPrice);
            GlobalVar.OrderPrice = lbl_orderTotalPrice.Text;
        }

        private void btn_cancelThis_Click(object sender, EventArgs e)
        {
            if (lsb_orderList.SelectedIndex > -1)
            {

                int selIndex = lsb_orderList.SelectedIndex;

                GlobalVar.OrderItemList.RemoveAt(selIndex);
                lsb_orderList.Items.RemoveAt(selIndex);

                CountTotalPrice(100);
            }
            else
            {
                MessageBox.Show("請選擇移除品項");
            }
        }

        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            lsb_orderList.Items.Clear();
            GlobalVar.OrderItemList.Clear();
            GlobalVar.BuyerName = "";
            GlobalVar.BuyerPhone = "";
            GlobalVar.BuyerAddress = "";
            CountTotalPrice(100);
        }

        private void btn_sendOut_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Mid-Term Project";
            scsb.IntegratedSecurity = true;
            myDBConnection = scsb.ToString();

            List<string> tempItem = new List<string>();
            string strItemInfo = "";
            foreach (ArrayList OrderItem in GlobalVar.OrderItemList)
            {
                string Item = (string)OrderItem[0];
                int Bowls = (int)OrderItem[2];
                string Sauce = (string)OrderItem[4];
                string Sugar = (string)OrderItem[5];
                string Size = (string)OrderItem[6];

                strItemInfo = string.Format("{0}, {1}碗, 糖水:{2}, 甜度:{3}, {4}", Item, Bowls, Sauce, Sugar, Size);
                tempItem.Add(strItemInfo);
            }

            int itemTotalPrice = 0;
            List<int> tempPrice = new List<int>();
            foreach (ArrayList tempItemPrice in GlobalVar.OrderItemList)
            {
                int itemTotal = (int)tempItemPrice[3];
                itemTotalPrice = itemTotal;
                tempPrice.Add(itemTotalPrice);
            }

            SqlConnection con = new SqlConnection(myDBConnection);
            con.Open();

            for (int i = 0; i < tempItem.Count; i++)
            {
                strItemInfo = tempItem[i];
                string strSQL = "insert into Orders values(@orderNum, @orderBuyer, @orderPhone, @orderProduct, @itemTotal);";
                //測試用 string strSQL = "insert into Orders values('111002', 'Mario', '0987654321', '冰棒', '3000');";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@orderNum", lbl_orderNum.Text);
                cmd.Parameters.AddWithValue("@orderBuyer", lbl_buyerName.Text);
                cmd.Parameters.AddWithValue("@orderPhone", lbl_buyerPhone.Text);
                cmd.Parameters.AddWithValue("@orderProduct", strItemInfo);
                cmd.Parameters.AddWithValue("@itemTotal", tempPrice[i] );
                SqlDataReader reader = cmd.ExecuteReader();
                //string tempOrderItem = reader.ToString();
                reader.Close();

            }

            con.Close();
            MessageBox.Show("已送出此訂單");
        }

        void methods()
        {
            string methods = "";

            if (chbox_plasticBag.Checked == true)
            {
                methods += " 買塑膠袋";
                MessageBox.Show("地球表示:X!");
            }

            if (chbox_tableware.Checked == true)
            {
                methods += " 附餐具";
                MessageBox.Show("自己洗碗很難?");
            }

            if (radio_forHere.Checked == true)
            { //內用
                methods += " 內用";
            }
            else
            {
                if (radio_toGo.Checked == true)
                {
                    methods += " 外帶";
                }
                else
                {
                    if (radio_delivery.Checked == true)
                    {
                        methods += " 外送";
                    }
                }
            }
            GlobalVar.methods = methods;
        }

        private void radio_delivery_CheckedChanged(object sender, EventArgs e)
        {
            if (lbl_buyerAddress.Text == string.Empty && radio_delivery.Checked)
            {
                MessageBox.Show("記得輸入地址");
            }

        }

        private void chbox_plasticBag_CheckedChanged(object sender, EventArgs e)
        {
            OrderTotalPrice += 30;
        }

        private void chbox_tableware_CheckedChanged(object sender, EventArgs e)
        {
            OrderTotalPrice += 30;
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            if (txt_discount.Text == "Mario")
            {
                CountTotalPrice(50);
            }
        }
    }
}
