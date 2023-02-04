using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中專題ver1
{
    public partial class MySystem : Form
    {
        public bool isReLogin = false;

        public MySystem()
        {
            InitializeComponent();
        }

        private void MySystem_Load(object sender, EventArgs e)
        {
            Portal form_protal = new Portal();
            form_protal.ShowDialog();

            lbl_ID.Text = GlobalVar.EmployeeID;
        }

        private void btn_member_Click(object sender, EventArgs e)
        {
            MemberInfo form_memberInfo = new MemberInfo();
            form_memberInfo.ShowDialog();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Order form_orderInput = new Order();
            form_orderInput.ShowDialog();
        }

        private void btn_orderManagement_Click(object sender, EventArgs e)
        {
            CheckingOrder form_orderManagement = new CheckingOrder();
            form_orderManagement.ShowDialog();
        }

        private void btn_productManagement_Click(object sender, EventArgs e)
        {
            Product form_product = new Product();
            form_product.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btn_relogin_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
    }
}
