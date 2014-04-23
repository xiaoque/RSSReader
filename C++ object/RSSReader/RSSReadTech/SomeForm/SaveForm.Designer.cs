namespace RSSReadTech.SomeForm
{
    partial class SaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveForm));
            this.lblin = new System.Windows.Forms.Label();
            this.tbxaddress = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblin
            // 
            this.lblin.AutoSize = true;
            this.lblin.Location = new System.Drawing.Point(47, 32);
            this.lblin.Name = "lblin";
            this.lblin.Size = new System.Drawing.Size(179, 12);
            this.lblin.TabIndex = 0;
            this.lblin.Text = "请输入Rss文件路径或选择文件：";
            // 
            // tbxaddress
            // 
            this.tbxaddress.Location = new System.Drawing.Point(49, 59);
            this.tbxaddress.Name = "tbxaddress";
            this.tbxaddress.Size = new System.Drawing.Size(255, 21);
            this.tbxaddress.TabIndex = 1;
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.Transparent;
            this.btnopen.FlatAppearance.BorderSize = 0;
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnopen.Image = ((System.Drawing.Image)(resources.GetObject("btnopen.Image")));
            this.btnopen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnopen.Location = new System.Drawing.Point(310, 57);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(78, 23);
            this.btnopen.TabIndex = 2;
            this.btnopen.Text = "浏览";
            this.btnopen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnopen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(251, 192);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 4;
            this.btnnext.Text = "下一步";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(396, 192);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "取 消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DereferenceLinks = false;
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 273);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.tbxaddress);
            this.Controls.Add(this.lblin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SaveForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveForm";
            this.Load += new System.EventHandler(this.SaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblin;
        private System.Windows.Forms.TextBox tbxaddress;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}