namespace RSSReadTech.SomeForm
{
    partial class AddForm
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
            this.lblname = new System.Windows.Forms.Label();
            this.txbname = new System.Windows.Forms.TextBox();
            this.ckbdefaultshow = new System.Windows.Forms.CheckBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnold = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(54, 21);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(53, 12);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "目录名：";
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(56, 46);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(260, 21);
            this.txbname.TabIndex = 1;
            this.txbname.TextChanged += new System.EventHandler(this.txbname_TextChanged);
            // 
            // ckbdefaultshow
            // 
            this.ckbdefaultshow.AutoSize = true;
            this.ckbdefaultshow.Location = new System.Drawing.Point(56, 92);
            this.ckbdefaultshow.Name = "ckbdefaultshow";
            this.ckbdefaultshow.Size = new System.Drawing.Size(84, 16);
            this.ckbdefaultshow.TabIndex = 2;
            this.ckbdefaultshow.Text = "显示此频道";
            this.ckbdefaultshow.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Enabled = false;
            this.btnadd.Location = new System.Drawing.Point(162, 192);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "添  加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnold
            // 
            this.btnold.Location = new System.Drawing.Point(269, 192);
            this.btnold.Name = "btnold";
            this.btnold.Size = new System.Drawing.Size(75, 23);
            this.btnold.TabIndex = 4;
            this.btnold.Text = "上一步";
            this.btnold.UseVisualStyleBackColor = true;
            this.btnold.Click += new System.EventHandler(this.btnold_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(377, 192);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 271);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnold);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.ckbdefaultshow);
            this.Controls.Add(this.txbname);
            this.Controls.Add(this.lblname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.CheckBox ckbdefaultshow;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnold;
        private System.Windows.Forms.Button btncancel;
    }
}