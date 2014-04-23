namespace RSSReadTech.SomeForm
{
    partial class UPdateForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UPdateForm2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbname = new System.Windows.Forms.TextBox();
            this.txbaddress = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "频道名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "频道地址";
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(97, 19);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(160, 21);
            this.txbname.TabIndex = 2;
            // 
            // txbaddress
            // 
            this.txbaddress.Location = new System.Drawing.Point(97, 68);
            this.txbaddress.Name = "txbaddress";
            this.txbaddress.Size = new System.Drawing.Size(160, 21);
            this.txbaddress.TabIndex = 3;
            this.txbaddress.TextChanged += new System.EventHandler(this.txbaddress_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(97, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "是否显示频道";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Enabled = false;
            this.btnok.Location = new System.Drawing.Point(53, 154);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "确定";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(192, 154);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.Transparent;
            this.btnopen.FlatAppearance.BorderSize = 0;
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnopen.Image = ((System.Drawing.Image)(resources.GetObject("btnopen.Image")));
            this.btnopen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnopen.Location = new System.Drawing.Point(263, 66);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(78, 23);
            this.btnopen.TabIndex = 7;
            this.btnopen.Text = "浏览";
            this.btnopen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnopen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // UPdateForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 199);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txbaddress);
            this.Controls.Add(this.txbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UPdateForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPdateForm2";
            this.Load += new System.EventHandler(this.UPdateForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.TextBox txbaddress;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}