namespace 期中專題ver1
{
    partial class CheckingOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsb_orderList = new System.Windows.Forms.ListBox();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_cancelOrder = new System.Windows.Forms.Button();
            this.btn_amendOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_newOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_orderTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbl_orderID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chb_marital = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_searchOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsb_orderList
            // 
            this.lsb_orderList.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lsb_orderList.FormattingEnabled = true;
            this.lsb_orderList.ItemHeight = 15;
            this.lsb_orderList.Location = new System.Drawing.Point(37, 287);
            this.lsb_orderList.Name = "lsb_orderList";
            this.lsb_orderList.Size = new System.Drawing.Size(674, 244);
            this.lsb_orderList.TabIndex = 57;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_checkout.Location = new System.Drawing.Point(648, 675);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(133, 34);
            this.btn_checkout.TabIndex = 51;
            this.btn_checkout.Text = "營業額確認";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Visible = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_cancelOrder
            // 
            this.btn_cancelOrder.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancelOrder.Location = new System.Drawing.Point(493, 675);
            this.btn_cancelOrder.Name = "btn_cancelOrder";
            this.btn_cancelOrder.Size = new System.Drawing.Size(137, 34);
            this.btn_cancelOrder.TabIndex = 50;
            this.btn_cancelOrder.Text = "取消訂單";
            this.btn_cancelOrder.UseVisualStyleBackColor = true;
            this.btn_cancelOrder.Click += new System.EventHandler(this.btn_cancelOrder_Click);
            // 
            // btn_amendOrder
            // 
            this.btn_amendOrder.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_amendOrder.Location = new System.Drawing.Point(335, 675);
            this.btn_amendOrder.Name = "btn_amendOrder";
            this.btn_amendOrder.Size = new System.Drawing.Size(140, 34);
            this.btn_amendOrder.TabIndex = 49;
            this.btn_amendOrder.Text = "修改訂單";
            this.btn_amendOrder.UseVisualStyleBackColor = true;
            this.btn_amendOrder.Visible = false;
            this.btn_amendOrder.Click += new System.EventHandler(this.btn_amendOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(307, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 40;
            this.label1.Text = "訂單管理";
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_employeeID.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_employeeID.Location = new System.Drawing.Point(619, 37);
            this.lbl_employeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(141, 28);
            this.lbl_employeeID.TabIndex = 69;
            this.lbl_employeeID.Text = "XXXXX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(536, 37);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 28);
            this.label18.TabIndex = 68;
            this.label18.Text = "員工ID";
            // 
            // btn_newOrder
            // 
            this.btn_newOrder.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_newOrder.Location = new System.Drawing.Point(176, 676);
            this.btn_newOrder.Name = "btn_newOrder";
            this.btn_newOrder.Size = new System.Drawing.Size(140, 34);
            this.btn_newOrder.TabIndex = 70;
            this.btn_newOrder.Text = "新增訂單";
            this.btn_newOrder.UseVisualStyleBackColor = true;
            this.btn_newOrder.Click += new System.EventHandler(this.btn_newOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.lbl_orderTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.lbl_orderID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.chb_marital);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lsb_orderList);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(32, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 560);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂單資料";
            // 
            // lbl_orderTotal
            // 
            this.lbl_orderTotal.AutoSize = true;
            this.lbl_orderTotal.BackColor = System.Drawing.Color.Orange;
            this.lbl_orderTotal.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_orderTotal.Location = new System.Drawing.Point(141, 246);
            this.lbl_orderTotal.Name = "lbl_orderTotal";
            this.lbl_orderTotal.Size = new System.Drawing.Size(85, 21);
            this.lbl_orderTotal.TabIndex = 61;
            this.lbl_orderTotal.Text = "XXXXX";
            this.lbl_orderTotal.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(32, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 60;
            this.label5.Text = "訂單總額";
            this.label5.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox2.Location = new System.Drawing.Point(303, 208);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 20);
            this.checkBox2.TabIndex = 59;
            this.checkBox2.Text = "外送";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(223, 208);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 20);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "外帶";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // lbl_orderID
            // 
            this.lbl_orderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_orderID.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_orderID.Location = new System.Drawing.Point(136, 26);
            this.lbl_orderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_orderID.Name = "lbl_orderID";
            this.lbl_orderID.Size = new System.Drawing.Size(182, 28);
            this.lbl_orderID.TabIndex = 32;
            this.lbl_orderID.Text = "XXXXX";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(32, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 28);
            this.label12.TabIndex = 39;
            this.label12.Text = "訂單號碼";
            // 
            // chb_marital
            // 
            this.chb_marital.AutoSize = true;
            this.chb_marital.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chb_marital.Location = new System.Drawing.Point(145, 208);
            this.chb_marital.Margin = new System.Windows.Forms.Padding(2);
            this.chb_marital.Name = "chb_marital";
            this.chb_marital.Size = new System.Drawing.Size(58, 20);
            this.chb_marital.TabIndex = 38;
            this.chb_marital.Text = "內用";
            this.chb_marital.UseVisualStyleBackColor = true;
            this.chb_marital.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(32, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 37;
            this.label8.Text = "用餐方式";
            this.label8.Visible = false;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_address.Location = new System.Drawing.Point(136, 157);
            this.txt_address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(541, 27);
            this.txt_address.TabIndex = 34;
            this.txt_address.Visible = false;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_phone.Location = new System.Drawing.Point(136, 112);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(179, 27);
            this.txt_phone.TabIndex = 33;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_name.Location = new System.Drawing.Point(136, 69);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(179, 27);
            this.txt_name.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(32, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "地址";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(32, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "電話";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "客戶姓名";
            // 
            // btn_searchOrder
            // 
            this.btn_searchOrder.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_searchOrder.Location = new System.Drawing.Point(18, 675);
            this.btn_searchOrder.Name = "btn_searchOrder";
            this.btn_searchOrder.Size = new System.Drawing.Size(140, 34);
            this.btn_searchOrder.TabIndex = 72;
            this.btn_searchOrder.Text = "查詢訂單";
            this.btn_searchOrder.UseVisualStyleBackColor = true;
            this.btn_searchOrder.Click += new System.EventHandler(this.btn_searchOrder_Click);
            // 
            // CheckingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 757);
            this.Controls.Add(this.btn_searchOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_newOrder);
            this.Controls.Add(this.lbl_employeeID);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_cancelOrder);
            this.Controls.Add(this.btn_amendOrder);
            this.Controls.Add(this.label1);
            this.Name = "CheckingOrder";
            this.Text = "CheckingOrder";
            this.Load += new System.EventHandler(this.CheckingOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lsb_orderList;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_cancelOrder;
        private System.Windows.Forms.Button btn_amendOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_newOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_orderID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chb_marital;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_searchOrder;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbl_orderTotal;
        private System.Windows.Forms.Label label5;
    }
}