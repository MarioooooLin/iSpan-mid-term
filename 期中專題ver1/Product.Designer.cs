namespace 期中專題ver1
{
    partial class Product
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
            this.components = new System.ComponentModel.Container();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_listMode = new System.Windows.Forms.Button();
            this.btn_photoMode = new System.Windows.Forms.Button();
            this.lsv_product = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.imgl_productPhoto = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btn_reload
            // 
            this.btn_reload.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_reload.Location = new System.Drawing.Point(551, 414);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(166, 48);
            this.btn_reload.TabIndex = 11;
            this.btn_reload.Text = "重新載入";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_addNew
            // 
            this.btn_addNew.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addNew.Location = new System.Drawing.Point(551, 319);
            this.btn_addNew.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(166, 48);
            this.btn_addNew.TabIndex = 10;
            this.btn_addNew.Text = "新增商品";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // btn_listMode
            // 
            this.btn_listMode.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_listMode.Location = new System.Drawing.Point(551, 229);
            this.btn_listMode.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listMode.Name = "btn_listMode";
            this.btn_listMode.Size = new System.Drawing.Size(166, 48);
            this.btn_listMode.TabIndex = 9;
            this.btn_listMode.Text = "列表模式";
            this.btn_listMode.UseVisualStyleBackColor = true;
            this.btn_listMode.Click += new System.EventHandler(this.btn_listMode_Click);
            // 
            // btn_photoMode
            // 
            this.btn_photoMode.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_photoMode.Location = new System.Drawing.Point(551, 140);
            this.btn_photoMode.Margin = new System.Windows.Forms.Padding(2);
            this.btn_photoMode.Name = "btn_photoMode";
            this.btn_photoMode.Size = new System.Drawing.Size(166, 48);
            this.btn_photoMode.TabIndex = 8;
            this.btn_photoMode.Text = "圖片模式";
            this.btn_photoMode.UseVisualStyleBackColor = true;
            this.btn_photoMode.Click += new System.EventHandler(this.btn_photoMode_Click);
            // 
            // lsv_product
            // 
            this.lsv_product.HideSelection = false;
            this.lsv_product.Location = new System.Drawing.Point(42, 102);
            this.lsv_product.Margin = new System.Windows.Forms.Padding(2);
            this.lsv_product.Name = "lsv_product";
            this.lsv_product.Size = new System.Drawing.Size(486, 500);
            this.lsv_product.TabIndex = 7;
            this.lsv_product.UseCompatibleStateImageBehavior = false;
            this.lsv_product.ItemActivate += new System.EventHandler(this.lsv_product_ItemActivate);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(245, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ID
            // 
            this.lbl_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_ID.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ID.Location = new System.Drawing.Point(617, 40);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(100, 28);
            this.lbl_ID.TabIndex = 40;
            this.lbl_ID.Text = "XXXXX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(534, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 28);
            this.label8.TabIndex = 39;
            this.label8.Text = "員工ID";
            // 
            // imgl_productPhoto
            // 
            this.imgl_productPhoto.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgl_productPhoto.ImageSize = new System.Drawing.Size(256, 256);
            this.imgl_productPhoto.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 655);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_addNew);
            this.Controls.Add(this.btn_listMode);
            this.Controls.Add(this.btn_photoMode);
            this.Controls.Add(this.lsv_product);
            this.Controls.Add(this.label1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Button btn_listMode;
        private System.Windows.Forms.Button btn_photoMode;
        private System.Windows.Forms.ListView lsv_product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList imgl_productPhoto;
    }
}