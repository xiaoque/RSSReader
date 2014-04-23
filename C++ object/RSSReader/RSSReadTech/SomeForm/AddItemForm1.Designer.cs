namespace RSSReadTech.SomeForm
{
    partial class AddItemForm1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxfathername = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbitemname = new System.Windows.Forms.TextBox();
            this.txbitemaddress = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "频道名";
            // 
            // cbxfathername
            // 
            this.cbxfathername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxfathername.FormattingEnabled = true;
            this.cbxfathername.Location = new System.Drawing.Point(144, 32);
            this.cbxfathername.Name = "cbxfathername";
            this.cbxfathername.Size = new System.Drawing.Size(260, 20);
            this.cbxfathername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "元素名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "网址";
            // 
            // txbitemname
            // 
            this.txbitemname.Location = new System.Drawing.Point(144, 69);
            this.txbitemname.Name = "txbitemname";
            this.txbitemname.Size = new System.Drawing.Size(260, 21);
            this.txbitemname.TabIndex = 4;
            this.txbitemname.TextChanged += new System.EventHandler(this.txbitemname_TextChanged);
            // 
            // txbitemaddress
            // 
            this.txbitemaddress.Location = new System.Drawing.Point(144, 111);
            this.txbitemaddress.Name = "txbitemaddress";
            this.txbitemaddress.Size = new System.Drawing.Size(260, 21);
            this.txbitemaddress.TabIndex = 5;
            this.txbitemaddress.TextChanged += new System.EventHandler(this.txbitemaddress_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.Enabled = false;
            this.btnadd.Location = new System.Drawing.Point(144, 182);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(329, 182);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // AddItemForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 273);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txbitemaddress);
            this.Controls.Add(this.txbitemname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxfathername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddItemForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemForm1";
            this.Load += new System.EventHandler(this.AddItemForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxfathername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbitemname;
        private System.Windows.Forms.TextBox txbitemaddress;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
    }
}