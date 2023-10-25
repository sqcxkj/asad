namespace 广告账本
{
    partial class guestname
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
            this.nameList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.tuichubtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.ComboBox();
            this.delbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameList
            // 
            this.nameList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.nameList.AllowColumnReorder = true;
            this.nameList.CheckBoxes = true;
            this.nameList.HideSelection = false;
            this.nameList.Location = new System.Drawing.Point(21, 53);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(254, 384);
            this.nameList.TabIndex = 1;
            this.nameList.UseCompatibleStateImageBehavior = false;
            this.nameList.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(369, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 35);
            this.textBox1.TabIndex = 3;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(369, 221);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(256, 35);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "添加";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // tuichubtn
            // 
            this.tuichubtn.Location = new System.Drawing.Point(609, 372);
            this.tuichubtn.Name = "tuichubtn";
            this.tuichubtn.Size = new System.Drawing.Size(110, 41);
            this.tuichubtn.TabIndex = 6;
            this.tuichubtn.Text = "退出";
            this.tuichubtn.UseVisualStyleBackColor = true;
            this.tuichubtn.Click += new System.EventHandler(this.tuichubtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(411, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "客户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(563, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "等级";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 18F);
            this.textBox2.FormattingEnabled = true;
            this.textBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.textBox2.Location = new System.Drawing.Point(550, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 32);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "1";
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(325, 372);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(113, 41);
            this.delbtn.TabIndex = 10;
            this.delbtn.Text = "删除选中记录";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // guestname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 449);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tuichubtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameList);
            this.Name = "guestname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "guestname";
            this.Load += new System.EventHandler(this.guestnameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView nameList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button tuichubtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox textBox2;
        private System.Windows.Forms.Button delbtn;
    }
}