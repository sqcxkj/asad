using LiteDB;
using System;
using System.ComponentModel;
 
//using System.Text;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
//using System.Reflection;

using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
//using System.Diagnostics;

namespace 广告账本
{
    public partial class SystemSettingForm : Form
    {

 
        public SystemSettingForm()
        {
            InitializeComponent();

        }


        public class CpType
        {
            public int _id { get; set; } // 添加 _id 属性
            public string ProductType { get; set; }
            public string Unit { get; set; }
            public string JijiaFangshi { get; set; }
        }


        public class Account
        {
            [DisplayName("账单序号")]
            public int ID { get; set; }

            [DisplayName("客户名称")]
            public string CustomerName { get; set; }

            [DisplayName("文件名")]
            public string Filename { get; set; }

            [DisplayName("产品类型")]
            public string ProductType { get; set; }

            [DisplayName("工艺流程")]
            public string Process { get; set; }

            [DisplayName("长度")]
            public double Length { get; set; }

            [DisplayName("宽度")]
            public double Width { get; set; }

            [DisplayName("单位")]
            public string Unit { get; set; }

            [DisplayName("单价")]
            public double UnitPrice { get; set; }

            [DisplayName("数量")]
            public int cpNumber { get; set; }

            [DisplayName("小计")]
            public double Subtotal { get; set; }

            [DisplayName("抹零")]
            public double Discount { get; set; }

            [DisplayName("记录时间")]
            public string RecordTime { get; set; }

            [DisplayName("是否结账")]
            public string IsPaid { get; set; }

            [DisplayName("支付方式")]
            public string payby { get; set; }

            [DisplayName("备注说明")]
            public string Remark { get; set; }
        }
        public class Customer
        {
            public int ID { get; set; }
            public string CustomerName { get; set; }
            public int CustomerLevel { get; set; }
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

        public class SystemSetting
        {

            //[BsonId]
            public int _id { get; set; }

            public string CalculationFormula { get; set; }


            //public int SettingID { get; set; }

            public string JijiaFangshi { get; set; }



        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (gsid.Text != "")
            {
                int cpid = int.Parse(gsid.Text);
                string cplx = jjfs.Text;//计价方式
                string cpgy = jjgs.Text;//及加工时
                try
                {
                    string filename = ".\\ldatabase.db";
                    using (LiteDatabase db = new LiteDatabase(filename))
                    {
                        ILiteCollection<SystemSetting> collection = db.GetCollection<SystemSetting>("SystemSettings");
                        SystemSetting setting = collection.FindOne(s => s._id == cpid);

                        if (setting != null)
                        {
                            setting.JijiaFangshi = cplx;
                            setting.CalculationFormula = cpgy;
                            bool success = collection.Update(setting);

                            _ = success ? MessageBox.Show("更新成功***") : MessageBox.Show("没有记录被更新。");
                        }
                        else
                        {
                            _ = MessageBox.Show("没有找到指定的设置。");
                        }
                    }
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }

            }

            else
            {
                string cplx = jjfs.Text;//计价方式
                string cpgy = jjgs.Text;//计价公式
                if (jjfs.Text == "")
                {
                    _ = MessageBox.Show("类型不能为空");
                    return;
                }
                try
                {
                    string filename = ".\\ldatabase.db";
                    using (LiteDatabase dba = new LiteDatabase(filename))
                    {
                        // dba.DropCollection("SystemSettings"); // 方法来删除现有的集合  
                        ILiteCollection<SystemSetting> collection = dba.GetCollection<SystemSetting>("SystemSettings");
                        SystemSetting SystemSettings = new SystemSetting
                        {
                            // _id = 1,
                            CalculationFormula = cpgy,
                            JijiaFangshi = cplx,

                        };
                        // 插入新的CpType对象到集合中    
                        _ = collection.Insert(SystemSettings);
                        _ = MessageBox.Show("OK");
                    }

                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show("发生错误：" + ex.Message);
                }


            }

            gsid.Text = "";

            jjfs.Text = "";
            jjgs.Text = "";
            anniuwenzi();
            RefreshData();



        }

        private void SystemSettingForm_Load(object sender, EventArgs e)
        {
            // 读取备份路径文本文件  
            string backupPath = "";
            if (File.Exists("BackupPath.txt"))
            {
                backupPath = File.ReadAllText("BackupPath.txt");
            }
            bflj.Text = "当前备份路径【" + backupPath+"】";

            RefreshData();
            anniuwenzi();
            anniuwenzit();
            return;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.RowCount)
            {
                //DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                // 这里可以处理row的相关操作  
                if (dataGridView.Rows.Count > 0 && dataGridView.Columns.Count > 0)
                {
                    // DataGridViewCell cell = dataGridView.Rows[e.RowIndex].Cells[0];
                    // MessageBox.Show(cell.Value.ToString());
                    gsid.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();//公式ID
                    jjfs.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();//计价方式
                    jjgs.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();//计价公式

                }
                else
                {
                    _ = MessageBox.Show("DataGridView中没有行或单元格");
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

            if (gsid.Text != "")
            {
                insbtn.Text = "提交更新";
                insbtn.BackColor = Color.LightPink;

            }
            else
            {
                insbtn.Text = "确认添加";
                insbtn.BackColor = Color.LightGreen;

            }

        }

        private void RefreshData()
        {

            // 打开连接

            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))

