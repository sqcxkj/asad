namespace 广告账本
{
    partial class QueryForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.CustomerNamebox = new System.Windows.Forms.ComboBox();
            this.daochu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.closebut = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.yi = new System.Windows.Forms.TextBox();
            this.qi = new System.Windows.Forms.TextBox();
            this.marktxt = new System.Windows.Forms.TextBox();
            this.IsPaidbox = new System.Windows.Forms.ComboBox();
            this.jiu = new System.Windows.Forms.TextBox();
            this.ba = new System.Windows.Forms.TextBox();
            this.liu = new System.Windows.Forms.TextBox();
            this.si = new System.Windows.Forms.TextBox();
            this.san = new System.Windows.Forms.TextBox();
            this.er = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wu = new System.Windows.Forms.TextBox();
            this.shi = new System.Windows.Forms.TextBox();
            this.shiyi = new System.Windows.Forms.TextBox();
            this.jilu = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.totalprice = new System.Windows.Forms.Label();
            this.paybybox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(474, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 33);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "查询全部";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CustomerNamebox
            // 
            this.CustomerNamebox.Font = new System.Drawing.Font("宋体", 13F);
            this.CustomerNamebox.FormattingEnabled = true;
            this.CustomerNamebox.Location = new System.Drawing.Point(87, 24);
            this.CustomerNamebox.Name = "CustomerNamebox";
            this.CustomerNamebox.Size = new System.Drawing.Size(133, 25);
            this.CustomerNamebox.TabIndex = 2;
            this.CustomerNamebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CustomerNamebox_MouseClick);
            // 
            // daochu
            // 
            this.daochu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.daochu.Location = new System.Drawing.Point(1196, 17);
            this.daochu.Name = "daochu";
            this.daochu.Size = new System.Drawing.Size(83, 32);
            this.daochu.TabIndex = 3;
            this.daochu.Text = "导出结果";
            this.daochu.UseVisualStyleBackColor = true;
            this.daochu.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(352, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "已结账";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(230, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "未结账";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(718, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "删除查询结果";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // closebut
            // 
            this.closebut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closebut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closebut.Location = new System.Drawing.Point(1368, 17);
            this.closebut.Name = "closebut";
            this.closebut.Size = new System.Drawing.Size(83, 32);
            this.closebut.TabIndex = 7;
            this.closebut.Text = "关闭";
            this.closebut.UseVisualStyleBackColor = false;
            this.closebut.Click += new System.EventHandler(this.closebut_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(29, 59);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1422, 317);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // yi
            // 
            this.yi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yi.Font = new System.Drawing.Font("宋体", 12F);
            this.yi.Location = new System.Drawing.Point(78, 448);
            this.yi.Name = "yi";
            this.yi.Size = new System.Drawing.Size(81, 26);
            this.yi.TabIndex = 44;
            this.yi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yi.TextChanged += new System.EventHandler(this.yi_TextChanged);
            // 
            // qi
            // 
            this.qi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.qi.Font = new System.Drawing.Font("宋体", 12F);
            this.qi.Location = new System.Drawing.Point(576, 448);
            this.qi.Name = "qi";
            this.qi.Size = new System.Drawing.Size(48, 26);
            this.qi.TabIndex = 43;
            this.qi.Text = "1";
            this.qi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // marktxt
            // 
            this.marktxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.marktxt.Font = new System.Drawing.Font("宋体", 12F);
            this.marktxt.Location = new System.Drawing.Point(1089, 448);
            this.marktxt.Name = "marktxt";
            this.marktxt.Size = new System.Drawing.Size(190, 26);
            this.marktxt.TabIndex = 42;
            this.marktxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IsPaidbox
            // 
            this.IsPaidbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IsPaidbox.Font = new System.Drawing.Font("宋体", 12F);
            this.IsPaidbox.FormattingEnabled = true;
            this.IsPaidbox.Items.AddRange(new object[] {
            "否",
            "是"});
            this.IsPaidbox.Location = new System.Drawing.Point(936, 449);
            this.IsPaidbox.Name = "IsPaidbox";
            this.IsPaidbox.Size = new System.Drawing.Size(51, 24);
            this.IsPaidbox.TabIndex = 41;
            this.IsPaidbox.Text = "否";
            this.IsPaidbox.SelectedIndexChanged += new System.EventHandler(this.IsPaidbox_SelectedIndexChanged);
            // 
            // jiu
            // 
            this.jiu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jiu.Font = new System.Drawing.Font("宋体", 12F);
            this.jiu.Location = new System.Drawing.Point(693, 448);
            this.jiu.Name = "jiu";
            this.jiu.Size = new System.Drawing.Size(64, 26);
            this.jiu.TabIndex = 39;
            this.jiu.Text = "0.00";
            this.jiu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ba
            // 
            this.ba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ba.Font = new System.Drawing.Font("宋体", 12F);
            this.ba.Location = new System.Drawing.Point(640, 448);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(37, 26);
            this.ba.TabIndex = 38;
            this.ba.Text = "0";
            this.ba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // liu
            // 
            this.liu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.liu.Font = new System.Drawing.Font("宋体", 12F);
            this.liu.Location = new System.Drawing.Point(521, 448);
            this.liu.Name = "liu";
            this.liu.Size = new System.Drawing.Size(43, 26);
            this.liu.TabIndex = 37;
            this.liu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // si
            // 
            this.si.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.si.Font = new System.Drawing.Font("宋体", 12F);
            this.si.Location = new System.Drawing.Point(354, 448);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(73, 26);
            this.si.TabIndex = 36;
            this.si.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // san
            // 
            this.san.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.san.Font = new System.Drawing.Font("宋体", 12F);
            this.san.Location = new System.Drawing.Point(290, 448);
            this.san.Name = "san";
            this.san.Size = new System.Drawing.Size(56, 26);
            this.san.TabIndex = 35;
            this.san.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // er
            // 
            this.er.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.er.Font = new System.Drawing.Font("宋体", 12F);
            this.er.Location = new System.Drawing.Point(169, 448);
            this.er.Name = "er";
            this.er.Size = new System.Drawing.Size(111, 26);
            this.er.TabIndex = 34;
            this.er.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(40, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1106, 14);
            this.label1.TabIndex = 45;
            this.label1.Text = "序号    客户名         文件名        类型       长度       宽度      单位    单价     数量     小计    " +
    " 优惠        时间       是否结账   付款方式       备注";
            // 
            // wu
            // 
            this.wu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wu.Font = new System.Drawing.Font("宋体", 12F);
            this.wu.Location = new System.Drawing.Point(435, 448);
            this.wu.Name = "wu";
            this.wu.Size = new System.Drawing.Size(73, 26);
            this.wu.TabIndex = 46;
            this.wu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shi
            // 
            this.shi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shi.Font = new System.Drawing.Font("宋体", 12F);
            this.shi.Location = new System.Drawing.Point(764, 448);
            this.shi.Name = "shi";
            this.shi.Size = new System.Drawing.Size(47, 26);
            this.shi.TabIndex = 47;
            this.shi.Text = "0.00";
            this.shi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shiyi
            // 
            this.shiyi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shiyi.Font = new System.Drawing.Font("宋体", 12F);
            this.shiyi.Location = new System.Drawing.Point(823, 448);
            this.shiyi.Name = "shiyi";
            this.shiyi.Size = new System.Drawing.Size(94, 26);
            this.shiyi.TabIndex = 48;
            this.shiyi.Text = "0.00";
            this.shiyi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // jilu
            // 
            this.jilu.AutoSize = true;
            this.jilu.Location = new System.Drawing.Point(41, 448);
            this.jilu.Name = "jilu";
            this.jilu.Size = new System.Drawing.Size(0, 12);
            this.jilu.TabIndex = 49;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.updatebtn.Enabled = false;
            this.updatebtn.Location = new System.Drawing.Point(1324, 425);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(98, 49);
            this.updatebtn.TabIndex = 50;
            this.updatebtn.Text = "更新";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1063, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 33);
            this.button4.TabIndex = 51;
            this.button4.Text = "显示所有客户记录";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // totalprice
            // 
            this.totalprice.AutoEllipsis = true;
            this.totalprice.AutoSize = true;
            this.totalprice.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.totalprice.ForeColor = System.Drawing.Color.Blue;
            this.totalprice.Location = new System.Drawing.Point(690, 386);
            this.totalprice.Name = "totalprice";
            this.totalprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalprice.Size = new System.Drawing.Size(67, 25);
            this.totalprice.TabIndex = 52;
            this.totalprice.Text = "label2";
            // 
            // paybybox
            // 
            this.paybybox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paybybox.Enabled = false;
            this.paybybox.Font = new System.Drawing.Font("宋体", 12F);
            this.paybybox.FormattingEnabled = true;
            this.paybybox.Items.AddRange(new object[] {
            "微信",
            "支付宝",
            "现金",
            "银联"});
            this.paybybox.Location = new System.Drawing.Point(1005, 449);
            this.paybybox.Name = "paybybox";
            this.paybybox.Size = new System.Drawing.Size(71, 24);
            this.paybybox.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 12);
            this.label2.TabIndex = 54;
            this.label2.Text = "选中行，按键盘删除键可删除单行记录，双击记录可以在下方修改记录";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(596, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 33);
            this.button5.TabIndex = 55;
            this.button5.Text = "一键结帐";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "请选择客户";
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paybybox);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.jilu);
            this.Controls.Add(this.shiyi);
            this.Controls.Add(this.shi);
            this.Controls.Add(this.wu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yi);
            this.Controls.Add(this.qi);
            this.Controls.Add(this.marktxt);
            this.Controls.Add(this.IsPaidbox);
            this.Controls.Add(this.jiu);
            this.Controls.Add(this.ba);
            this.Controls.Add(this.liu);
            this.Controls.Add(this.si);
            this.Controls.Add(this.san);
            this.Controls.Add(this.er);
            this.Controls.Add(this.closebut);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.daochu);
            this.Controls.Add(this.CustomerNamebox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(1500, 543);
            this.MinimumSize = new System.Drawing.Size(1500, 543);
            this.Name = "QueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询记录";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox CustomerNamebox;
        private System.Windows.Forms.Button daochu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button closebut;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox yi;
        private System.Windows.Forms.TextBox qi;
        private System.Windows.Forms.TextBox marktxt;
        private System.Windows.Forms.ComboBox IsPaidbox;
        private System.Windows.Forms.TextBox jiu;
        private System.Windows.Forms.TextBox ba;
        private System.Windows.Forms.TextBox liu;
        private System.Windows.Forms.TextBox si;
        private System.Windows.Forms.TextBox san;
        private System.Windows.Forms.TextBox er;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wu;
        private System.Windows.Forms.TextBox shi;
        private System.Windows.Forms.TextBox shiyi;
        private System.Windows.Forms.Label jilu;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label totalprice;
        private System.Windows.Forms.ComboBox paybybox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
    }
}