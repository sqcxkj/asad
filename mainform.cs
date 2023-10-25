
using LiteDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace 广告账本
{


    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            // 监听应用程序的FormClosing事件


        }


        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            // 创建一个QueryForm对象，并显示窗口
            AddRecordForm addRecordForm = new AddRecordForm();
            addRecordForm.Show();
        }

        public class Account
        {

            public int AccountID { get; set; } // 在LiteDB中，主键必须是int类型，不能是INTEGER类型  
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

        public class Order    //自定义类 用于订单状态Id 属性为订单的唯一标识，OrderNumber 属性为订单号，CustomerName 属性为客户名称，Status 属性为订单状态。
        {
            public int Id { get; set; }
            public string CustomerName { get; set; }
            public string RecordTime { get; set; }
            public string Status { get; set; }
            public string remark { get; set; }
        }


        private void mainform_Load(object sender, EventArgs e)
        {
             
 
            UpdateListViewTag();

            sx();
            //*******

        }

        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    // 使用当前系统时间更新时间标签的文本
        //    shijian.Text = "当前系统时间：" + DateTime.Now.ToString();
        //}

        private void unpaidListView_DoubleClick(object sender, EventArgs e)


        {
            // 设置双击时选定行的行号，和倍选中的客户名所在列sunitems[1]
            string guestname = unpaidListView.SelectedItems[0].SubItems[1].Text;
            QueryForm queryForm = new QueryForm(guestname);
            queryForm.Show();
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            // 创建一个QueryForm对象，并显示窗口
            QueryForm queryForm = new QueryForm();
            queryForm.Show();
        }

        private void addproduct_Click(object sender, EventArgs e)
        {

            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }



        private void UpdateListViewTag()  //更新数据*************************************
        {


            // 连接到数据库
            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                // 设置ListView控件的View属性为Details
                unpaidListView.View = View.Details;

                // 添加客户名、未结账金额的列
                _ = unpaidListView.Columns.Add("序号", 70, HorizontalAlignment.Left);
                _ = unpaidListView.Columns.Add("客户名", 130, HorizontalAlignment.Left);
                _ = unpaidListView.Columns.Add("未结账金额", 145, HorizontalAlignment.Left);

                // 获取 Accounts 集合
                ILiteCollection<Account> collection = db.GetCollection<Account>("Accounts");

                // 查询未结账客户名、未结账金额的信息
                var query = collection.Find(Query.EQ("IsPaid", "否"))
                       .GroupBy(x => x.CustomerName)
                       .Select(g => new
                       {
                           CustomerName = g.Key,
                           TotalUnpaidAmount = g.Sum(x => x.Subtotal - x.Discount)
                       });

                // 遍历查询结果，将未结账客户名、未结账金额添加到ListView的每一行中
                int serialNumber = 1;
                decimal totalUnpaidAmount = 0.00m;
                foreach (var result in query)
                {
                    ListViewItem item = new ListViewItem(new string[] { serialNumber.ToString(), result.CustomerName, result.TotalUnpaidAmount.ToString("#,##0.00") + "元" })
                    {
                        Tag = result.CustomerName
                    };
                    _ = unpaidListView.Items.Add(item);

                    serialNumber++;
                    //  totalUnpaidAmount = result.TotalUnpaidAmount;
                }

                label1.Text = "当前未结账单总计(￥)：" + totalUnpaidAmount.ToString("#,##0.00");

                // 确保资源被正确释放
                collection = null;
            }


        }

        private void sx()
        {
            // 创建liteDB数据库链接
            string filename = ".\\ldatabase.db";

            using (LiteDatabase db = new LiteDatabase(filename))
            {
                // 获取集合（表）  
                ILiteCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("Accounts");

                // 查询未结账客户名、未结账金额和账单时间的信息  
                System.Collections.Generic.IEnumerable<BsonDocument> query = collection.Find(Query.All());

                query = query.OrderByDescending(x => x["RecordTime"]);

                // 根据选择的选项设置显示的记录数量
                string selectedOption = xsjlsl.Text;
                int recordCount = 30;

                 
                if (selectedOption == "50")
                {
                    recordCount = 50;
                }
                else if (selectedOption == "全部")
                {
                    recordCount = collection.Count();
                }

                query = query.Take(recordCount);

                // 设置ListView控件的View属性为Details  
                listView1.View = View.Details;

                // 添加客户名、未结账金额的列  
                _ = listView1.Columns.Add("序号", 60, HorizontalAlignment.Left);
                _ = listView1.Columns.Add("客户名", 130, HorizontalAlignment.Left);
                _ = listView1.Columns.Add("广告类型", 180, HorizontalAlignment.Left);
                _ = listView1.Columns.Add("尺寸规格", 110, HorizontalAlignment.Left);
                _ = listView1.Columns.Add("小计金额", 80, HorizontalAlignment.Left);
                _ = listView1.Columns.Add("付款状态", 80, HorizontalAlignment.Left);
                _ = listView1.Columns.Add("下单时间", 170, HorizontalAlignment.Left);

                // 遍历查询结果，将未结账客户名、未结账金额添加到ListView的每一行中  
                int serialnew = 1;
                int colornum = 0;

                foreach (BsonDocument document in query)
                {
                    string khm = document["CustomerName"].AsString;
                    string ptn = document["ProductType"].AsString;
                    string ptt = document["Process"].AsString;
                    double len = document["Length"].AsDouble;
                    double wid = document["Width"].AsDouble;
                    double sub = document["Subtotal"].AsDouble;
                    string pay = document["IsPaid"].AsString;
                    string tim = document["RecordTime"].AsString;

                    ListViewItem item = new ListViewItem(new string[] { serialnew.ToString(), khm, ptn + ptt, len.ToString() + " * " + wid.ToString(), sub.ToString(), pay, tim.ToString() });
                    if (sub < 0)
                    {
                        item.BackColor = Color.Red;
                    }
                    else
                    {
                        item.BackColor = pay == "是" ? Color.LightGreen : Color.LightYellow;
                    }

                    _ = listView1.Items.Add(item);

                    serialnew++;
                    colornum++;
                }
            }
        }
        private void addguestname_Click(object sender, EventArgs e)
        {


            // 创建一个QueryForm对象，并显示窗口
            guestname guestname = new guestname();
            guestname.Show();

        }

        private void exitbut_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 退出应用程序


        }

        private void syssetup_Click(object sender, EventArgs e)
        {

            // 创建一个QueryForm对象，并显示窗口
            SystemSettingForm SystemSettingForm = new SystemSettingForm();
            SystemSettingForm.Show();
        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {


            int activeWindowCount = 0;


            // 统计活动窗口数量（除了主窗口）
            foreach (Form form in Application.OpenForms)
            {
                if (form != this && form.Visible)
                {
                    activeWindowCount++;
                }
            }

            // 如果存在多个活动窗口，给出提示并取消关闭操作
            if (activeWindowCount > 0)
            {
                _ = MessageBox.Show("请关闭所有窗口后再关闭主窗口。");
                e.Cancel = true;
                return;
            }
            // 如果没有其他活动窗口，确认退出
            DialogResult result = MessageBox.Show("是否确认退出应用程序？", "确认退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // 退出应用程序
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            unpaidListView.Items.Clear();
            unpaidListView.Columns.Clear(); // 清除表头  

            UpdateListViewTag();
            sx();
            // MessageBox.Show("刷新成功");
        }

        //private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    using (var db = new LiteDatabase("order.db"))
        //    {
        //        var orders = db.GetCollection<Order>("orders");

        //        var form = new AddOrderForm();
        //        if (form.ShowDialog() == DialogResult.OK)
        //        {
        //            var order = new Order
        //            {
        //                //remark = form.remark,
        //               // CustomerName = form.CustomerName,
        //                Status = "新建"
        //            };

        //            orders.Insert(order);

        //            var listViewItem = new ListViewItem(order.Id.ToString());
        //            listViewItem.SubItems.Add(order.CustomerName);
        //            listViewItem.SubItems.Add(order.remark);
        //            listViewItem.SubItems.Add(order.Status);
        //            listView.Items.Add(listViewItem);
        //        }
        //    }
        //}

        //private void OrderContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //    var selectedItems = listView.SelectedItems;
        //    if (selectedItems.Count > 0)
        //    {
        //        var selectedStatus = e.ClickedItem.Text;
        //        var selectedRow = selectedItems[0];
        //        selectedRow.SubItems[2].Text = selectedStatus; // 更新订单状态

        //        // 根据订单状态设置行的背景颜色
        //        switch (selectedStatus)
        //        {
        //            case "新建":
        //                selectedRow.BackColor = Color.LightBlue;
        //                break;
        //            case "接单":
        //                selectedRow.BackColor = Color.Yellow;
        //                break;
        //            case "对接":
        //                selectedRow.BackColor = Color.Orange;
        //                break;
        //            case "作图":
        //                selectedRow.BackColor = Color.Pink;
        //                break;
        //            case "制作":
        //                selectedRow.BackColor = Color.LightGreen;
        //                break;
        //            case "送货":
        //                selectedRow.BackColor = Color.LightGray;
        //                break;
        //            case "完成":
        //                selectedRow.BackColor = Color.LightYellow;
        //                break;
        //        }
        //    }
        //}




        //private void listView_MouseClick(object sender, MouseEventArgs e)
        //{

        //    if (e.Button == MouseButtons.Right)
        //    {
        //        var clickedItem = listView.GetItemAt(e.X, e.Y);
        //        if (clickedItem != null)
        //        {
        //            clickedItem.Selected = true;
        //            OrderContextMenu.Show(listView, e.Location);
        //        }
        //    }
        //}

        //private void OrderContextMenu_Opening(object sender, CancelEventArgs e)
        //{
        //    OrderContextMenu.Items.Clear(); // 清空菜单项

        //    // 添加菜单项
        //    var addOrderMenuItem = OrderContextMenu.Items.Add("新建");
        //    addOrderMenuItem.Click += AddOrderToolStripMenuItem_Click;
        //    OrderContextMenu.Items.Add("接单").Click += HandleStatusMenuItem_Click;
        //    OrderContextMenu.Items.Add("对接").Click += HandleStatusMenuItem_Click;
        //    OrderContextMenu.Items.Add("作图").Click += HandleStatusMenuItem_Click;
        //    OrderContextMenu.Items.Add("制作").Click += HandleStatusMenuItem_Click;
        //    OrderContextMenu.Items.Add("送货").Click += HandleStatusMenuItem_Click;
        //    OrderContextMenu.Items.Add("完成").Click += HandleStatusMenuItem_Click;
        //    // 添加删除菜单项
        //    var selectedItems = listView.SelectedItems;
        //    if (selectedItems.Count > 0)
        //    {
        //        var deleteOrderMenuItem = OrderContextMenu.Items.Add("删除");
        //        deleteOrderMenuItem.Click += DeleteOrderToolStripMenuItem_Click;
        //    }
        //}

        //private void DeleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    // 获取选中的行
        //    ListViewItem selectedRow = listView.SelectedItems[0];

        //    // 获取订单ID
        //    int orderId = int.Parse(selectedRow.SubItems[0].Text);

        //    // 从数据库中删除订单
        //    using (var db = new LiteDatabase(".\\order.db"))
        //    {
        //        ILiteCollection<Order> collection = db.GetCollection<Order>("orders");
        //        collection.Delete(orderId);
        //    }

        //    // 重新加载订单列表
        //    ddzt();
        //}
        //private void HandleStatusMenuItem_Click(object sender, EventArgs e)
        //{
        //    ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
        //    string selectedStatus = menuItem.Text; // 获取选中的菜单项文本

        //    if (listView.SelectedItems.Count > 0)
        //    {
        //        ListViewItem selectedItem = listView.SelectedItems[0];
        //        string orderId = selectedItem.SubItems[0].Text; // 获取选中的订单ID

        //        // 更新订单状态
        //        using (var db = new LiteDatabase(".\\order.db"))
        //        {
        //            ILiteCollection<Order> collection = db.GetCollection<Order>("orders");
        //            Order order = collection.FindOne(x => x.Id.ToString() == orderId);

        //            if (order != null)
        //            {
        //                order.Status = selectedStatus; // 更新订单状态
        //                collection.Update(order); // 更新数据库中的订单数据

        //                // 更新ListView中对应的项的文本内容
        //                selectedItem.SubItems[3].Text = selectedStatus;
        //            }
        //        }
        //    }


        //}
        //private void ddzt()
        //{
        //    listView.Items.Clear();
        //    // 获取订单数据
        //    List<Order> orders = new List<Order>();
        //    using (var db = new LiteDatabase(".\\order.db"))
        //    {
        //        ILiteCollection<Order> collection = db.GetCollection<Order>("orders");
        //        orders = collection.FindAll().ToList();
        //    }

        //    // 设置ListView控件的View属性为Details
        //    listView.View = View.Details;

        //    // 添加列标题
        //    listView.Columns.Add("Id", 40, HorizontalAlignment.Left);
        //    listView.Columns.Add("客户名称", 80, HorizontalAlignment.Left);
        //    listView.Columns.Add("订单描述", 100, HorizontalAlignment.Left);
        //    listView.Columns.Add("当前状态", 100, HorizontalAlignment.Left);

        //    // 遍历订单数据，并将数据添加到ListView
        //    foreach (Order order in orders)
        //    {
        //        ListViewItem item = new ListViewItem(new string[] {
        //    order.Id.ToString(),
        //    order.CustomerName,
        //    order.remark,
        //    order.Status
        //});
        //        listView.Items.Add(item);

        //        // 根据订单状态设置行的背景颜色
        //        switch (order.Status)
        //        {
        //            case "新建":
        //                item.BackColor = Color.GreenYellow;
        //                break;
        //          case "对接":
        //                item.BackColor = Color.Orange;
        //                break;
        //            case "作图":
        //                item.BackColor = Color.Yellow;
        //                break;
        //            case "制作":
        //                item.BackColor = Color.LightGreen;
        //                break;
        //            case "取货":
        //                item.BackColor = Color.LightBlue;
        //                break;
        //            case "完成":
        //                item.BackColor = Color.Green;
        //                break;
        //        }
        //    }
        //}


        //private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        //{

        //    // 获取选中的行
        //    ListViewItem selectedRow = listView.SelectedItems[0];

        //    // 获取订单ID
        //    int orderId = int.Parse(selectedRow.SubItems[0].Text);

        //    // 根据订单ID从数据库中获取订单详细信息
        //    Order order;
        //    using (var db = new LiteDatabase(".\\order.db"))
        //    {
        //        ILiteCollection<Order> collection = db.GetCollection<Order>("orders");
        //        order = collection.FindOne(x => x.Id == orderId);
        //    }

        //    // 构建订单详细信息的字符串
        //    string detailText = $"【订单ID】: {order.Id}\n" +
        //        "-------------\n"+
        //                        $"【客户名称】: {order.CustomerName}\n" +
        //                           "-------------\n" +
        //                        $"【订单描述】: {order.remark}\n" +
        //                           "-------------\n" +
        //                        $"【当前状态】: {order.Status}";

        //    // 弹出消息框显示订单详细信息
        //    // 定义按钮和图标  
        //    MessageBoxButtons buttonStyle = MessageBoxButtons.OK;
        //    MessageBoxIcon iconStyle = MessageBoxIcon.Information;

        //    // 弹出消息框显示订单详细信息  
        //  //  MessageBox.Show(detailText, "订单详细信息", buttonStyle, iconStyle, 0);
        //    MessageBox.Show(detailText, "订单详细信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //      // 获取选中的行
        //    //      ListViewItem selectedRow = listView.SelectedItems[0];

        //    //      // 获取订单ID
        //    //      int orderId = int.Parse(selectedRow.SubItems[0].Text);

        //    //      // 根据订单ID从数据库中获取订单详细信息
        //    //      Order order;
        //    //      using (var db = new LiteDatabase(".\\order.db"))
        //    //      {
        //    //          ILiteCollection<Order> collection = db.GetCollection<Order>("orders");
        //    //          order = collection.FindOne(x => x.Id == orderId);
        //    //      }

        //    //      // 构建订单详细信息的字符串
        //    //      string detailText = $"订单ID: {order.Id}\n" +
        //    //                          $"客户名称: {order.CustomerName}\n" +
        //    //                          $"备注: {order.remark}\n" +
        //    //                          $"当前状态: {order.Status}";

        //    //      // 创建自定义窗口，并设置其属性
        //    //      Form messageBoxForm = new Form();
        //    //      messageBoxForm.StartPosition = FormStartPosition.CenterScreen; // 窗口居中显示
        //    //      messageBoxForm.Text = "订单详细信息";

        //    //      // 添加标签控件，并显示订单详细信息
        //    //      Label messageBoxLabel = new Label();
        //    //      messageBoxLabel.Text = detailText;
        //    //      messageBoxLabel.AutoSize = true;

        //    //      messageBoxLabel.Dock = DockStyle.Fill; // 标签控件填充整个窗口
        //    //      messageBoxLabel.TextAlign = ContentAlignment.MiddleLeft; // 文本居中对齐
        //    //      messageBoxForm.Controls.Add(messageBoxLabel);

        //    //      // 添加确定按钮
        //    //      Button okButton = new Button();
        //    //      okButton.Text = "确定";
        //    //      okButton.Dock = DockStyle.Bottom; // 确定按钮位于窗口底部
        //    //      okButton.Click += (s, ev) => messageBoxForm.Close(); // 点击确定按钮关闭窗口
        //    //      messageBoxForm.Controls.Add(okButton);

        //    //      // 自动调整窗口大小
        //    //      messageBoxForm.AutoSize = true;
        //    //      messageBoxForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        //    ////      messageBoxForm.Size = new Size(400, 200); // 设置窗口大小

            //      // 显示自定义窗口
            //      messageBoxForm.ShowDialog(); // 使用ShowDialog而不是Show，以创建一个模态对话框并等待用户关闭
        //}
    }

}
