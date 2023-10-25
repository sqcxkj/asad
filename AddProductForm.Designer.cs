namespace 广告账本
{
    partial class AddProductForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.insbtn = new System.Windows.Forms.Button();
            this.Process = new System.Windows.Forms.ComboBox();
            this.unitprice = new System.Windows.Forms.TextBox();
            this.lowprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Jijiafangshi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unitpricet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.unitprices = new System.Windows.Forms.TextBox();
            this.lwunit = new System.Windows.Forms.ComboBox();
            this.lwunitss = new System.Windows.Forms.Label();
            this.jilu = new System.Windows.Forms.Label();
            this.producttype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(28, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1030, 348);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // insbtn
            // 
            this.insbtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insbtn.Location = new System.Drawing.Point(944, 399);
            this.insbtn.Name = "insbtn";
            this.insbtn.Size = new System.Drawing.Size(99, 47);
            this.insbtn.TabIndex = 4;
            this.insbtn.Text = "添加商品";
            this.insbtn.UseVisualStyleBackColor = false;
            this.insbtn.Click += new System.EventHandler(this.insbtn_Click);
            // 
            // Process
            // 
            this.Process.FormattingEnabled = true;
            this.Process.Location = new System.Drawing.Point(189, 425);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(144, 20);
            this.Process.TabIndex = 6;
            // 
            // unitprice
            // 
            this.unitprice.Location = new System.Drawing.Point(362, 425);
            this.unitprice.Name = "unitprice";
            this.unitprice.Size = new System.Drawing.Size(66, 21);
            this.unitprice.TabIndex = 7;
            // 
            // lowprice
            // 
            this.lowprice.Location = new System.Drawing.Point(612, 425);
            this.lowprice.Name = "lowprice";
            this.lowprice.Size = new System.Drawing.Size(58, 21);
            this.lowprice.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "工艺/规格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "单价";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "单位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "最低价";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "计价方式";
            // 
            // Unit
            // 
            this.Unit.FormattingEnabled = true;
            this.Unit.Items.AddRange(new object[] {
            "平方",
            "米",
            "方",
            "张",
            "盒",
            "个",
            "套",
            "项",
            "次"});
            this.Unit.Location = new System.Drawing.Point(690, 425);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(54, 20);
            this.Unit.TabIndex = 17;
            this.Unit.Text = "平方";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1060, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Jijiafangshi
            // 
            this.Jijiafangshi.FormattingEnabled = true;
            this.Jijiafangshi.Items.AddRange(new object[] {
            "面积",
            "长度",
            "数量",
            "周长"});
            this.Jijiafangshi.Location = new System.Drawing.Point(775, 425);
            this.Jijiafangshi.Name = "Jijiafangshi";
            this.Jijiafangshi.Size = new System.Drawing.Size(54, 20);
            this.Jijiafangshi.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "单价2";
            // 
            // unitpricet
            // 
            this.unitpricet.Location = new System.Drawing.Point(442, 425);
            this.unitpricet.Name = "unitpricet";
            this.unitpricet.Size = new System.Drawing.Size(66, 21);
            this.unitpricet.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(541, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "单价3";
            // 
            // unitprices
            // 
            this.unitprices.Location = new System.Drawing.Point(525, 425);
            this.unitprices.Name = "unitprices";
            this.unitprices.Size = new System.Drawing.Size(66, 21);
            this.unitprices.TabIndex = 22;
            // 
            // lwunit
            // 
            this.lwunit.FormattingEnabled = true;
            this.lwunit.Items.AddRange(new object[] {
            "米",
            "厘米",
            "M",
            "cm"});
            this.lwunit.Location = new System.Drawing.Point(855, 425);
            this.lwunit.Name = "lwunit";
            this.lwunit.Size = new System.Drawing.Size(54, 20);
            this.lwunit.TabIndex = 25;
            // 
            // lwunitss
            // 
            this.lwunitss.AutoSize = true;
            this.lwunitss.Location = new System.Drawing.Point(859, 397);
            this.lwunitss.Name = "lwunitss";
            this.lwunitss.Size = new System.Drawing.Size(53, 12);
            this.lwunitss.TabIndex = 24;
            this.lwunitss.Text = "尺寸单位";
            // 
            // jilu
            // 
            this.jilu.AutoSize = true;
            this.jilu.Location = new System.Drawing.Point(26, 334);
            this.jilu.Name = "jilu";
            this.jilu.Size = new System.Drawing.Size(0, 12);
            this.jilu.TabIndex = 26;
            // 
            // producttype
            // 
            this.producttype.FormattingEnabled = true;
            this.producttype.Location = new System.Drawing.Point(28, 425);
            this.producttype.Name = "producttype";
            this.producttype.Size = new System.Drawing.Size(144, 20);
            this.producttype.TabIndex = 27;
            this.producttype.Text = "喷绘";
            this.producttype.SelectedValueChanged += new System.EventHandler(this.producttype_TextUpdate);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 458);
            this.Controls.Add(this.producttype);
            this.Controls.Add(this.jilu);
            this.Controls.Add(this.lwunit);
            this.Controls.Add(this.lwunitss);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.unitprices);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.unitpricet);
            this.Controls.Add(this.Jijiafangshi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lowprice);
            this.Controls.Add(this.unitprice);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.insbtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加商品";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button insbtn;
        private System.Windows.Forms.ComboBox Process;
        private System.Windows.Forms.TextBox unitprice;
        private System.Windows.Forms.TextBox lowprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Unit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox Jijiafangshi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox unitpricet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox unitprices;
        private System.Windows.Forms.ComboBox lwunit;
        private System.Windows.Forms.Label lwunitss;
        private System.Windows.Forms.Label jilu;
        private System.Windows.Forms.ComboBox producttype;
    }
}