namespace 期中專題ver1
{
    partial class ProductManagement
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
            this.gb_addNew = new System.Windows.Forms.GroupBox();
            this.btn_pickNewPhoto = new System.Windows.Forms.Button();
            this.btn_saveNew = new System.Windows.Forms.Button();
            this.btn_clearField = new System.Windows.Forms.Button();
            this.gb_amendProduct = new System.Windows.Forms.GroupBox();
            this.btn_saveAmend = new System.Windows.Forms.Button();
            this.btn_pickPhoto = new System.Windows.Forms.Button();
            this.pb_product = new System.Windows.Forms.PictureBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.gb_addNew.SuspendLayout();
            this.gb_amendProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_product)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_addNew
            // 
            this.gb_addNew.BackColor = System.Drawing.Color.LightGreen;
            this.gb_addNew.Controls.Add(this.btn_pickNewPhoto);
            this.gb_addNew.Controls.Add(this.btn_saveNew);
            this.gb_addNew.Controls.Add(this.btn_clearField);
            this.gb_addNew.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gb_addNew.Location = new System.Drawing.Point(382, 505);
            this.gb_addNew.Name = "gb_addNew";
            this.gb_addNew.Size = new System.Drawing.Size(284, 134);
            this.gb_addNew.TabIndex = 25;
            this.gb_addNew.TabStop = false;
            this.gb_addNew.Text = "新增商品資訊";
            // 
            // btn_pickNewPhoto
            // 
            this.btn_pickNewPhoto.Location = new System.Drawing.Point(75, 30);
            this.btn_pickNewPhoto.Name = "btn_pickNewPhoto";
            this.btn_pickNewPhoto.Size = new System.Drawing.Size(144, 27);
            this.btn_pickNewPhoto.TabIndex = 2;
            this.btn_pickNewPhoto.Text = "選取商品照片";
            this.btn_pickNewPhoto.UseVisualStyleBackColor = true;
            this.btn_pickNewPhoto.Click += new System.EventHandler(this.btn_pickPhoto_Click);
            // 
            // btn_saveNew
            // 
            this.btn_saveNew.Location = new System.Drawing.Point(75, 65);
            this.btn_saveNew.Name = "btn_saveNew";
            this.btn_saveNew.Size = new System.Drawing.Size(144, 27);
            this.btn_saveNew.TabIndex = 4;
            this.btn_saveNew.Text = "儲存商品";
            this.btn_saveNew.UseVisualStyleBackColor = true;
            this.btn_saveNew.Click += new System.EventHandler(this.btn_saveNew_Click);
            // 
            // btn_clearField
            // 
            this.btn_clearField.Location = new System.Drawing.Point(75, 101);
            this.btn_clearField.Name = "btn_clearField";
            this.btn_clearField.Size = new System.Drawing.Size(144, 27);
            this.btn_clearField.TabIndex = 2;
            this.btn_clearField.Text = "清空欄位";
            this.btn_clearField.UseVisualStyleBackColor = true;
            this.btn_clearField.Click += new System.EventHandler(this.btn_clearField_Click);
            // 
            // gb_amendProduct
            // 
            this.gb_amendProduct.BackColor = System.Drawing.Color.LightGreen;
            this.gb_amendProduct.Controls.Add(this.btn_deleteItem);
            this.gb_amendProduct.Controls.Add(this.btn_saveAmend);
            this.gb_amendProduct.Controls.Add(this.btn_pickPhoto);
            this.gb_amendProduct.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gb_amendProduct.Location = new System.Drawing.Point(49, 505);
            this.gb_amendProduct.Name = "gb_amendProduct";
            this.gb_amendProduct.Size = new System.Drawing.Size(280, 134);
            this.gb_amendProduct.TabIndex = 24;
            this.gb_amendProduct.TabStop = false;
            this.gb_amendProduct.Text = "修改商品資訊";
            // 
            // btn_saveAmend
            // 
            this.btn_saveAmend.Location = new System.Drawing.Point(63, 65);
            this.btn_saveAmend.Name = "btn_saveAmend";
            this.btn_saveAmend.Size = new System.Drawing.Size(144, 27);
            this.btn_saveAmend.TabIndex = 1;
            this.btn_saveAmend.Text = "儲存修改";
            this.btn_saveAmend.UseVisualStyleBackColor = true;
            this.btn_saveAmend.Click += new System.EventHandler(this.btn_saveAmend_Click);
            // 
            // btn_pickPhoto
            // 
            this.btn_pickPhoto.Location = new System.Drawing.Point(63, 30);
            this.btn_pickPhoto.Name = "btn_pickPhoto";
            this.btn_pickPhoto.Size = new System.Drawing.Size(144, 27);
            this.btn_pickPhoto.TabIndex = 0;
            this.btn_pickPhoto.Text = "選取商品照片";
            this.btn_pickPhoto.UseVisualStyleBackColor = true;
            this.btn_pickPhoto.Click += new System.EventHandler(this.btn_pickPhoto_Click);
            // 
            // pb_product
            // 
            this.pb_product.Location = new System.Drawing.Point(382, 136);
            this.pb_product.Name = "pb_product";
            this.pb_product.Size = new System.Drawing.Size(282, 342);
            this.pb_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_product.TabIndex = 23;
            this.pb_product.TabStop = false;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(136, 237);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_description.Size = new System.Drawing.Size(215, 241);
            this.txt_description.TabIndex = 22;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_price.Location = new System.Drawing.Point(136, 190);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(215, 34);
            this.txt_price.TabIndex = 21;
            // 
            // lbl_ID
            // 
            this.lbl_ID.BackColor = System.Drawing.Color.Khaki;
            this.lbl_ID.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_ID.Location = new System.Drawing.Point(136, 104);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(215, 28);
            this.lbl_ID.TabIndex = 19;
            this.lbl_ID.Text = "xxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(378, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "商品圖檔";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(43, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "商品描述";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(43, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "商品價格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(43, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "商品名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "商品ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(269, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "商品修改";
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_employeeID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_employeeID.Location = new System.Drawing.Point(523, 43);
            this.lbl_employeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(141, 28);
            this.lbl_employeeID.TabIndex = 71;
            this.lbl_employeeID.Text = "XXXXX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(461, 47);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 24);
            this.label18.TabIndex = 70;
            this.label18.Text = "員工ID";
            // 
            // txt_product
            // 
            this.txt_product.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_product.Location = new System.Drawing.Point(136, 144);
            this.txt_product.Multiline = true;
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(215, 34);
            this.txt_product.TabIndex = 72;
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(63, 100);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(144, 27);
            this.btn_deleteItem.TabIndex = 2;
            this.btn_deleteItem.Text = "刪除商品";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 730);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.lbl_employeeID);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.gb_addNew);
            this.Controls.Add(this.gb_amendProduct);
            this.Controls.Add(this.pb_product);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.gb_addNew.ResumeLayout(false);
            this.gb_amendProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_addNew;
        private System.Windows.Forms.Button btn_saveNew;
        private System.Windows.Forms.Button btn_clearField;
        private System.Windows.Forms.GroupBox gb_amendProduct;
        private System.Windows.Forms.Button btn_saveAmend;
        private System.Windows.Forms.Button btn_pickPhoto;
        private System.Windows.Forms.PictureBox pb_product;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Button btn_pickNewPhoto;
        private System.Windows.Forms.Button btn_deleteItem;
    }
}