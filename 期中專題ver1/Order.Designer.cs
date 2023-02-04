namespace 期中專題ver1
{
    partial class Order
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
            this.cbox_sauce = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_checkOrder = new System.Windows.Forms.Button();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.lbl_unitPrice = new System.Windows.Forms.Label();
            this.txt_bowl = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbox_size = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbox_sugar = new System.Windows.Forms.ComboBox();
            this.lsb_product = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phoneNum = new System.Windows.Forms.TextBox();
            this.txt_buyer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_orderNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbox_sauce
            // 
            this.cbox_sauce.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_sauce.FormattingEnabled = true;
            this.cbox_sauce.Location = new System.Drawing.Point(548, 334);
            this.cbox_sauce.Name = "cbox_sauce";
            this.cbox_sauce.Size = new System.Drawing.Size(168, 29);
            this.cbox_sauce.TabIndex = 62;
            this.cbox_sauce.SelectedIndexChanged += new System.EventHandler(this.cbox_sauce_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(215, 686);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 21);
            this.label17.TabIndex = 61;
            this.label17.Text = "碗";
            // 
            // btn_checkOrder
            // 
            this.btn_checkOrder.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_checkOrder.Location = new System.Drawing.Point(442, 733);
            this.btn_checkOrder.Name = "btn_checkOrder";
            this.btn_checkOrder.Size = new System.Drawing.Size(172, 42);
            this.btn_checkOrder.TabIndex = 60;
            this.btn_checkOrder.Text = "查看訂單";
            this.btn_checkOrder.UseVisualStyleBackColor = true;
            this.btn_checkOrder.Click += new System.EventHandler(this.btn_checkOrder_Click);
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addOrder.Location = new System.Drawing.Point(188, 734);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(176, 40);
            this.btn_addOrder.TabIndex = 59;
            this.btn_addOrder.Text = "加入訂單";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.BackColor = System.Drawing.Color.Orange;
            this.lbl_totalPrice.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(581, 678);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(78, 24);
            this.lbl_totalPrice.TabIndex = 58;
            this.lbl_totalPrice.Text = "xxxx元";
            // 
            // lbl_unitPrice
            // 
            this.lbl_unitPrice.AutoSize = true;
            this.lbl_unitPrice.BackColor = System.Drawing.Color.Orange;
            this.lbl_unitPrice.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_unitPrice.Location = new System.Drawing.Point(362, 679);
            this.lbl_unitPrice.Name = "lbl_unitPrice";
            this.lbl_unitPrice.Size = new System.Drawing.Size(78, 24);
            this.lbl_unitPrice.TabIndex = 57;
            this.lbl_unitPrice.Text = "xxxx元";
            // 
            // txt_bowl
            // 
            this.txt_bowl.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_bowl.Location = new System.Drawing.Point(134, 674);
            this.txt_bowl.Name = "txt_bowl";
            this.txt_bowl.Size = new System.Drawing.Size(72, 33);
            this.txt_bowl.TabIndex = 56;
            this.txt_bowl.TextChanged += new System.EventHandler(this.txt_bowl_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Aquamarine;
            this.label14.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(577, 640);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 19);
            this.label14.TabIndex = 53;
            this.label14.Text = "品項總價";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Aquamarine;
            this.label13.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(362, 640);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 52;
            this.label13.Text = "單價";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Aquamarine;
            this.label12.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(135, 640);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 51;
            this.label12.Text = "數量";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(545, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 19);
            this.label11.TabIndex = 50;
            this.label11.Text = "份量";
            // 
            // cbox_size
            // 
            this.cbox_size.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_size.FormattingEnabled = true;
            this.cbox_size.Location = new System.Drawing.Point(549, 507);
            this.cbox_size.Name = "cbox_size";
            this.cbox_size.Size = new System.Drawing.Size(168, 29);
            this.cbox_size.TabIndex = 49;
            this.cbox_size.SelectedIndexChanged += new System.EventHandler(this.cbox_size_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(545, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 48;
            this.label10.Text = "甜度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(545, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 47;
            this.label9.Text = "選糖水";
            // 
            // cbox_sugar
            // 
            this.cbox_sugar.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_sugar.FormattingEnabled = true;
            this.cbox_sugar.Location = new System.Drawing.Point(548, 419);
            this.cbox_sugar.Name = "cbox_sugar";
            this.cbox_sugar.Size = new System.Drawing.Size(168, 29);
            this.cbox_sugar.TabIndex = 46;
            this.cbox_sugar.SelectedIndexChanged += new System.EventHandler(this.cbox_sugar_SelectedIndexChanged);
            // 
            // lsb_product
            // 
            this.lsb_product.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lsb_product.FormattingEnabled = true;
            this.lsb_product.ItemHeight = 16;
            this.lsb_product.Location = new System.Drawing.Point(50, 305);
            this.lsb_product.Name = "lsb_product";
            this.lsb_product.Size = new System.Drawing.Size(423, 308);
            this.lsb_product.TabIndex = 42;
            this.lsb_product.SelectedIndexChanged += new System.EventHandler(this.lsb_product_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Aquamarine;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(46, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "菜單";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_address.Location = new System.Drawing.Point(165, 232);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(638, 33);
            this.txt_address.TabIndex = 40;
            this.txt_address.Visible = false;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // txt_phoneNum
            // 
            this.txt_phoneNum.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_phoneNum.Location = new System.Drawing.Point(165, 184);
            this.txt_phoneNum.MaxLength = 10;
            this.txt_phoneNum.Name = "txt_phoneNum";
            this.txt_phoneNum.Size = new System.Drawing.Size(251, 33);
            this.txt_phoneNum.TabIndex = 39;
            this.txt_phoneNum.TextChanged += new System.EventHandler(this.txt_phoneNum_TextChanged);
            // 
            // txt_buyer
            // 
            this.txt_buyer.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_buyer.Location = new System.Drawing.Point(165, 134);
            this.txt_buyer.Name = "txt_buyer";
            this.txt_buyer.Size = new System.Drawing.Size(251, 33);
            this.txt_buyer.TabIndex = 38;
            this.txt_buyer.TextChanged += new System.EventHandler(this.txt_buyer_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aquamarine;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(46, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "外送地址";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aquamarine;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(46, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "連絡電話";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aquamarine;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(46, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "會員姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(327, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "訂單輸入";
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_employeeID.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_employeeID.Location = new System.Drawing.Point(662, 36);
            this.lbl_employeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(141, 28);
            this.lbl_employeeID.TabIndex = 67;
            this.lbl_employeeID.Text = "XXXXX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(579, 36);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 28);
            this.label18.TabIndex = 66;
            this.label18.Text = "員工ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Aquamarine;
            this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(46, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 68;
            this.label6.Text = "訂單號碼";
            // 
            // txt_orderNum
            // 
            this.txt_orderNum.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_orderNum.Location = new System.Drawing.Point(165, 85);
            this.txt_orderNum.MaxLength = 6;
            this.txt_orderNum.Name = "txt_orderNum";
            this.txt_orderNum.Size = new System.Drawing.Size(251, 33);
            this.txt_orderNum.TabIndex = 69;
            this.txt_orderNum.TextChanged += new System.EventHandler(this.txt_orderNum_TextChanged);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 800);
            this.Controls.Add(this.txt_orderNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_employeeID);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbox_sauce);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_checkOrder);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.lbl_unitPrice);
            this.Controls.Add(this.txt_bowl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbox_size);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbox_sugar);
            this.Controls.Add(this.lsb_product);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phoneNum);
            this.Controls.Add(this.txt_buyer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbox_sauce;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_checkOrder;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label lbl_unitPrice;
        private System.Windows.Forms.TextBox txt_bowl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbox_size;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbox_sugar;
        private System.Windows.Forms.ListBox lsb_product;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_phoneNum;
        private System.Windows.Forms.TextBox txt_buyer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_orderNum;
    }
}