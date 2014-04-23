namespace RSSReadTech.SomeForm
{
    partial class UpdateForm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txbdeletename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncencel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txbselectname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList2;
            this.treeView1.Location = new System.Drawing.Point(-1, -1);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(244, 275);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "16fold.gif");
            this.imageList2.Images.SetKeyName(1, "16file.gif");
            this.imageList2.Images.SetKeyName(2, "16doc.gif");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(240, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btncancel);
            this.splitContainer1.Panel1.Controls.Add(this.btndelete);
            this.splitContainer1.Panel1.Controls.Add(this.txbdeletename);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btncencel);
            this.splitContainer1.Panel2.Controls.Add(this.btnupdate);
            this.splitContainer1.Panel2.Controls.Add(this.txbselectname);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(531, 274);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 10;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(161, 181);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 16;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndelete
            // 
            this.btndelete.Enabled = false;
            this.btndelete.Location = new System.Drawing.Point(29, 181);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txbdeletename
            // 
            this.txbdeletename.Enabled = false;
            this.txbdeletename.Location = new System.Drawing.Point(29, 97);
            this.txbdeletename.Name = "txbdeletename";
            this.txbdeletename.Size = new System.Drawing.Size(207, 21);
            this.txbdeletename.TabIndex = 14;
            this.txbdeletename.TextChanged += new System.EventHandler(this.txbdeletename_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "请在左边选择你要删除的频道或元素：";
            // 
            // btncencel
            // 
            this.btncencel.Location = new System.Drawing.Point(162, 181);
            this.btncencel.Name = "btncencel";
            this.btncencel.Size = new System.Drawing.Size(75, 23);
            this.btncencel.TabIndex = 12;
            this.btncencel.Text = "取消";
            this.btncencel.UseVisualStyleBackColor = true;
            this.btncencel.Click += new System.EventHandler(this.btncencel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Enabled = false;
            this.btnupdate.Location = new System.Drawing.Point(30, 181);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txbselectname
            // 
            this.txbselectname.Enabled = false;
            this.txbselectname.Location = new System.Drawing.Point(30, 97);
            this.txbselectname.Name = "txbselectname";
            this.txbselectname.Size = new System.Drawing.Size(207, 21);
            this.txbselectname.TabIndex = 10;
            this.txbselectname.TextChanged += new System.EventHandler(this.txbselectname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "请在左边选择你要修改的频道或元素：";
            // 
            // UpdateForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 273);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UpdateForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm1";
            this.Load += new System.EventHandler(this.UpdateForm1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txbdeletename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncencel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txbselectname;
        private System.Windows.Forms.Label label1;

    }
}