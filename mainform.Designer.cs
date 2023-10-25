namespace 广告账本
{
    partial class mainform
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.QueryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unpaidListView = new System.Windows.Forms.ListView();
            this.addproduct = new System.Windows.Forms.Button();
            this.addguestname = new System.Windows.Forms.Button();
            this.syssetup = new System.Windows.Forms.Button();
            this.exitbut = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.zt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddOrderToolStripMenuItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OrderContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xsjlsl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.BackColor = System.Drawing.Color.LawnGreen;
            this.AddRecordButton.Font = new System.Drawing.Font("宋体", 15F);
            this.AddRecordButton.ForeColor = System.Drawing.Color.Blue;
            this.AddRecordButton.Location = new System.Drawing.Point(65, 532);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(105, 52);
            this.AddRecordButton.TabIndex = 0;
            this.AddRecordButton.Text = "新增订单";
            this.AddRecordButton.UseVisualStyleBackColor = false;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // QueryButton
            // 
            this.QueryButton.BackColor = System.Drawing.Color.Yellow;
            this.QueryButton.Font = new System.Drawing.Font("宋体", 12F);
            this.QueryButton.ForeColor = System.Drawing.Color.Red;
            this.QueryButton.Location = new System.Drawing.Point(198, 532);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(105, 52);
            this.QueryButton.TabIndex = 1;
            this.QueryButton.Text = "删/改/查";
            this.QueryButton.UseVisualStyleBackColor = false;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // unpaidListView
            // 
            this.unpaidListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unpaidListView.Font = new System.Drawing.Font("宋体", 14F);
            this.unpaidListView.ForeColor = System.Drawing.Color.Red;
            this.unpaidListView.FullRowSelect = true;
            this.unpaidListView.GridLines = true;
            this.unpaidListView.HideSelection = false;
            this.unpaidListView.Location = new System.Drawing.Point(25, 83);
            this.unpaidListView.Name = "unpaidListView";
            this.unpaidListView.Size = new System.Drawing.Size(348, 436);
            this.unpaidListView.TabIndex = 5;
            this.unpaidListView.UseCompatibleStateImageBehavior = false;
            this.unpaidListView.DoubleClick += new System.EventHandler(this.unpaidListView_DoubleClick);
            // 
            // addproduct
            // 
            this.addproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.addproduct.Location = new System.Drawing.Point(483, 532);
            this.addproduct.Name = "addproduct";
            this.addproduct.Size = new System.Drawing.Size(105, 52);
            this.addproduct.TabIndex = 6;
            this.addproduct.Text = "商品分类";
            this.addproduct.UseVisualStyleBackColor = false;
            this.addproduct.Click += new System.EventHandler(this.addproduct_Click);
            // 
            // addguestname
            // 
            this.addguestname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addguestname.Location = new System.Drawing.Point(331, 532);
            this.addguestname.Name = "addguestname";
            this.addguestname.Size = new System.Drawing.Size(105, 52);
            this.addguestname.TabIndex = 7;
            this.addguestname.Text = "添加客户名";
            this.addguestname.UseVisualStyleBackColor = false;
            this.addguestname.Click += new System.EventHandler(this.addguestname_Click);
            // 
            // syssetup
            // 
            this.syssetup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.syssetup.Location = new System.Drawing.Point(615, 532);
            this.syssetup.Name = "syssetup";
            this.syssetup.Size = new System.Drawing.Size(105, 52);
            this.syssetup.TabIndex = 8;
            this.syssetup.Text = "系统设置";
            this.syssetup.UseVisualStyleBackColor = false;
            this.syssetup.Click += new System.EventHandler(this.syssetup_Click);
            // 
            // exitbut
            // 
            this.exitbut.BackColor = System.Drawing.Color.Yellow;
            this.exitbut.Font = new System.Drawing.Font("宋体", 19F);
            this.exitbut.ForeColor = System.Drawing.Color.Red;
            this.exitbut.Location = new System.Drawing.Point(1135, 522);
            this.exitbut.Name = "exitbut";
            this.exitbut.Size = new System.Drawing.Size(105, 49);
            this.exitbut.TabIndex = 9;
            this.exitbut.Text = "退出";
            this.exitbut.UseVisualStyleBackColor = false;
            this.exitbut.Click += new System.EventHandler(this.exitbut_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("宋体", 11F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(411, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(845, 436);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F);
            this.label2.Location = new System.Drawing.Point(736, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "最新订单";
            // 
            // zt
            // 
            this.zt.AutoSize = true;
            this.zt.Location = new System.Drawing.Point(886, 537);
            this.zt.Name = "zt";
            this.zt.Size = new System.Drawing.Size(149, 24);
            this.zt.TabIndex = 13;
            this.zt.Text = "添加记录后，及时点击刷新\r\n查看记录是否添加成功";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(783, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOrderToolStripMenuItem
            // 
            this.AddOrderToolStripMenuItem.Name = "AddOrderToolStripMenuItem";
            this.AddOrderToolStripMenuItem.Size = new System.Drawing.Size(61, 4);
            // 
            // OrderContextMenu
            // 
            this.OrderContextMenu.Name = "OrderContextMenu";
            this.OrderContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // xsjlsl
            // 
            this.xsjlsl.FormattingEnabled = true;
            this.xsjlsl.Items.AddRange(new object[] {
            "50",
            "100",
            "全部"});
            this.xsjlsl.Location = new System.Drawing.Point(1135, 57);
            this.xsjlsl.Name = "xsjlsl";
            this.xsjlsl.Size = new System.Drawing.Size(59, 20);
            this.xsjlsl.TabIndex = 15;
            this.xsjlsl.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1100, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "显示";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1200, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "条记录";
            // 
            // mainform
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1285, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xsjlsl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.exitbut);
            this.Controls.Add(this.syssetup);
            this.Controls.Add(this.addguestname);
            this.Controls.Add(this.addproduct);
            this.Controls.Add(this.unpaidListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.AddRecordButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【创想广告记账单】";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView unpaidListView;
        private System.Windows.Forms.Button addproduct;
        private System.Windows.Forms.Button addguestname;
        private System.Windows.Forms.Button syssetup;
        private System.Windows.Forms.Button exitbut;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label zt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip AddOrderToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip OrderContextMenu;
        private System.Windows.Forms.ComboBox xsjlsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