            {

                // 获取系统设置集合

                ILiteCollection<BsonDocument> systemSettings = db.GetCollection("systemsettings");

                // 获取系统设置数据
                System.Collections.Generic.List<SystemSetting> systemSettingsData = systemSettings.FindAll()
     .Select(doc => new SystemSetting
     {
         _id = doc["_id"].AsInt32,
         CalculationFormula = doc["CalculationFormula"].AsString,
         JijiaFangshi = doc["JijiaFangshi"].AsString,
         // 其他属性
     }).ToList();


                // 获取CpType集合

                ILiteCollection<BsonDocument> cpType = db.GetCollection("CpType");

                // 获取CpType数据

                System.Collections.Generic.List<CpType> cpTypeData = cpType.FindAll()
     .Select(doc => new CpType
     {
         _id = doc["_id"].AsInt32,
         ProductType = doc["ProductType"].AsString,
         Unit = doc["Unit"].AsString,
         JijiaFangshi = doc["JijiaFangshi"].AsString,
         // 其他属性
     }).ToList();

                // 绑定 DataGridView 控件

                dataGridView.DataSource = new BindingList<SystemSetting>(systemSettingsData);
                dataGridView1.DataSource = new BindingList<CpType>(cpTypeData);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount)
            {

                if (dataGridView1.Rows.Count > 0 && dataGridView1.Columns.Count > 0)
                {
                    flid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//分类id
                    jjfs1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();//计价方式
                    spfl.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//商品分类
                    dw.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                else
                {
                    _ = MessageBox.Show("DataGridView1中没有行或单元格");
                }

            }
            else
            {
                // 索引超出范围的错误处理  
                return;
            }
            anniuwenzit();
        }

        private void gxfl_Click(object sender, EventArgs e)    //商品分类
        {
            if (flid.Text != "")
            {

                int cpid = int.Parse(flid.Text); //id
                string cpjjfs = jjfs1.Text; //分类
                string cpfl = spfl.Text;//
                string cpdw = dw.Text;
                try
                {
                    //相关内容给
                    //更新数据代码
                    string filename = ".\\ldatabase.db";
                    using (LiteDatabase db = new LiteDatabase(filename))
                    {
                        ILiteCollection<CpType> collection = db.GetCollection<CpType>("CpType");
                        CpType Product = collection.FindOne(s => s._id == cpid);  //此处要更改id的数据类型为int类型

                        if (Product != null)
                        {
                            Product.ProductType = cpfl;
                            Product.Unit = cpdw;
                            Product.JijiaFangshi = cpjjfs;
                            bool success = collection.Update(Product);

                            _ = success ? MessageBox.Show("更新成功***") : MessageBox.Show("没有记录被更新。");
                        }
                        else
                        {
                            _ = MessageBox.Show("没有找到指定的设置。");
                        }
                    }




                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }


            }
            else
            {
                //_ = flid.Text; //id
                string cpjjfs = jjfs1.Text; //分类
                string cpfl = spfl.Text;//
                string cpdw = dw.Text;



                // 如果输入框为空，且输入的数字不为0，则插入新字符并标记事件为已处理
                if (jjfs1.Text == "")
                {

                    _ = MessageBox.Show("类型不能为空");
                    return;
                }


                //插入数据代码  
                string filename = ".\\ldatabase.db";
                using (LiteDatabase dba = new LiteDatabase(filename))
                {
                    // dba.DropCollection("SystemSettings"); // 方法来删除现有的集合    
                    ILiteCollection<CpType> collection = dba.GetCollection<CpType>("CpType");
                    CpType CpType = new CpType
                    {
                        ProductType = cpfl,
                        Unit = cpdw,
                        JijiaFangshi = cpjjfs
                    };

                    try
                    {
                        // 插入新的CpType对象到集合中      
                        _ = collection.Insert(CpType);
                        _ = MessageBox.Show("OK");
                    }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show("插入数据时出错: " + ex.Message);
                    }
                }



            }
            RefreshData();
            flid.Text = "";
            jjfs1.Text = "";
            spfl.Text = "";
            dw.Text = "";
            anniuwenzit();
        }




        private void anniuwenzit()
        {

            if (flid.Text != "")
            {
                gxfl.Text = "提交更新";
                gxfl.BackColor = Color.LightPink;

            }
            else
            {
                gxfl.Text = "确认添加";
                gxfl.BackColor = Color.LightGreen;

            }

        }



