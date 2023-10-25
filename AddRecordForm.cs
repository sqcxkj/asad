using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace 广告账本
{
    public partial class AddRecordForm : Form
    {
        //private LiteDatabase _db;


        public AddRecordForm()
        {
            InitializeComponent();
            //    _db = new LiteDatabase(".\\ldatabase.db");


        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerNamebox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductIDbox = new System.Windows.Forms.ComboBox();
            this.ProductIDlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Processbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lengthtext = new System.Windows.Forms.TextBox();
            this.Widthtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Unittext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UnitPricetext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Subtotaltext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Discounttext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.IsPaidbox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Numbertext = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.yesadd = new System.Windows.Forms.Button();
            this.totalprice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.danwei = new System.Windows.Forms.Label();
            this.danwei1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.paybybox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerNamebox
            // 
            this.CustomerNamebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerNamebox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerNamebox.Font = new System.Drawing.Font("宋体", 12F);
            this.CustomerNamebox.FormattingEnabled = true;
            this.CustomerNamebox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CustomerNamebox.Location = new System.Drawing.Point(138, 33);
            this.CustomerNamebox.Name = "CustomerNamebox";
            this.CustomerNamebox.Size = new System.Drawing.Size(130, 24);
            this.CustomerNamebox.TabIndex = 0;
            this.CustomerNamebox.Text = "散客";
           
            this.CustomerNamebox.TextChanged += new System.EventHandler(this.CustomerNamebox_TextUpdate);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择客户名";
            // 
            // ProductIDbox
            // 
            this.ProductIDbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductIDbox.Font = new System.Drawing.Font("宋体", 12F);
            this.ProductIDbox.FormattingEnabled = true;
            this.ProductIDbox.Location = new System.Drawing.Point(163, 110);
            this.ProductIDbox.Name = "ProductIDbox";
            this.ProductIDbox.Size = new System.Drawing.Size(78, 24);
            this.ProductIDbox.TabIndex = 2;
            this.ProductIDbox.SelectedValueChanged += new System.EventHandler(this.ProductIDbox_SelectedValueChanged);
            // 
            // ProductIDlabel
            // 
            this.ProductIDlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductIDlabel.AutoSize = true;
            this.ProductIDlabel.Font = new System.Drawing.Font("宋体", 11F);
            this.ProductIDlabel.Location = new System.Drawing.Point(184, 83);
            this.ProductIDlabel.Name = "ProductIDlabel";
            this.ProductIDlabel.Size = new System.Drawing.Size(37, 15);
            this.ProductIDlabel.TabIndex = 3;
            this.ProductIDlabel.Text = "类型";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(283, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "项目/工艺";
            // 
            // Processbox
            // 
            this.Processbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Processbox.Font = new System.Drawing.Font("宋体", 12F);
            this.Processbox.FormattingEnabled = true;
            this.Processbox.Location = new System.Drawing.Point(250, 110);
            this.Processbox.Name = "Processbox";
            this.Processbox.Size = new System.Drawing.Size(145, 24);
            this.Processbox.TabIndex = 4;
            this.Processbox.SelectedValueChanged += new System.EventHandler(this.Processbox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(402, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "长度";
            // 
            // Lengthtext
            // 
            this.Lengthtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lengthtext.Font = new System.Drawing.Font("宋体", 12F);
            this.Lengthtext.Location = new System.Drawing.Point(401, 109);
            this.Lengthtext.Name = "Lengthtext";
            this.Lengthtext.Size = new System.Drawing.Size(78, 26);
            this.Lengthtext.TabIndex = 8;
            this.Lengthtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lengthtext.TextChanged += new System.EventHandler(this.Lengthtext_TextChanged);
            this.Lengthtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lengthtext_KeyPress);
            // 
            // Widthtext
            // 
            this.Widthtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Widthtext.Font = new System.Drawing.Font("宋体", 12F);
            this.Widthtext.Location = new System.Drawing.Point(483, 109);
            this.Widthtext.Name = "Widthtext";
            this.Widthtext.Size = new System.Drawing.Size(78, 26);
            this.Widthtext.TabIndex = 10;
            this.Widthtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Widthtext.TextChanged += new System.EventHandler(this.Lengthtext_TextChanged);
            this.Widthtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lengthtext_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 11F);
            this.label4.Location = new System.Drawing.Point(484, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "宽度";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Unittext
            // 
            this.Unittext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Unittext.Font = new System.Drawing.Font("宋体", 12F);
            this.Unittext.Location = new System.Drawing.Point(574, 109);
            this.Unittext.Name = "Unittext";
            this.Unittext.Size = new System.Drawing.Size(41, 26);
            this.Unittext.TabIndex = 12;
            this.Unittext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 11F);
            this.label5.Location = new System.Drawing.Point(576, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "单位";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UnitPricetext
            // 
            this.UnitPricetext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnitPricetext.Font = new System.Drawing.Font("宋体", 12F);
            this.UnitPricetext.Location = new System.Drawing.Point(626, 109);
            this.UnitPricetext.Name = "UnitPricetext";
            this.UnitPricetext.Size = new System.Drawing.Size(40, 26);
            this.UnitPricetext.TabIndex = 14;
            this.UnitPricetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnitPricetext.TextChanged += new System.EventHandler(this.Lengthtext_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 11F);
            this.label6.Location = new System.Drawing.Point(628, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "单价";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Subtotaltext
            // 
            this.Subtotaltext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Subtotaltext.Font = new System.Drawing.Font("宋体", 12F);
            this.Subtotaltext.Location = new System.Drawing.Point(730, 109);
            this.Subtotaltext.Name = "Subtotaltext";
            this.Subtotaltext.Size = new System.Drawing.Size(77, 26);
            this.Subtotaltext.TabIndex = 16;
            this.Subtotaltext.Text = "0";
            this.Subtotaltext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 11F);
            this.label7.Location = new System.Drawing.Point(750, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "小计";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Discounttext
            // 
            this.Discounttext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Discounttext.Font = new System.Drawing.Font("宋体", 12F);
            this.Discounttext.Location = new System.Drawing.Point(817, 109);
            this.Discounttext.Name = "Discounttext";
            this.Discounttext.Size = new System.Drawing.Size(47, 26);
            this.Discounttext.TabIndex = 18;
            this.Discounttext.Text = "0.00";
            this.Discounttext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 11F);
            this.label8.Location = new System.Drawing.Point(821, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "优惠";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 11F);
            this.label9.Location = new System.Drawing.Point(1057, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "当前时间";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(1019, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 11F);
            this.label10.Location = new System.Drawing.Point(869, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "是否结账";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IsPaidbox
            // 
            this.IsPaidbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IsPaidbox.Font = new System.Drawing.Font("宋体", 12F);
            this.IsPaidbox.FormattingEnabled = true;
            this.IsPaidbox.Items.AddRange(new object[] {
            "否",
            "是"});
            this.IsPaidbox.Location = new System.Drawing.Point(881, 110);
            this.IsPaidbox.Name = "IsPaidbox";
            this.IsPaidbox.Size = new System.Drawing.Size(51, 24);
            this.IsPaidbox.TabIndex = 22;
            this.IsPaidbox.Text = "否";
            this.IsPaidbox.SelectedIndexChanged += new System.EventHandler(this.IsPaidbox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox1.Location = new System.Drawing.Point(1160, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 11F);
            this.label11.Location = new System.Drawing.Point(1195, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "备注说明";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(13, 213);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1241, 312);
            this.dataGridView.TabIndex = 25;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_ColumnRemoved);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Addbutton.Font = new System.Drawing.Font("宋体", 12F);
            this.Addbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addbutton.Location = new System.Drawing.Point(24, 157);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(148, 50);
            this.Addbutton.TabIndex = 27;
            this.Addbutton.Text = "加入临时列表";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Numbertext
            // 
            this.Numbertext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Numbertext.Font = new System.Drawing.Font("宋体", 12F);
            this.Numbertext.Location = new System.Drawing.Point(673, 109);
            this.Numbertext.Name = "Numbertext";
            this.Numbertext.Size = new System.Drawing.Size(42, 26);
            this.Numbertext.TabIndex = 29;
            this.Numbertext.Text = "1";
            this.Numbertext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Numbertext.TextChanged += new System.EventHandler(this.Lengthtext_TextChanged);
            this.Numbertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lengthtext_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 11F);
            this.label12.Location = new System.Drawing.Point(676, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "数量";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // filename
            // 
            this.filename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filename.Font = new System.Drawing.Font("宋体", 12F);
            this.filename.Location = new System.Drawing.Point(13, 109);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(137, 26);
            this.filename.TabIndex = 31;
            this.filename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 11F);
            this.label13.Location = new System.Drawing.Point(59, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "文件名";
            // 
            // yesadd
            // 
            this.yesadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yesadd.BackColor = System.Drawing.Color.LimeGreen;
            this.yesadd.Font = new System.Drawing.Font("宋体", 12F);
            this.yesadd.Location = new System.Drawing.Point(1264, 213);
            this.yesadd.Name = "yesadd";
            this.yesadd.Size = new System.Drawing.Size(63, 209);
            this.yesadd.TabIndex = 27;
            this.yesadd.Text = "添\r\n加\r\n记\r\n录";
            this.yesadd.UseVisualStyleBackColor = false;
            this.yesadd.Click += new System.EventHandler(this.yesadd_Click);
            // 
            // totalprice
            // 
            this.totalprice.AutoSize = true;
            this.totalprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.totalprice.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalprice.Location = new System.Drawing.Point(983, 157);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(0, 50);
            this.totalprice.TabIndex = 32;
            this.totalprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(815, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "当前合计金额：";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(1264, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 87);
            this.button1.TabIndex = 34;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // danwei
            // 
            this.danwei.AutoSize = true;
            this.danwei.Font = new System.Drawing.Font("宋体", 12F);
            this.danwei.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.danwei.Location = new System.Drawing.Point(524, 82);
            this.danwei.Name = "danwei";
            this.danwei.Size = new System.Drawing.Size(39, 16);
            this.danwei.TabIndex = 35;
            this.danwei.Text = "(cm)";
            // 
            // danwei1
            // 
            this.danwei1.AutoSize = true;
            this.danwei1.Font = new System.Drawing.Font("宋体", 12F);
            this.danwei1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.danwei1.Location = new System.Drawing.Point(441, 82);
            this.danwei1.Name = "danwei1";
            this.danwei1.Size = new System.Drawing.Size(39, 16);
            this.danwei1.TabIndex = 36;
            this.danwei1.Text = "(cm)";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 11F);
            this.label15.Location = new System.Drawing.Point(945, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "结账方式";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.paybybox.Location = new System.Drawing.Point(942, 110);
            this.paybybox.Name = "paybybox";
            this.paybybox.Size = new System.Drawing.Size(71, 24);
            this.paybybox.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(740, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 39;
            this.label16.Text = "label16";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1067, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 40;
            this.label17.Text = "label17";
            // 
            // AddRecordForm
            // 
            this.AllowDrop = true;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1342, 556);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.paybybox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.danwei1);
            this.Controls.Add(this.danwei);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.totalprice);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Numbertext);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.yesadd);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IsPaidbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Discounttext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Subtotaltext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UnitPricetext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Unittext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Widthtext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lengthtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Processbox);
            this.Controls.Add(this.ProductIDlabel);
            this.Controls.Add(this.ProductIDbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerNamebox);
            this.Name = "AddRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加记录";
            this.Shown += new System.EventHandler(this.AddRecordForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddRecordForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AddRecordForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        public class CpType
        {
            public int _id { get; set; } // 添加 _id 属性
            public string ProductType { get; set; }
            public string Unit { get; set; }
            public string JijiaFangshi { get; set; }

            public override string ToString()

            {
                return ProductType.ToString();
            }
            public string getunit()
            {
                return Unit;

            }
        }


        public class Account
        {
            public int ID { get; set; } // 在LiteDB中，主键必须是int类型，不能是INTEGER类型  
            public string CustomerName { get; set; }
            public string Filename { get; set; }
            public string ProductType { get; set; }
            public string Process { get; set; }
            public double Length { get; set; }
            public double Width { get; set; }
            public string Unit { get; set; }
            public double UnitPrice { get; set; }
            public int cpNumber { get; set; }
            public double Subtotal { get; set; }
            public double Discount { get; set; }
            public string RecordTime { get; set; }
            public string IsPaid { get; set; }
            public string payby { get; set; } // 在LiteDB中，字段必须是具体的字符类型，不能是CHAR类型  
            public string Remark { get; set; }
        }

        public class Customer
        {
            public int ID { get; set; }
            public string CustomerName { get; set; }
            public int CustomerLevel { get; set; }
            public override string ToString()
            {
                return CustomerName;
            }
            public int getCustomerLevel()
            {
                return CustomerLevel;
            }

        }

        public class ProductPrice
        {
            public int ID { get; set; }
            public string ProductType { get; set; }
            public string Process { get; set; }
            public double UnitPrice { get; set; }
            public double UnitPricet { get; set; }
            public double UnitPrices { get; set; }
            public string Unit { get; set; }
            public double lowprice { get; set; }
            public string JijiaFangshi { get; set; }
            public string lwunit { get; set; }

            public override string ToString()
            {
                return Process;
            }
            public string getlwunit()
            {
                return lwunit;

            }
            public string GetProductType()
            {
                return ProductType;
            }
            public string getunit()
            {
                return Unit;
            }
            public double getunitprice()
            {
                return UnitPrice;
            }
            public double getunitprices()
            {
                return UnitPrices;

            }
            public double getunitpricet()
            {
                return UnitPricet;

            }

            public string getjijiafangshi()
            {
                return JijiaFangshi;
            }
        }

        public class SystemSetting
        {
            //[BsonId]
            public int _id { get; set; }

            public string CalculationFormula { get; set; }


            //public int SettingID { get; set; }

            public string JijiaFangshi { get; set; }


        }


        private void AddRecordForm_Load(object sender, EventArgs e)
        {
            ProductIDbox.SelectedValueChanged -= ProductIDbox_SelectedValueChanged;
            Processbox.SelectedValueChanged -= Processbox_SelectedValueChanged;
            Lengthtext.TextChanged -= Lengthtext_TextChanged;
            Widthtext.TextChanged -= Lengthtext_TextChanged;
            UnitPricetext.TextChanged -= Lengthtext_TextChanged;
            Numbertext.TextChanged -= Lengthtext_TextChanged;
            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                // 查询客户名称
                ILiteCollection<Customer> customerCollection = db.GetCollection<Customer>("Customers");
                List<Customer> customerList = customerCollection.FindAll()
                    .Select(doc => new Customer
                    {
                        CustomerName = doc.CustomerName,
                        CustomerLevel = doc.getCustomerLevel(),

                    })
                    .ToList();
                CustomerNamebox.DataSource = new BindingList<Customer>(customerList);
                CustomerNamebox.DisplayMember = "CustomerName";
                label16.Text = customerList[0].getCustomerLevel().ToString();
            }

            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                ILiteCollection<CpType> productType = db.GetCollection<CpType>("CpType");
                List<CpType> namelb = productType.FindAll().ToList();

                ProductIDbox.DataSource = new BindingList<CpType>(namelb);
                ProductIDbox.DisplayMember = "ProductType";
                Unittext.Text = namelb[0].getunit();
            }

            DataTable dt = new DataTable();
            _ = dt.Columns.Add("Process", typeof(string));
            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                string product = ProductIDbox.Text;

                // 查询符合条件的工艺名称  
                ILiteCollection<ProductPrice> productType = db.GetCollection<ProductPrice>("ProductPrices");
                List<ProductPrice> namelb = productType.Find(x => x.ProductType == product)
                    .Select(doc => new ProductPrice { Process = doc.Process })
                    .ToList();

                // 将结果存储到 DataTable 中  
                dt.Clear();
                foreach (ProductPrice item in namelb)
                {
                    _ = dt.Rows.Add(item.Process);
                }

                Processbox.DataSource = dt;
                Processbox.DisplayMember = "Process";
            }

            ProductIDbox.SelectedValueChanged += ProductIDbox_SelectedValueChanged;//再重新绑定 “ProductIDbox_SelectedValueChanged” 事件处理程序
            Processbox.SelectedValueChanged += Processbox_SelectedValueChanged;

            ProductIDbox.SelectedValueChanged += ProductIDbox_SelectedValueChanged;
            Processbox.SelectedValueChanged += Processbox_SelectedValueChanged;
            Lengthtext.TextChanged += Lengthtext_TextChanged;
            Widthtext.TextChanged += Lengthtext_TextChanged;
            UnitPricetext.TextChanged += Lengthtext_TextChanged;
            Numbertext.TextChanged += Lengthtext_TextChanged;
            danjia();

        }



        private void yesadd_Click(object sender, EventArgs e)//添加记录到数据库
        {
            string bt = Text;


            Text = "添加记录  【后台正在进行操作】请稍等-->";

            if (dataGridView.Rows.Count == 0)
            {
                _ = MessageBox.Show("数据为空");
                return;
            }

            // 创建一个连接到Access数据库的连接对象  
            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {

                // 创建集合（类似于SQL中的表）  
                ILiteCollection<Account> collection = db.GetCollection<Account>("Accounts");

                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView.Rows[i];
                    // 获取DataGridView中每列的值
                    string guestname = row.Cells["客户名"].Value.ToString();
                    string fileName = row.Cells["文件名"].Value?.ToString() ?? "";
                    string ProductType = row.Cells["类型"].Value.ToString();
                    string process = row.Cells["工艺"].Value?.ToString() ?? "";
                    _ = double.TryParse(row.Cells["长度"].Value?.ToString(), out double length);
                    _ = double.TryParse(row.Cells["宽度"].Value?.ToString(), out double width);
                    _ = double.TryParse(row.Cells["单价"].Value?.ToString(), out double unitPrice);
                    _ = int.TryParse(row.Cells["数量"].Value?.ToString(), out int quantity);
                    _ = double.TryParse(row.Cells["小计"].Value?.ToString(), out double subtotal);
                    _ = double.TryParse(row.Cells["优惠"].Value?.ToString(), out double discount);
                    string unit = row.Cells["单位"].Value.ToString();
                    string datime = row.Cells["时间"].Value.ToString();
                    string isPaid = row.Cells["是否结账"].Value.ToString();
                    string payby = row.Cells["结账方式"].Value.ToString();
                    string remark = row.Cells["备注"].Value?.ToString() ?? "";
                    // 创建一个触发器，当插入记录时触发
                    // 定义一个文档对象  
                    Account doc = new Account
                    {
                        CustomerName = guestname,
                        Filename = fileName,
                        ProductType = ProductType,
                        Process = process,
                        Length = length,
                        Width = width,
                        Unit = unit,
                        UnitPrice = unitPrice,
                        cpNumber = quantity,
                        Subtotal = subtotal,
                        Discount = discount,
                        RecordTime = datime,
                        IsPaid = isPaid,
                        payby = payby,
                        Remark = remark,


                    };


                    // 将文档插入集合  
                    _ = collection.Insert(doc);

                }
                _ = MessageBox.Show("添加成功");

                // 清除dataGridView数据
                Text = bt;
                dataGridView.DataSource = null;
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();




            }




        }


        private void Addbutton_Click(object sender, EventArgs e)              //***********添加到临时列表
        {  //增加临时记录
            // 获取用户输入的信息
            string guestname = CustomerNamebox.Text;
            string fileName = filename.Text;
            string type = ProductIDbox.Text;
            string process = Processbox.Text;
            string length = Lengthtext.Text;
            string width = Widthtext.Text;
            string unit = Unittext.Text;
            string unitPrice = UnitPricetext.Text;
            string quantity = Numbertext.Text;
            string subtotal = Subtotaltext.Text;
            string discount = Discounttext.Text;
            DateTime time = dateTimePicker1.Value;
            string isPaid = IsPaidbox.Text;
            string payby = paybybox.Text;
            string remark = textBox1.Text;

            // 如果DataGridView中没有列，则先创建列
            if (dataGridView.Columns.Count == 0)
            {
                // 创建DataGridView列
                _ = dataGridView.Columns.Add("序号", "序号");
                _ = dataGridView.Columns.Add("客户名", "客户名");
                _ = dataGridView.Columns.Add("文件名", "文件名");
                _ = dataGridView.Columns.Add("类型", "类型");
                _ = dataGridView.Columns.Add("工艺", "工艺");
                _ = dataGridView.Columns.Add("长度", "长度");
                _ = dataGridView.Columns.Add("宽度", "宽度");
                _ = dataGridView.Columns.Add("单位", "单位");
                _ = dataGridView.Columns.Add("单价", "单价");
                _ = dataGridView.Columns.Add("数量", "数量");
                _ = dataGridView.Columns.Add("小计", "小计");
                _ = dataGridView.Columns.Add("优惠", "优惠");
                _ = dataGridView.Columns.Add("时间", "时间");
                _ = dataGridView.Columns.Add("是否结账", "是否结账");
                _ = dataGridView.Columns.Add("结账方式", "结账方式");
                _ = dataGridView.Columns.Add("备注", "备注");
            }
            // 添加记录到DataGridView中
            int index = dataGridView.Rows.Count;
            object[] row = new object[]
            {
        index,
        guestname,
        fileName,
        type,
        process,
        length,
        width,
        unit,
        unitPrice,
        quantity,
        subtotal,
        discount,
        time,
        isPaid,
        payby,
        remark
            };
            _ = dataGridView.Rows.Add(row);

            // 获取DataGridView中每列的值
            double total = 0;
            // foreach (DataGridViewRow row in this.dataGridView.Rows)
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                DataGridViewRow rowa = dataGridView.Rows[i];

                {
                    _ = double.TryParse(rowa.Cells["小计"].Value.ToString(), out double subtotalVal);
                    total += subtotalVal;
                }
            }
            totalprice.Text = total.ToString() + "元";

            // 自动调整列宽

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoResizeColumns();
            // 获取容器控件中的所有文本框，并将它们的 Text 属性设置为空字符串

            Lengthtext.Text = "0";
            Widthtext.Text = "0";
            Numbertext.Text = "1";
            Subtotaltext.Text = "0"; ;
            Discounttext.Text = "0";
            filename.Text = "";
            IsPaidbox.Text = "否";


        }

        private void ProductIDbox_SelectedValueChanged(object sender, EventArgs e)
        {
            string p = ProductIDbox.Text;
            Processbox.SelectedValueChanged -= Processbox_SelectedValueChanged;
            {
                try
                {
                    int selectedIndex = ProductIDbox.SelectedIndex;
                    if (selectedIndex >= 0 && selectedIndex < ProductIDbox.Items.Count)
                    {
                        string product = ProductIDbox.Items[selectedIndex].ToString();
                        // MessageBox.Show(p + "ProductIDbox");

                        using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
                        {var  productType = db.GetCollection<BsonDocument>("ProductPrices");
                            List<ProductPrice> namelb = productType.Find(x => x["ProductType"].AsString == product)
                                .Select(doc => new ProductPrice
                                {
                                    Process = doc["process"].AsString,
                                    Unit = doc["Unit"],
                                })
                                .ToList();

                            Processbox.DataSource = new BindingList<ProductPrice>(namelb);
                            Processbox.DisplayMember = "Process";
                            Processbox.ValueMember = "Process";
                            Unittext.Text = namelb[0].getunit();

                            Unittext.Text = namelb.Count > 0 ? namelb[0].getunit() : string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show("ProductIDbox查询出错：" + ex.Message);
                }
            }
            Processbox.SelectedValueChanged += Processbox_SelectedValueChanged;
            danjia();
        }



        private void Processbox_SelectedValueChanged(object sender, EventArgs e)
        {
            danjia();

           


        }


        private void danjia()
        {
            ProductIDbox.SelectedValueChanged -= ProductIDbox_SelectedValueChanged;
            Processbox.SelectedValueChanged -= Processbox_SelectedValueChanged;
            Lengthtext.TextChanged -= Lengthtext_TextChanged;
            Widthtext.TextChanged -= Lengthtext_TextChanged;
            UnitPricetext.TextChanged -= Lengthtext_TextChanged;
            Numbertext.TextChanged -= Lengthtext_TextChanged;

            string cpid = ProductIDbox.Text;
            string cpgy = Processbox.Text;

            label17.Text = cpid + cpgy;
            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                ILiteCollection<ProductPrice> product = db.GetCollection<ProductPrice>("ProductPrices");//获取名为CpType的集合 使用 BsonDocument 作为集合中的文档类型  
                ProductPrice productPrice = product.FindOne(x => x.ProductType == cpid && x.Process == cpgy);

                ILiteCollection<Customer> yhdj = db.GetCollection<Customer>("Customers");
                Customer dengji = yhdj.FindOne(x => x.CustomerName == CustomerNamebox.Text);
                int customerLevel = dengji?.getCustomerLevel() ?? 1;//如果获取不到数值，默认等于1

                string unitPriceColumn;

                switch (customerLevel)
                {
                    case 1:
                        unitPriceColumn = "UnitPrice";
                        break;
                    case 2:
                        unitPriceColumn = "UnitPricet";
                        break;
                    case 3:
                        unitPriceColumn = "UnitPrices";
                        break;
                    default:
                        unitPriceColumn = "UnitPrice";
                        break;
                }


                double unitPrice = 0;
                if (unitPriceColumn == "UnitPrices" && productPrice.UnitPrices != 0)
                {
                    unitPrice = productPrice.UnitPrices;
                }
                else if (unitPriceColumn == "UnitPricet" && productPrice.UnitPricet != 0)
                {
                    unitPrice = productPrice.UnitPricet;
                }
                else if (productPrice.UnitPrice != 0)
                {
                    unitPrice = productPrice.UnitPrice;
                }

                label17.Text = "当前用户单价" + unitPrice;
                UnitPricetext.Text = unitPrice.ToString();
            }
            jisuan();
            ProductIDbox.SelectedValueChanged += ProductIDbox_SelectedValueChanged;
            Processbox.SelectedValueChanged += Processbox_SelectedValueChanged;
            Lengthtext.TextChanged += Lengthtext_TextChanged;
            Widthtext.TextChanged += Lengthtext_TextChanged;
            UnitPricetext.TextChanged += Lengthtext_TextChanged;
            Numbertext.TextChanged += Lengthtext_TextChanged;
        }
 

        private void jisuan()//文本框内容改变的时候计算结果
        {
            string cpleixing = ProductIDbox.Text.Trim();
            string cpgongyi = Processbox.Text.Trim();
            double youhui = double.Parse(Discounttext.Text.Trim() != "" ? Discounttext.Text.Trim() : "0");

            // 如果没有选择产品类型、工艺或者数量不是正数，则不进行计算
            if (string.IsNullOrEmpty(cpleixing) || string.IsNullOrEmpty(cpgongyi)
                || !double.TryParse(Numbertext.Text, out double quantity) || quantity <= 0)
            {
                Subtotaltext.Text = "0";
                return;
            }

            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                // 在这里执行数据库操作ProductPrice
                //ILiteCollection<CpType> cpTypeCollection = db.GetCollection<CpType>("CpType");
                //CpType cpType = cpTypeCollection.FindOne(x => x.ProductType == cpleixing);
                //string unitType = cpType?.JijiaFangshi;
                var cpTypeCollection = db.GetCollection<ProductPrice>("ProductPrices");
                ProductPrice cpType = cpTypeCollection.FindOne(x => x.ProductType == cpleixing && x.Process==cpgongyi);
                string unitType = cpType?.JijiaFangshi;

                var  systemSettingsCollection = db.GetCollection<SystemSetting>("SystemSettings");
                SystemSetting systemSettings = systemSettingsCollection.FindOne(x => x.JijiaFangshi == unitType);
                string calculationFormula = systemSettings?.CalculationFormula;

             var  productPricesCollection = db.GetCollection<ProductPrice>("productprices");
                ProductPrice productPrice = productPricesCollection.FindOne(x => x.ProductType == cpleixing && x.Process == cpgongyi);
                double unitPrice = productPrice?.getunitprice() ?? 0;
                double zuidijia = productPrice?.lowprice ?? 0;

                if (calculationFormula != null && double.TryParse(UnitPricetext.Text, out unitPrice))
                {
                    // 解析输入的参数
                    _ = double.TryParse(Lengthtext.Text, out double length);
                    _ = double.TryParse(Widthtext.Text, out double width);

                    if (productPrice != null)
                    {
                        string lwunit = productPrice.getlwunit();
                        danwei.Text = lwunit;
                        danwei1.Text = lwunit;

                        if (lwunit == "厘米" || lwunit == "cm")
                        {
                            length /= 100;
                            width /= 100;
                        }
                        else if (lwunit == "米" || lwunit == "M")
                        {
                            length /= 1;
                            width /= 1;
                        }
                        else if (lwunit == "毫米" || lwunit == "mm")
                        {
                            length /= 1000;
                            width /= 1000;
                        }

                        double da = Math.Max(length, width);
                        double xiao = Math.Min(length, width);
                        length = da;
                        width = xiao;

                        // 替换占位符
                        calculationFormula = calculationFormula.Replace("长", length.ToString()).Replace("宽", width.ToString()).Replace("数量", quantity.ToString()).Replace("单价", unitPrice.ToString()) + "-" + youhui;

                        try
                        {

                            decimal result = decimal.TryParse(new DataTable().Compute(calculationFormula, null)?.ToString(), out decimal tempResult) ? tempResult : 0;

                            //decimal result = new DataTable().Compute(calculationFormula, null) as decimal? ?? 0;

                            double resultDouble = Convert.ToDouble(result);
                            double zuidijiaDouble = Convert.ToDouble(zuidijia);


                            double subtotal = Math.Max(resultDouble, zuidijiaDouble); //取两个数之间的最大数值
                            label16.Text = unitType + calculationFormula + "****" + zuidijiaDouble;
                            // decimal subtotal = Math.Max(result, zuidijia); //取两个数之间的最低价


                            Subtotaltext.Text = subtotal.ToString("F2"); //保留两位小数

                        }

                        catch (Exception ex)
                        {
                            Subtotaltext.Text = "计算错误：" + ex.Message;
                            _ = MessageBox.Show(ex.Message);
                        }

                    }
                }
            }






        }



        private void AddRecordForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                e.Effect = IsImageFile(files) ? DragDropEffects.Copy : DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void AddRecordForm_DragDrop(object sender, DragEventArgs e)
        {

            // 获取拖拽的文件名
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
            _ = fileNames[0];


            // 判断拖拽的数据是否为图像文件
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && IsImageFile((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);

                    filename.Text = fileName;
                    // 加载图像并获取实际尺寸
                    using (Image image = Image.FromFile(file))
                    {
                        int width = image.Width;
                        int height = image.Height;

                        // 获取图像分辨率
                        float dpiX = image.HorizontalResolution;
                        float dpiY = image.VerticalResolution;

                        // 将实际尺寸从像素转换为厘米并四舍五入到整数
                        int widthCm = (int)Math.Round(width / dpiX * 2.54f);
                        int heightCm = (int)Math.Round(height / dpiY * 2.54f);

                        // 更新界面控件
                        Lengthtext.Text = widthCm.ToString();
                        Widthtext.Text = heightCm.ToString();


                    }
                }
            }
        }




        private bool IsImageFile(string[] filePaths)
        {
            foreach (string filePath in filePaths)
            {
                string extension = Path.GetExtension(filePath).ToLower();
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp")
                {
                    return true;
                }
            }
            return false;
        }


        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 获取DataGridView中每列的值

            double total = 0;
            // foreach (DataGridViewRow row in this.dataGridView.Rows)
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                DataGridViewRow rowa = dataGridView.Rows[i];
                //if (!row.IsNewRow && row.Cells[0].Value != null) // 忽略新行和空行
                {
                    total += Convert.ToDouble(rowa.Cells["小计"].Value);
                }
            }
            totalprice.Text = total.ToString() + "元";

        }

        private void dataGridView_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            double total = 0.0;

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                DataGridViewRow rowa = dataGridView.Rows[i];

                {
                    total += Convert.ToDouble(rowa.Cells["小计"].Value);
                }
            }
            totalprice.Text = total.ToString() + "元";
        }

        private void Lengthtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericTextBox_KeyPress(sender, e);
        }//键盘事件控制

         

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)  //键盘事件控制
        {
            // 如果输入的字符不是数字、删除键或小数点，则标记事件为已处理并返回  
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (!(sender is System.Windows.Forms.TextBox textbox))
            {
                return; // Just in case  
            }

            //// 如果文本框的内容为 "0" 并且将要输入的字符不是 '0'，那么直接用输入的字符替换 "0"  
            if (textbox.Text == "0" && e.KeyChar != '0')
            {
                textbox.Text = e.KeyChar.ToString();
                textbox.SelectionStart = 1;
                e.Handled = true;
                return;
            }

            // 如果已经有一个小数点，并且接下来要输入的也是小数点，那么标记事件为已处理并返回  
            if (e.KeyChar == '.' && textbox.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)//关闭按钮
        {
            Close();
        }



        private void CustomerNamebox_TextUpdate(object sender, EventArgs e)//客户名称更新事件
        { 
            


            danjia();

        }


        private void IsPaidbox_SelectedIndexChanged(object sender, EventArgs e)//付款方式状态变更
        {
            paybybox.Enabled = IsPaidbox.Text != "否";
        }

        private void Lengthtext_TextChanged(object sender, EventArgs e)
        {
            jisuan();
        }

   
    }
}
