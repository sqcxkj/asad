using LiteDB;
using System;

using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace 广告账本
{
    public partial class AddProductForm : Form
    {





        public AddProductForm()
        {
            InitializeComponent();


        }



        
        public class ProductPrice
        {
            public int ID { get; set; }

            [DisplayName("产品类型")]
            public string ProductType { get; set; }

            [DisplayName("工艺流程")]
            public string Process { get; set; }

            [DisplayName("单价")]
            public double UnitPrice { get; set; }

            [DisplayName("单价2")]
            public double UnitPricet { get; set; }

            [DisplayName("单价3")]
            public double UnitPrices { get; set; }

            [DisplayName("单位")]
            public string Unit { get; set; }

            [DisplayName("最低价")]
            public double lowprice { get; set; }

            [DisplayName("计价方式")]
            public string JijiaFangshi { get; set; }

            [DisplayName("尺寸单位")]
            public string lwunit { get; set; }

            public string GetUnit()
            {
                return Unit;
            }

            public double GetUnitPrice()
            {
                return UnitPrice;
            }

            public double GetUnitPrices()
            {
                return UnitPrices;
            }

            public double GetUnitPricet()
            {
                return UnitPricet;
            }
        }
        public class CpType
        {
            public int _id { get; set; }
            public string ProductType { get; set; }
            public string Unit { get; set; }
            public string JijiaFangshi { get; set; }
            public override string ToString()

            {
                return ProductType.ToString();
            }
            public string getunit()
            { return Unit.ToString(); }

            public string getjijiafangshi()
            { return JijiaFangshi.ToString(); }


        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                var productType = db.GetCollection<CpType>("CpType");
                var namelb = productType.FindAll()
                      .Select(doc => new CpType
                      {
                          ProductType = doc.ToString(),

                      })
                    .ToList();


                producttype.DataSource = new BindingList<CpType>(namelb);
                producttype.DisplayMember = ToString();

            }
 
            jilu.Text = "";
            RefreshData();
            //xiala();

        }



        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.RowCount)
            {
                _ = dataGridView.Rows[e.RowIndex];
                // 这里可以处理row的相关操作  
                if (dataGridView.Rows.Count > 0 && dataGridView.Columns.Count > 0)
                {

                    jilu.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    producttype.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Process.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    unitprice.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    unitpricet.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    unitprices.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    Unit.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    lowprice.Text = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    Jijiafangshi.Text = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                    lwunit.Text = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();


                }
                else
                {
                    _ = MessageBox.Show("数据为空");
                }

            }
            else
            {
                // 索引超出范围的错误处理  
                return;

            }

            anniuwenzi();

        }




        private void anniuwenzi()
        {

            if (jilu.Text != "")
            {
                insbtn.Text = "提交更新";
                insbtn.BackColor = Color.LightPink;
                //RefreshData();
            }
            else
            {
                insbtn.Text = "确认添加";
                insbtn.BackColor = Color.LightGreen;
                //  RefreshData();
            }

        }


        private void insbtn_Click(object sender, EventArgs e)//点击按钮
        {
            // string tishi = Text;
            //  Text = tishi + "   【正在执行中】，请稍等>";

            if (jilu.Text != null && jilu.Text != "")
            {
                gx();
            }
            else
            {
                tj();
            }
            //progressForm.Close();
            // Text = tishi;
            anniuwenzi();

        }

        private void gx()
        {
            int cpid = int.Parse(jilu.Text);
            string cplx = producttype.Text;
            string cpgy = Process.Text;
            double cpdj = double.Parse(unitprice.Text);
            double cpdjt = double.Parse(unitpricet.Text);
            double cpdjs = double.Parse(unitprices.Text);
            string cpdw = Unit.Text;
            double cpzdj = double.Parse(lowprice.Text);
            string cplwdw = lwunit.Text;
            string cpjjfs = Jijiafangshi.Text;

            if (producttype.Text == "" || Process.Text == "")
            {
                _ = MessageBox.Show("名称或类型不能为空");
                return;
            }

            //更新数据代码
            string filename = ".\\ldatabase.db";
            using (LiteDatabase db = new LiteDatabase(filename))
            {
                ILiteCollection<ProductPrice> collection = db.GetCollection<ProductPrice>("ProductPrices");
                ProductPrice settingupdate = collection.FindOne(s => s.ID == cpid);
                if (settingupdate != null)
                {

                    settingupdate.ProductType = cplx;
                    settingupdate.Process = cpgy;
                    settingupdate.UnitPrice = cpdj;
                    settingupdate.UnitPricet = cpdjt;
                    settingupdate.UnitPrices = cpdjs;
                    settingupdate.Unit = cpdw;
                    settingupdate.lowprice = cpzdj;
                    settingupdate.lwunit = cplwdw;
                    settingupdate.JijiaFangshi = cpjjfs;
                    bool success = collection.Update(settingupdate);

                    _ = success ? MessageBox.Show("更新成功***") : MessageBox.Show("没有记录被更新。");
                }
                else
                {
                    _ = MessageBox.Show("没有找到指定的设置。");
                }
            }


            RefreshData();

        }
        private void tj()
        {
            string cplx = producttype.Text;
            string cpgy = Process.Text;
            double cpdj = double.Parse(unitprice.Text);
            double cpdjt = double.Parse(unitpricet.Text);
            double cpdjs = int.Parse(unitprices.Text);
            string cpdw = Unit.Text;
            double cpzdj = int.Parse(lowprice.Text);
            string cplwdw = lwunit.Text;
            string cpjjfs = Jijiafangshi.Text;


            if (producttype.Text == "" || Process.Text == "")
            {
                _ = MessageBox.Show("名称或类型不能为空");
                return;
            }


            //插入数据代码
            string filename = ".\\ldatabase.db";//建立数据库链接
            using (LiteDatabase dba = new LiteDatabase(filename))
            {

                ILiteCollection<ProductPrice> collection = dba.GetCollection<ProductPrice>("ProductPrices");
                ProductPrice ProductPricesadd = new ProductPrice
                {
                    // _id = 1,
                    ProductType = cplx,
                    Process = cpgy,
                    UnitPrice = cpdj,
                    UnitPricet = cpdjt,
                    UnitPrices = cpdjs,
                    Unit = cpdw,
                    lowprice = cpzdj,
                    JijiaFangshi = cpjjfs,
                    lwunit = cplwdw

                };

                try
                {

                    // 插入新的CpType对象到集合中    
                    _ = collection.Insert(ProductPricesadd);
                    _ = MessageBox.Show("OK");
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show("插入数据时出错: " + ex.Message);
                }

            }


            RefreshData();

        }




        //private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        if (dataGridView.SelectedRows.Count > 0) // 检查是否有选中的行  
        //        {
        //            // 弹出提示框，询问用户是否确认删除数据  
        //            DialogResult result = MessageBox.Show("确定要删除所有数据吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //            if (result == DialogResult.Yes)
        //            {
        //                foreach (DataGridViewRow selectedRow in dataGridView.SelectedRows)
        //                {
        //                    string productID = selectedRow.Cells[0].Value.ToString();

        //                    using (var db = new LiteDatabase(".\\ldatabase.db"))
        //                    {
        //                        var collection = db.GetCollection<ProductPrice>("ProductPrices");

        //                        bool deleteSuccessful = collection.Delete(productID);

        //                        if (deleteSuccessful)
        //                        {
        //                            MessageBox.Show("操作成功！");
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("操作失败！请重试……");
        //                        }
        //                    }
        //                }

        //                RefreshData();
        //            }
        //        }
        //    }
        //}

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
                {


                    if (dataGridView.SelectedRows.Count > 0) // 检查是否有选中的行  
                    {
                        // 弹出提示框，询问用户是否确认删除数据  
                        DialogResult result = MessageBox.Show("确定要删除所有数据吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            ILiteCollection<ProductPrice> collection = db.GetCollection<ProductPrice>("ProductPrices");
                            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                            string productID = selectedRow.Cells[0].Value.ToString();
                            _ = MessageBox.Show(productID);
                            int id = int.Parse(productID);
                            _ = collection.Delete(id);
                            _ = db.Commit();
                            _ = MessageBox.Show("删除记录成功");
                            // RefreshData();
                        }
                    }

                    // 删除数据后重新获取数据并绑定到DataGridView控件  
                    ILiteCollection<ProductPrice> collectionb = db.GetCollection<ProductPrice>("ProductPrices");
                    System.Collections.Generic.List<ProductPrice> ProductPricedata = collectionb.FindAll().ToList();
                    dataGridView.DataSource = new BindingList<ProductPrice>(ProductPricedata);
                }
            }
            //// 删除数据后重新获取数据并绑定到DataGridView控件
            //using (var db = new LiteDatabase(".\\ldatabase.db"))
            //{
            //    var collection = db.GetCollection<ProductPrice>("ProductPrices");
            //    var ProductPricedata = collection.FindAll().ToList();
            //    dataGridView.DataSource = new BindingList<ProductPrice>(ProductPricedata);
            //}
            RefreshData();
        }

        //private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        //{

        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        if (dataGridView.SelectedRows.Count > 0) // 检查是否有选中的行
        //        {
        //            // 弹出提示框，询问用户是否确认删除数据
        //            DialogResult result = MessageBox.Show("确定要删除所有数据吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //            if (result == DialogResult.Yes)
        //            {
        //                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
        //                string productID = selectedRow.Cells[0].Value.ToString();


        //                using (var db = new LiteDatabase(".\\ldatabase.db"))
        //                {

        //                AA:
        //                    using (SQLiteCommand command = new SQLiteCommand("DELETE FROM ProductPrices WHERE ProductID = @productid", connection))
        //                    {
        //                        _ = command.Parameters.AddWithValue("@productid", productID);
        //                        // command.ExecuteNonQuery();
        //                        int rowsAffected = command.ExecuteNonQuery();

        //                        if (rowsAffected > 0)
        //                        {
        //                            _ = MessageBox.Show("操作成功！");
        //                        }
        //                        else
        //                        {
        //                            _ = MessageBox.Show("操作失败！请重试……");
        //                            goto AA;
        //                        }
        //                    }
        //                    connection.Close();
        //                }

        //                RefreshData();
        //            }
        //        }
        //    }
        //}

        private void RefreshData()//刷新数据记录显示
        {


            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                // 获取ProductPrices集合  
                ILiteCollection<BsonDocument> ProductPrices = db.GetCollection<BsonDocument>("ProductPrices");

                // 获取ProductPrices数据  
                System.Collections.Generic.List<ProductPrice> ProductPricedata = ProductPrices.FindAll()
                    .Select(doc => new ProductPrice
                    {
                        ID = doc["_id"].AsInt32,
                        ProductType = doc["ProductType"].AsString,
                        Process = doc["Process"].AsString,
                        Unit = doc["Unit"].AsString,
                        UnitPrice = doc["UnitPrice"],
                        UnitPricet = doc["UnitPricet"],
                        UnitPrices = doc["Unitprices"],
                        JijiaFangshi = doc["JijiaFangshi"].AsString,
                        lowprice = doc["lowprice"],
                        lwunit = doc["lwunit"].AsString

                    })
                    .ToList();

                // 绑定 DataGridView 控件  
                dataGridView.DataSource = new BindingList<ProductPrice>(ProductPricedata);

            }
            jilu.Text = "";
            producttype.Text = "";
            Process.Text = "";
            unitprice.Text = "0";
            unitpricet.Text = "0";
            unitprices.Text = "0";
            Unit.Text = "平方";
            lowprice.Text = "0";
            lwunit.Text = "cm";
            Jijiafangshi.Text = "面积";
         
        }


        private void xiala()
        {
            string danwei = "";
            string jjfs = "";
            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                System.Collections.Generic.List<CpType> userQuery = db.GetCollection<CpType>("cptype").Find(x => x.ProductType == producttype.Text).ToList();//使用了ToList()方法将查询结果转换为List<CpType>类型，然后再检查该列表中的元素数量。这样就可以正确地使用Count属性并与整数进行比较了。
                                                                                                                                                             // MessageBox.Show(producttype.Text);
                if (userQuery.Count > 0)
                {
                    // 找到了匹配的数据  
                    CpType firstUser = userQuery[0]; // 获取第一条匹配的数据  

                    // 将数据赋值给文本框  
                    danwei = firstUser.Unit;
                    jjfs = firstUser.JijiaFangshi;
                    //lwunit.Text = firstUser.;
                }
                else
                {
                    // 没有找到匹配的数据  
                }
            }
            Unit.Text = danwei;
            Jijiafangshi.Text = jjfs;

        }

        private void producttype_TextUpdate(object sender, EventArgs e)
        {

            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                var productjihe = db.GetCollection<CpType>("Cptype");

                // 获取所选的CpType对象
                CpType selectedType = productjihe.FindOne(x => x.ProductType == producttype.Text);

                // 设置unit.Text、lwunit.Text和jijiafangshi.Text的值
                if (selectedType != null)
                {
                    Unit.Text = selectedType.getunit();
                   // lwunit.Text = selectedType.lwunit;
                    Jijiafangshi.Text = selectedType.getjijiafangshi();
                }
                else
                {
                    // 如果没有找到匹配的CpType对象，可以设置默认值或清空文本框
                    Unit.Text = "平方";
                     lwunit.Text = "cm";
                    Jijiafangshi.Text = "面积";
                }
            }

        }
    }

}