        private void button3_Click(object sender, EventArgs e)
        {

            // 读取备份路径文本文件  
             string backupPath = "";
            //if (File.Exists("BackupPath.txt"))
            //{
            //    backupPath = File.ReadAllText("BackupPath.txt");
            //}

            // 判断备份路径是否为空  
           
                // 如果备份路径为空，显示文件夹选择对话框  
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    // 获取选择的文件夹路径  
                    backupPath = folderBrowser.SelectedPath;

                    // 将备份路径写入文本文件  
                    File.WriteAllText(".\\BackupPath.txt", backupPath);
                }
                else
                {
                    // 用户取消了文件夹选择对话框，不执行备份操作  
                    return;
                }


            
            //if (File.Exists("BackupPath.txt"))
            //{
            //    backupPath = File.ReadAllText("BackupPath.txt");
            //}
            bflj.Text = "当前备份路径【" + backupPath + "】";


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // 定义备份文件的路径  
            string backupFilePath = ".\\ldatabase.db";



            // 读取备份路径文本文件  
            string backupPath = "";
            if (File.Exists("BackupPath.txt"))
            {
                backupPath = File.ReadAllText("BackupPath.txt");
            }

      
            // 获取当前日期时间  
            string dateTimeString = DateTime.Now.ToString("yyyyMMddHHmmss");

 

            // 创建ProcessStartInfo对象，指定要执行的命令  
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C copy \"{backupFilePath}\" \"{backupPath}\\ldatabase_Backup_{dateTimeString}.db\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            // 创建Process对象，并启动进程  
            Process process = new Process { StartInfo = startInfo };
            _ = process.Start();
            process.WaitForExit();

            // 显示备份成功的消息  
            _ = MessageBox.Show("数据库备份成功！");

        }


        private void button2_Click(object sender, EventArgs e)           //初始化数据库表
        {



            string filename = ".\\ldatabase.db";


            using (LiteDatabase db = new LiteDatabase(filename))
            {  // 获取集合（表）  
                _ = db.DropCollection("Accounts");
                ILiteCollection<Account> collection = db.GetCollection<Account>("Accounts");
                // 创建一个新的账户对象  
                Account account = new Account
                {
                    //AccountID = 1, // 这里只是一个示例，你可以根据需求设置其他的值  
                    CustomerName = "散单",
                    Filename = "example.txt",
                    ProductType = "写真",
                    Process = "腹板",
                    Length = 10.0,
                    Width = 5.0,
                    Unit = "cm",
                    UnitPrice = 28,
                    cpNumber = 10,
                    Subtotal = 100.0,
                    Discount = 0,
                    RecordTime = DateTime.Now.ToString(), // 这里只是一个示例，你可以根据需求设置其他的值  
                    IsPaid = "否",
                    payby = "微信", // 这里只是一个示例，你可以根据需求设置其他的值  
                    Remark = "备注文字内容."
                };
                // 插入新的账户到集合中  
                _ = collection.Insert(account);
                _ = MessageBox.Show("OK");
            }



            using (LiteDatabase dba = new LiteDatabase(filename))
            {
                _ = dba.DropCollection("CpType"); // 方法来删除现有的集合  
                ILiteCollection<CpType> collection = dba.GetCollection<CpType>("CpType");
                CpType cpType = new CpType
                {
                    _id = 1, // 设置 _id 属性的值
                    ProductType = "喷绘",
                    Unit = "平方",
                    JijiaFangshi = "面积"
                };
                // 插入新的CpType对象到集合中    
                _ = collection.Insert(cpType);
                _ = MessageBox.Show("OK");
            }

            using (LiteDatabase dba = new LiteDatabase(filename))
            {
                _ = dba.DropCollection("Customers"); // 方法来删除现有的集合  
                ILiteCollection<Customer> collection = dba.GetCollection<Customer>("Customers");
                Customer customer = new Customer
                {
                    ID = 1,
                    CustomerName = "散单",
                    CustomerLevel = 1

                };
                // 插入新的CpType对象到集合中    
                _ = collection.Insert(customer);
                _ = MessageBox.Show("OK");
            }


            using (LiteDatabase dba = new LiteDatabase(filename))
            {
                _ = dba.DropCollection("ProductPrices"); // 方法来删除现有的集合  
                ILiteCollection<ProductPrice> collection = dba.GetCollection<ProductPrice>("ProductPrices");
                ProductPrice ProductPrices = new ProductPrice
                {
                    ID = 1,
                    ProductType = "喷绘",
                    Process = "三旗布",
                    UnitPrice = 7,
                    UnitPricet = 0,
                    UnitPrices = 0,
                    Unit = "平方",
                    lowprice = 0,
                    JijiaFangshi = "面积",
                    lwunit = "cm"

                };
                // 插入新的CpType对象到集合中    
                _ = collection.Insert(ProductPrices);
                _ = MessageBox.Show("OK");
            }



            using (LiteDatabase dba = new LiteDatabase(filename))
            {
                _ = dba.DropCollection("SystemSettings"); // 方法来删除现有的集合  
                ILiteCollection<SystemSetting> collection = dba.GetCollection<SystemSetting>("SystemSettings");
                SystemSetting SystemSettings = new SystemSetting
                {
                    _id = 1,
                    CalculationFormula = "长*数量*单价",
                    JijiaFangshi = "长度",

                };
                // 插入新的CpType对象到集合中    
                _ = collection.Insert(SystemSettings);
                _ = MessageBox.Show("OK");
            }








        }

    }

}
