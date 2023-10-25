namespace 广告账本
{
    partial class SystemSettingForm
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
            this.insbtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jjfs = new System.Windows.Forms.ComboBox();
            this.jjgs = new System.Windows.Forms.TextBox();
            this.gsid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flid = new System.Windows.Forms.Label();
            this.spfl = new System.Windows.Forms.TextBox();
            this.jjfs1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gxfl = new System.Windows.Forms.Button();
            this.dw = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bflj = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // insbtn
            // 
            this.insbtn.Location = new System.Drawing.Point(141, 308);
            this.insbtn.Name = "insbtn";
            this.insbtn.Size = new System.Drawing.Size(96, 49);
            this.insbtn.TabIndex = 0;
            this.insbtn.Text = "button1";
            this.insbtn.UseVisualStyleBackColor = true;
            this.insbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(388, 197);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "计价方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "计价公式";
            // 
            // jjfs
            // 
            this.jjfs.FormattingEnabled = true;
            this.jjfs.Items.AddRange(new object[] {
            "面积",
            "长度",
            "周长",
            "数量",
            "空方",
            "项"});
            this.jjfs.Location = new System.Drawing.Point(47, 266);
            this.jjfs.Name = "jjfs";
            this.jjfs.Size = new System.Drawing.Size(71, 20);
            this.jjfs.TabIndex = 5;
            // 
            // jjgs
            // 
            this.jjgs.Location = new System.Drawing.Point(141, 266);
            this.jjgs.Name = "jjgs";
            this.jjgs.Size = new System.Drawing.Size(273, 21);
            this.jjgs.TabIndex = 6;
            // 
            // gsid
            // 
            this.gsid.AutoSize = true;
            this.gsid.Location = new System.Drawing.Point(33, 270);
            this.gsid.Name = "gsid";
            this.gsid.Size = new System.Drawing.Size(0, 12);
            this.gsid.TabIndex = 7;
            this.gsid.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(361, 197);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // flid
            // 
            this.flid.AutoSize = true;
            this.flid.Location = new System.Drawing.Point(484, 270);
            this.flid.Name = "flid";
            this.flid.Size = new System.Drawing.Size(0, 12);
            this.flid.TabIndex = 13;
            this.flid.Visible = false;
            // 
            // spfl
            // 
            this.spfl.Location = new System.Drawing.Point(493, 266);
            this.spfl.Name = "spfl";
            this.spfl.Size = new System.Drawing.Size(183, 21);
            this.spfl.TabIndex = 12;
            // 
            // jjfs1
            // 
            this.jjfs1.FormattingEnabled = true;
            this.jjfs1.Items.AddRange(new object[] {
            "面积",
            "长度",
            "周长",
            "数量",
            "空方",
            "项"});
            this.jjfs1.Location = new System.Drawing.Point(765, 266);
            this.jjfs1.Name = "jjfs1";
            this.jjfs1.Size = new System.Drawing.Size(71, 20);
            this.jjfs1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "商品分类";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "单位";
            // 
            // gxfl
            // 
            this.gxfl.Location = new System.Drawing.Point(578, 308);
            this.gxfl.Name = "gxfl";
            this.gxfl.Size = new System.Drawing.Size(96, 49);
            this.gxfl.TabIndex = 14;
            this.gxfl.Text = "button1";
            this.gxfl.UseVisualStyleBackColor = true;
            this.gxfl.Click += new System.EventHandler(this.gxfl_Click);
            // 
            // dw
            // 
            this.dw.FormattingEnabled = true;
            this.dw.Items.AddRange(new object[] {
            "平方",
            "米",
            "方",
            "个",
            "条",
            "套",
            "项",
            "张",
            "盒"});
            this.dw.Location = new System.Drawing.Point(685, 266);
            this.dw.Name = "dw";
            this.dw.Size = new System.Drawing.Size(71, 20);
            this.dw.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "计价方式";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "备份数据库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bflj
            // 
            this.bflj.AutoSize = true;
            this.bflj.Location = new System.Drawing.Point(117, 403);
            this.bflj.Name = "bflj";
            this.bflj.Size = new System.Drawing.Size(41, 12);
            this.bflj.TabIndex = 18;
            this.bflj.Text = "label6";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(775, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "初始化数据库";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "更改备份路径";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SystemSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(882, 452);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bflj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gxfl);
            this.Controls.Add(this.flid);
            this.Controls.Add(this.spfl);
            this.Controls.Add(this.jjfs1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gsid);
            this.Controls.Add(this.jjgs);
            this.Controls.Add(this.jjfs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.insbtn);
            this.Name = "SystemSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemSettingForm";
            this.Load += new System.EventHandler(this.SystemSettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insbtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox jjfs;
        private System.Windows.Forms.TextBox jjgs;
        private System.Windows.Forms.Label gsid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label flid;
        private System.Windows.Forms.TextBox spfl;
        private System.Windows.Forms.ComboBox jjfs1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button gxfl;
        private System.Windows.Forms.ComboBox dw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label bflj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}