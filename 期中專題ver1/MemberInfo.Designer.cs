namespace 期中專題ver1
{
    partial class MemberInfo
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
            this.dgv_memberInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_customerID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_searchInfo = new System.Windows.Forms.Button();
            this.chb_marital = new System.Windows.Forms.CheckBox();
            this.btn_clearField = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_deleteInfo = new System.Windows.Forms.Button();
            this.dtp_birth = new System.Windows.Forms.DateTimePicker();
            this.btn_addInfo = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_amendInfo = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_memberInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_memberInfo
            // 
            this.dgv_memberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_memberInfo.Location = new System.Drawing.Point(31, 487);
            this.dgv_memberInfo.Name = "dgv_memberInfo";
            this.dgv_memberInfo.RowTemplate.Height = 24;
            this.dgv_memberInfo.Size = new System.Drawing.Size(701, 245);
            this.dgv_memberInfo.TabIndex = 19;
            this.dgv_memberInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_memberInfo_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.lbl_customerID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btn_searchInfo);
            this.groupBox1.Controls.Add(this.chb_marital);
            this.groupBox1.Controls.Add(this.btn_clearField);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_deleteInfo);
            this.groupBox1.Controls.Add(this.dtp_birth);
            this.groupBox1.Controls.Add(this.btn_addInfo);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.btn_amendInfo);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(31, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 397);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 一般資料";
            // 
            // lbl_customerID
            // 
            this.lbl_customerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_customerID.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_customerID.Location = new System.Drawing.Point(107, 26);
            this.lbl_customerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customerID.Name = "lbl_customerID";
            this.lbl_customerID.Size = new System.Drawing.Size(182, 28);
            this.lbl_customerID.TabIndex = 32;
            this.lbl_customerID.Text = "XXXXX";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(32, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 28);
            this.label12.TabIndex = 39;
            this.label12.Text = "ID";
            // 
            // btn_searchInfo
            // 
            this.btn_searchInfo.Location = new System.Drawing.Point(36, 335);
            this.btn_searchInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_searchInfo.Name = "btn_searchInfo";
            this.btn_searchInfo.Size = new System.Drawing.Size(113, 41);
            this.btn_searchInfo.TabIndex = 22;
            this.btn_searchInfo.Text = "搜尋資料";
            this.btn_searchInfo.UseVisualStyleBackColor = true;
            this.btn_searchInfo.Click += new System.EventHandler(this.btn_searchInfo_Click);
            // 
            // chb_marital
            // 
            this.chb_marital.AutoSize = true;
            this.chb_marital.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chb_marital.Location = new System.Drawing.Point(145, 291);
            this.chb_marital.Margin = new System.Windows.Forms.Padding(2);
            this.chb_marital.Name = "chb_marital";
            this.chb_marital.Size = new System.Drawing.Size(58, 20);
            this.chb_marital.TabIndex = 38;
            this.chb_marital.Text = "已婚";
            this.chb_marital.UseVisualStyleBackColor = true;
            // 
            // btn_clearField
            // 
            this.btn_clearField.Location = new System.Drawing.Point(554, 335);
            this.btn_clearField.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearField.Name = "btn_clearField";
            this.btn_clearField.Size = new System.Drawing.Size(113, 41);
            this.btn_clearField.TabIndex = 21;
            this.btn_clearField.Text = "清空欄位";
            this.btn_clearField.UseVisualStyleBackColor = true;
            this.btn_clearField.Click += new System.EventHandler(this.btn_clearField_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(32, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 37;
            this.label8.Text = "婚姻狀態";
            // 
            // btn_deleteInfo
            // 
            this.btn_deleteInfo.Location = new System.Drawing.Point(424, 335);
            this.btn_deleteInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteInfo.Name = "btn_deleteInfo";
            this.btn_deleteInfo.Size = new System.Drawing.Size(113, 41);
            this.btn_deleteInfo.TabIndex = 20;
            this.btn_deleteInfo.Text = "刪除資料";
            this.btn_deleteInfo.UseVisualStyleBackColor = true;
            this.btn_deleteInfo.Click += new System.EventHandler(this.btn_deleteInfo_Click);
            // 
            // dtp_birth
            // 
            this.dtp_birth.CalendarFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_birth.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_birth.Location = new System.Drawing.Point(110, 244);
            this.dtp_birth.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_birth.Name = "dtp_birth";
            this.dtp_birth.Size = new System.Drawing.Size(213, 27);
            this.dtp_birth.TabIndex = 36;
            this.dtp_birth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btn_addInfo
            // 
            this.btn_addInfo.Location = new System.Drawing.Point(296, 335);
            this.btn_addInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addInfo.Name = "btn_addInfo";
            this.btn_addInfo.Size = new System.Drawing.Size(113, 41);
            this.btn_addInfo.TabIndex = 19;
            this.btn_addInfo.Text = "新增資料";
            this.btn_addInfo.UseVisualStyleBackColor = true;
            this.btn_addInfo.Click += new System.EventHandler(this.btn_addInfo_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_email.Location = new System.Drawing.Point(110, 201);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(498, 27);
            this.txt_email.TabIndex = 35;
            // 
            // btn_amendInfo
            // 
            this.btn_amendInfo.Location = new System.Drawing.Point(166, 335);
            this.btn_amendInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_amendInfo.Name = "btn_amendInfo";
            this.btn_amendInfo.Size = new System.Drawing.Size(113, 41);
            this.btn_amendInfo.TabIndex = 18;
            this.btn_amendInfo.Text = "修改資料";
            this.btn_amendInfo.UseVisualStyleBackColor = true;
            this.btn_amendInfo.Click += new System.EventHandler(this.btn_amendInfo_Click);
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_address.Location = new System.Drawing.Point(110, 157);
            this.txt_address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(498, 27);
            this.txt_address.TabIndex = 34;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_phone.Location = new System.Drawing.Point(110, 113);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(179, 27);
            this.txt_phone.TabIndex = 33;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_name.Location = new System.Drawing.Point(110, 69);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(179, 27);
            this.txt_name.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(32, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 28);
            this.label6.TabIndex = 30;
            this.label6.Text = "生日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(32, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "Emaill";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "姓名";
            // 
            // lbl_ID
            // 
            this.lbl_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_ID.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ID.Location = new System.Drawing.Point(550, 42);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(182, 28);
            this.lbl_ID.TabIndex = 31;
            this.lbl_ID.Text = "XXXXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(467, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "員工ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(266, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 43);
            this.label2.TabIndex = 17;
            this.label2.Text = "會員資料";
            // 
            // MemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 752);
            this.Controls.Add(this.dgv_memberInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label7);
            this.Name = "MemberInfo";
            this.Text = "MemberInfo";
            this.Load += new System.EventHandler(this.MemberInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_memberInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_memberInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_searchInfo;
        private System.Windows.Forms.CheckBox chb_marital;
        private System.Windows.Forms.Button btn_clearField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_deleteInfo;
        private System.Windows.Forms.DateTimePicker dtp_birth;
        private System.Windows.Forms.Button btn_addInfo;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_amendInfo;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_customerID;
        private System.Windows.Forms.Label label12;
    }
}