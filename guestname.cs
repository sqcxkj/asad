using LiteDB;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Windows.Forms;
using static 广告账本.SystemSettingForm;

namespace 广告账本
{
    public partial class guestname : Form
    {
        public guestname()
        {
            InitializeComponent();
        }


        private void guestnameForm_Load(object sender, System.EventArgs e)
        {

            RefreshListView();

            //// 设置 ListView 控件的 View 属性为 Details
            //nameList.View = View.Details;

            //// 添加客户名、未结账金额和序号的列
            //_ = nameList.Columns.Add("序号", 60, HorizontalAlignment.Left);
            //_ = nameList.Columns.Add("客户名", 90, HorizontalAlignment.Left);
            //_ = nameList.Columns.Add("等级", 60, HorizontalAlignment.Left);

            //// 查询客户名信息

            //SQLiteDataReader reader = command.ExecuteReader();
            //// 遍历查询结果，将未结账客户名、未结账金额添加到 ListView 的每一行中
            //int serialNumber = 1;

            //while (reader.Read())
            //{
            //    string guestName = reader.GetString(0);
            //    string level = reader.GetString(1);

            //    ListViewItem item = new ListViewItem(new string[] { serialNumber.ToString(), guestName, level })
            //    {
            //        Tag = guestName
            //    };
            //    _ = nameList.Items.Add(item);

            //    serialNumber++;
            //}
            //label1.Text = "客户名称列表";




        }

        private void addbtn_Click(object sender, System.EventArgs e)
        {
            string customerName = textBox1.Text;
            int customerLevel = int.Parse(textBox2.Text);


            try
            {
                if (string.IsNullOrWhiteSpace(customerName))
                {
                    _ = MessageBox.Show("客户名称不能为空");
                    return;
                }

                using (LiteDatabase dba = new LiteDatabase(".\\ldatabase.db"))
                {
                    ILiteCollection<Customer> collection = dba.GetCollection<Customer>("Customers");

                    // 检查用户名是否已存在
                    if (collection.Exists(Query.EQ("CustomerName", customerName)))
                    {
                        _ = MessageBox.Show("用户名已存在");
                        return;
                    }

                    Customer customer = new Customer
                    {
                        CustomerName = customerName,
                        CustomerLevel = customerLevel
                    };

                    _ = collection.Insert(customer);

                    _ = MessageBox.Show("添加成功");
                }

                RefreshListView();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("添加失败：" + ex.Message);
            }
        }
        private void RefreshListView()
        {
            nameList.Items.Clear();
            nameList.Columns.Clear(); // 清除现有的列

            // 设置 ListView 控件的 View 属性为 Details
            nameList.View = View.Details;

            // 添加客户名、等级和序号的列
            _ = nameList.Columns.Add("序号", 60, HorizontalAlignment.Left);
            _ = nameList.Columns.Add("客户名", 90, HorizontalAlignment.Left);
            _ = nameList.Columns.Add("等级", 60, HorizontalAlignment.Left);

            // 查询客户名信息
            using (LiteDatabase dba = new LiteDatabase(".\\ldatabase.db"))
            {
                ILiteCollection<Customer> collection = dba.GetCollection<Customer>("Customers");
                List<Customer> customers = collection.FindAll().ToList();

                int serialNumber = 1;

                foreach (Customer customer in customers)
                {
                    ListViewItem item = new ListViewItem(new string[] { serialNumber.ToString(), customer.CustomerName, customer.CustomerLevel.ToString() })
                    {
                        Tag = customer.CustomerName
                    };
                    _ = nameList.Items.Add(item);

                    serialNumber++;
                }
            }
        }

        private void tuichubtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void delbtn_Click(object sender, EventArgs e)
        {
            List<string> customerNamesToDelete = new List<string>();
            List<string> customerNamesInDatabase = new List<string>();

            // 遍历 ListView 中的所有项    
            for (int i = nameList.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = nameList.Items[i];

                // 检查项的复选框是否被选中    
                if (item.Checked)
                {
                    // 从 ListView 中获取 CustomerName    
                    string customerName = item.SubItems[1].Text; // 假设第一列是 CustomerName    

                    // 添加需要删除的客户名称到列表中    
                    customerNamesToDelete.Add(customerName);

                    // 从数据库中获取 customerName 对应的 ID    
                    string id = item.SubItems[0].Text; // 假设第一列是 ID  
                    customerNamesInDatabase.Add(id);

                    // 删除 ListView 中的项    
                    nameList.Items.Remove(item);
                }
            }

            // 从数据库中删除选中的客户记录    
            DeleteCustomersFromDatabase(customerNamesToDelete);
        }

        private void DeleteCustomersFromDatabase(List<string> customerNamesToDelete)
        {
            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                ILiteCollection<Customer> customers = db.GetCollection<Customer>("Customers");
                ILiteCollection<Account> accountsCollection = db.GetCollection<Account>("accounts");

                //循环遍历 customerNamesToDelete 列表，删除每一个顾客        
                foreach (string name in customerNamesToDelete)
                {
                    string customerName = name; //给 customerName 赋值      
                    Account customerToCheck = accountsCollection.Find(x => x.CustomerName == customerName).FirstOrDefault();

                    // 如果 customerToCheck 不为 null，说明在 Customers 表中存在匹配的记录          
                    if (customerToCheck != null)
                    {   //如果这个顾客在 accounts 表中不存在记录，就可以删除      

                        _ = MessageBox.Show($"顾客 {customerName} 在 Customers 表中存在记录。");
                    }
                    else
                    {
                        _ = customers.DeleteMany(x => x.CustomerName == customerName);
                        _ = MessageBox.Show($"顾客 {customerName} 删除成功");
                    }
                }
            }
            RefreshListView();
        }


    }
}
