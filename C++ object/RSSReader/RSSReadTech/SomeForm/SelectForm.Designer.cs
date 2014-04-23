namespace RSSReadTech.SomeForm
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txbaddress = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.bntselect = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择目录";
            // 
            // txbaddress
            // 
            this.txbaddress.Location = new System.Drawing.Point(159, 21);
            this.txbaddress.Name = "txbaddress";
            this.txbaddress.Size = new System.Drawing.Size(174, 21);
            this.txbaddress.TabIndex = 3;
            this.txbaddress.TextChanged += new System.EventHandler(this.txbaddress_TextChanged);
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.Transparent;
            this.btnopen.FlatAppearance.BorderSize = 0;
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnopen.Image = ((System.Drawing.Image)(resources.GetObject("btnopen.Image")));
            this.btnopen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnopen.Location = new System.Drawing.Point(344, 21);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(78, 23);
            this.btnopen.TabIndex = 8;
            this.btnopen.Text = "浏览";
            this.btnopen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnopen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // bntselect
            // 
            this.bntselect.Enabled = false;
            this.bntselect.Location = new System.Drawing.Point(102, 197);
            this.bntselect.Name = "bntselect";
            this.bntselect.Size = new System.Drawing.Size(75, 23);
            this.bntselect.TabIndex = 10;
            this.bntselect.Text = "查询";
            this.bntselect.UseVisualStyleBackColor = true;
            this.bntselect.Click += new System.EventHandler(this.bntselect_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(347, 197);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(102, 60);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(320, 119);
            this.treeView1.TabIndex = 12;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // btnadd
            // 
            this.btnadd.Enabled = false;
            this.btnadd.Location = new System.Drawing.Point(233, 197);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 273);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.bntselect);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.txbaddress);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectForm";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbaddress;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button bntselect;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnadd;
    }
}