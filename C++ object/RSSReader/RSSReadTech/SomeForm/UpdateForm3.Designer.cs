namespace RSSReadTech.SomeForm
{
    partial class UpdateForm3
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbname = new System.Windows.Forms.TextBox();
            this.txbaddress = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "元素名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "网址";
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(89, 24);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(223, 21);
            this.txbname.TabIndex = 2;
            this.txbname.TextChanged += new System.EventHandler(this.txbname_TextChanged);
            // 
            // txbaddress
            // 
            this.txbaddress.Location = new System.Drawing.Point(89, 69);
            this.txbaddress.Name = "txbaddress";
            this.txbaddress.Size = new System.Drawing.Size(223, 21);
            this.txbaddress.TabIndex = 3;
            this.txbaddress.TextChanged += new System.EventHandler(this.txbaddress_TextChanged);
            // 
            // btnok
            // 
            this.btnok.Enabled = false;
            this.btnok.Location = new System.Drawing.Point(89, 137);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 4;
            this.btnok.Text = "确定";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncansel
            // 
            this.btncansel.Location = new System.Drawing.Point(237, 137);
            this.btncansel.Name = "btncansel";
            this.btncansel.Size = new System.Drawing.Size(75, 23);
            this.btncansel.TabIndex = 5;
            this.btncansel.Text = "取消";
            this.btncansel.UseVisualStyleBackColor = true;
            // 
            // UpdateForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 201);
            this.Controls.Add(this.btncansel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txbaddress);
            this.Controls.Add(this.txbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UpdateForm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm3";
            this.Load += new System.EventHandler(this.UpdateForm3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.TextBox txbaddress;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncansel;
    }
}