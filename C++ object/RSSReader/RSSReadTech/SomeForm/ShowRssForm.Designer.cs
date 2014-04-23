namespace RSSReadTech.SomeForm
{
    partial class ShowRssForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbxml = new System.Windows.Forms.RadioButton();
            this.rdbDb = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btncencel = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultshow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.uri,
            this.defaultshow});
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(543, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // rdbxml
            // 
            this.rdbxml.AutoSize = true;
            this.rdbxml.Checked = true;
            this.rdbxml.Location = new System.Drawing.Point(21, 232);
            this.rdbxml.Name = "rdbxml";
            this.rdbxml.Size = new System.Drawing.Size(89, 16);
            this.rdbxml.TabIndex = 1;
            this.rdbxml.TabStop = true;
            this.rdbxml.Text = "MXL文件保存";
            this.rdbxml.UseVisualStyleBackColor = true;
            // 
            // rdbDb
            // 
            this.rdbDb.AutoSize = true;
            this.rdbDb.Location = new System.Drawing.Point(122, 232);
            this.rdbDb.Name = "rdbDb";
            this.rdbDb.Size = new System.Drawing.Size(83, 16);
            this.rdbDb.TabIndex = 2;
            this.rdbDb.TabStop = true;
            this.rdbDb.Text = "数据库保存";
            this.rdbDb.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(250, 225);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btncencel
            // 
            this.btncencel.Location = new System.Drawing.Point(352, 225);
            this.btncencel.Name = "btncencel";
            this.btncencel.Size = new System.Drawing.Size(75, 23);
            this.btncencel.TabIndex = 4;
            this.btncencel.Text = "取消";
            this.btncencel.UseVisualStyleBackColor = true;
            this.btncencel.Click += new System.EventHandler(this.btncencel_Click);
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "文件描述";
            this.title.Name = "title";
            this.title.Width = 200;
            // 
            // uri
            // 
            this.uri.DataPropertyName = "uri";
            this.uri.HeaderText = "地址";
            this.uri.Name = "uri";
            this.uri.Width = 200;
            // 
            // defaultshow
            // 
            this.defaultshow.DataPropertyName = "defaultshow";
            this.defaultshow.HeaderText = "是否可见";
            this.defaultshow.Name = "defaultshow";
            this.defaultshow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.defaultshow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ShowRssForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 273);
            this.Controls.Add(this.btncencel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rdbDb);
            this.Controls.Add(this.rdbxml);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ShowRssForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowRssForm";
            this.Load += new System.EventHandler(this.ShowRssForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdbxml;
        private System.Windows.Forms.RadioButton rdbDb;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btncencel;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn uri;
        private System.Windows.Forms.DataGridViewCheckBoxColumn defaultshow;
    }
}