using LiteDB;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.ComponentModel;
 
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static OfficeOpenXml.ExcelErrorValue;
using static 广告账本.SystemSettingForm;

namespace 广告账本
{
    public partial class QueryForm : Form
    {
          
        private readonly string guestName;


        public QueryForm()
        {
            InitializeComponent();
            // 设置许可证上下文

        }



        // 接受一个参数的构造函数，用于从父窗体传递查询条件
        public QueryForm(string condition) : this()
        {
            // 初始化 _guestName 字段
            guestName = condition;

            // 在此处使用传入的查询条件初始化各个控件
            CustomerNamebox.Text = guestName;

            // ...
        }
        // 窗体加载事件
        private void QueryForm_Load(object sender, EventArgs e)
        {
            RefreshData();
            jisuan();

        }

         


        private void searchButton_Click(object sender, EventArgs e)
        {//查询全部
         // 创建一个连接到Access数据库的连接对象
         //SQLiteConnection connection = new SQLiteConnection("Data Source=.\\Database.db;Version=3;");

            // 打开数据库连接
            // connection.Open();
            string customerName = CustomerNamebox.Text;


            // 获取数据并绑定到DataGridView控件

            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                ILiteCollection<Account> collection = db.GetCollection<Account>("Accounts");
                ILiteQueryable<Account> query = collection.Query().Where(a => a.CustomerName == customerName);
                System.Collections.Generic.List<Account> Accountsdata = query.ToList();

                //清空DataGridView原有数据
                //将查询结果绑定到DataGridView
                if (dataGridView.DataSource != null)
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                }


                dataGridView.DataSource = new BindingList<Account>(Accountsdata);
            }

            quanbu();


        }

         private void button1_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            string customerName = CustomerNamebox.Text;
            // 打开“另存为”文件对话框
            string fileName = $"{customerName}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel 文件 (*.xlsx)|*.xlsx|所有文件 (*.*)|*.*",
                FileName = fileName
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 创建 Excel 文件
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // 添加一个工作表
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    // 添加自定义标题
                    var range = worksheet.Cells[1, 1, 1, 16]; //定义你想合并的范围  
                    range.Merge = true; //合并单元格

                    worksheet.Cells[1, 1].Value = customerName+" :  "+ totalprice.Text;
                    // 设置合并后单元格的样式  
                    worksheet.Cells[1, 1].Style.Font.Name = "Arial";
                    worksheet.Cells[1, 1].Style.Font.Size = 18;
                    worksheet.Cells[1, 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    //worksheet.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(250, 250, 250));
                    worksheet.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[1, 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                    worksheet.Cells[2, 1, 2, 16].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    var border = worksheet.Cells[2, 1, 2, 16].Style.Border;
                    border.Left.Style = ExcelBorderStyle.Thin;
                    border.Right.Style = ExcelBorderStyle.Thin;
                    border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    worksheet.Cells[2, 1, 2, 16].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(245, 245,245));

                    // 写入列标题
                    int columnIndex = 1;
                    foreach (DataGridViewColumn dgvColumn in dataGridView.Columns)
                    {
                        if (!dgvColumn.Visible)
                        {
                            continue;
                        }

                        worksheet.Cells[2, columnIndex].Value = dgvColumn.HeaderText;
                        columnIndex++;
                    }

                    // 写入数据行
                    int rowIndex = 3;
                    foreach (DataGridViewRow dgvRow in dataGridView.Rows)
                    {
                        if (!dgvRow.IsNewRow)
                        {
                            columnIndex = 1;

                            foreach (DataGridViewCell cell in dgvRow.Cells)
                            {
                                if (cell.ColumnIndex >= dataGridView.Columns.Count || !dataGridView.Columns[cell.ColumnIndex].Visible)
                                {
                                    continue;
                                }

                                //  worksheet.Cells[rowIndex, columnIndex].Value = cell.Value;
                                // 复制单元格的值和样式
                                worksheet.Cells[rowIndex, columnIndex].Value = cell.Value;
                                worksheet.Cells[rowIndex, columnIndex].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                  border = worksheet.Cells[rowIndex, columnIndex].Style.Border;
                                border.Left.Style =  ExcelBorderStyle.Thin;
                                border.Right.Style = ExcelBorderStyle.Thin;
                                border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                                border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                                worksheet.Column(columnIndex).AutoFit();
                                worksheet.Cells[rowIndex, 1].Value = rowIndex-2;
                                columnIndex++;
                            }

                            rowIndex++;
                        }
                    }

                    // 设置单元格样式
                    //using (ExcelRange range = worksheet.Cells[1, 1, rowIndex - 1, columnIndex - 1])
                    //{
                    //    range.Style.Font.Bold = true;
                    //    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //    range.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                    //    range.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    //}

                    // 保存 Excel 文件
                    FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(excelFile);
                }

                _ = MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


       

        private void closebut_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                string zhuangtai = dataGridView.Rows[0].Cells[13].Value?.ToString();
                if (string.IsNullOrEmpty(zhuangtai))
                {
                    MessageBox.Show("状态为空。");
                    return;
                }

                using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
                {
                    ILiteCollection<Account> collection = db.GetCollection<Account>("accounts");
                    DialogResult result = MessageBox.Show("确定要删除所有数据吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (row.Cells["CustomerName"].Value != null && row.Cells["RecordTime"].Value != null)
                            {
                                string customerName = row.Cells["CustomerName"].Value.ToString();
                                string recordTime = row.Cells["RecordTime"].Value.ToString();
                                System.Collections.Generic.IEnumerable<Account> documentToDelete = collection.Find(x => x.CustomerName == customerName && x.RecordTime == recordTime && x.IsPaid == zhuangtai);
                                if (documentToDelete != null)
                                {
                                    foreach (Account document in documentToDelete)
                                    {
                                        _ = collection.Delete(document.ID);
                                    }
                                }
                            }
                        }

                        dataGridView.DataSource = null;
                        dataGridView.Rows.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("DataGridView没有任何行数据。");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string customerName = CustomerNamebox.Text;
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("请输入客户名称。");
                return;
            }

            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                ILiteCollection<Account> collection = db.GetCollection<Account>("Accounts");
                ILiteQueryable<Account> query = collection.Query().Where(a => a.CustomerName == customerName && a.IsPaid == "否");
                System.Collections.Generic.List<Account> Accountsdata = query.ToList();
                dataGridView.DataSource = new BindingList<Account>(Accountsdata);
            }

            jisuan();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string customerName = CustomerNamebox.Text;
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("请输入客户名称。");
                return;
            }

            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                ILiteCollection<Account> collection = db.GetCollection<Account>("Accounts");
                ILiteQueryable<Account> query = collection.Query().Where(a => a.CustomerName == customerName && a.IsPaid == "是");
                System.Collections.Generic.List<Account> Accountsdata = query.ToList();

                //清空DataGridView原有数据
                if (dataGridView.DataSource != null)
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                }

                //将查询结果绑定到DataGridView
                dataGridView.DataSource = new BindingList<Account>(Accountsdata);
            }

            yijie();
        }
        

        private void CustomerNamebox_MouseClick(object sender, MouseEventArgs e)//建立客户姓名下拉列表
        { // 使用 LiteDatabase 类创建一个新的数据库连接实例，连接到一个名为 ldatabase.db 的文件数据库  
          // 数据库的连接被封装在一个 using 语句块中，这意味着在代码执行完毕后，数据库连接将会被自动关闭  
            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                // 通过数据库连接获取一个名为 "Customer" 的集合（类似于传统数据库中的表）  
                // LiteDatabase 使用 BsonDocument 作为集合中的文档类型  
                ILiteCollection<BsonDocument> namelist = db.GetCollection<BsonDocument>("Customers");

                // 使用 FindAll() 方法查询 "Customer" 集合中的所有文档（也就是所有客户）  
                // 然后通过 Select() 方法将每个文档转换为一个新的 Customer 对象  
                // 这个 Customer 对象中的 CustomerName 属性被设置为原文档中 "CustomerName" 字段的值  
                // 其他属性...则被设置为原文档的其他字段的值（具体哪些字段取决于 Customer 类的定义）  
                System.Collections.Generic.List<Customer> typelist = namelist.FindAll()
                    .Select(doc => new Customer
                    {
                        CustomerName = doc["CustomerName"].AsString,  //从集合DOC中获取相应字段的值    
                                                                      // other properties...    
                    })
                    .ToList();

                // 将得到的 Customer 对象列表赋值给 CustomerNamebox 的 DataSource 属性  
                // 这意味着 CustomerNamebox 将展示这个列表中的所有 Customer 对象  
                CustomerNamebox.DataSource = new BindingList<Customer>(typelist);

                // 设置 CustomerNamebox 的 DisplayMember 属性为 "CustomerName"  
                // 这意味着在 CustomerNamebox 中将显示每个 Customer 对象的 CustomerName 属性的值，而不是显示整个 Customer 对象  
                CustomerNamebox.DisplayMember = "CustomerName"; // 设置在列表中显示的成员    
                                                                //  producttype.ValueMember = "_id"; // 设置作为实际值的成员    

            }


        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.RowCount)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                jilu.Text = row.Cells[0].Value?.ToString();
                yi.Text = row.Cells[1].Value?.ToString();
                er.Text = row.Cells[2].Value?.ToString();
                san.Text = row.Cells[3].Value?.ToString() + "-" + row.Cells[4].Value?.ToString();
                si.Text = row.Cells[5].Value?.ToString();
                wu.Text = row.Cells[6].Value?.ToString();
                liu.Text = row.Cells[7].Value?.ToString();
                qi.Text = row.Cells[8].Value?.ToString();
                ba.Text = row.Cells[9].Value?.ToString();
                jiu.Text = row.Cells[10].Value?.ToString();
                shi.Text = row.Cells[11].Value?.ToString();
                shiyi.Text = row.Cells[12].Value?.ToString();
                IsPaidbox.Text = row.Cells[13].Value?.ToString();
                paybybox.Text = row.Cells[14].Value?.ToString();
                marktxt.Text = row.Cells[15].Value?.ToString();

            }
            else
            {
                _ = MessageBox.Show("数据为空或索引超出范围");
            }

           

        }

        private void updatebtn_Click(object sender, EventArgs e)//更新数据到数据库并刷新界面
        {



            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                ILiteCollection<Account> collection = db.GetCollection<Account>("accounts");
                Account setting = collection.FindOne(s => s.ID == int.Parse(jilu.Text));

                if (setting != null)
                {
                    setting.IsPaid = IsPaidbox.Text;
                    setting.payby = paybybox.Text;
                    setting.Subtotal = double.Parse(jiu.Text);
                    setting.Discount = double.Parse(shi.Text);

                    bool success = collection.Update(setting);

                    _ = success ? MessageBox.Show("更新成功***") : MessageBox.Show("没有记录被更新。");
                }
                else
                {
                    _ = MessageBox.Show("没有找到指定的设置。");
                }
            }


            RefreshData();

        }

        private void button4_Click(object sender, EventArgs e)
        {


            // 删除数据后重新获取数据并绑定到DataGridView控件
            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                ILiteCollection<Account> collection = db.GetCollection<Account>("Accounts");
                System.Collections.Generic.List<Account> Accountsdata = collection.FindAll().ToList();
                //清空DataGridView原有数据
                //将查询结果绑定到DataGridView
                if (dataGridView.DataSource != null)
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                }
                dataGridView.DataSource = new BindingList<Account>(Accountsdata);
            }

             

            // 关闭数据库连接

            quanbu();
        }

        private void RefreshData()//刷新数据记录显示
        {
            _ = CustomerNamebox.Text;


            string customerName = CustomerNamebox.Text;
            using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
            {
                ILiteCollection<Account> collection = db.GetCollection<Account>("Accounts");
                //var query = collection.Query().Where(a => a.CustomerName == customerName && a.IsPaid == "是");
                ILiteQueryable<Account> query = collection.Query().Where(a => a.CustomerName == customerName);
                System.Collections.Generic.List<Account> Accountsdata = query.ToList();

                //清空DataGridView原有数据

                if (dataGridView.DataSource != null)
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                }
                //将查询结果绑定到DataGridView
                dataGridView.DataSource = new BindingList<Account>(Accountsdata);

            }

            dataGridView.CellFormatting += DataGridView_CellFormatting;

            
            jisuan();
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.RowCount - 1)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                string pay = row.Cells[13].Value.ToString();
                int zongji;
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                if (int.TryParse(row.Cells[10].Value.ToString(), out zongji))
                {
                    // 解析成功，执行相应的操作
                    if (pay == "是")
                    {
                        cellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        cellStyle.BackColor = Color.LightYellow;
                    }

                    if (zongji < 0)
                    {
                        cellStyle.BackColor = Color.Red;
                    }

                }
                else
                {
                    // 解析失败，执行相应的错误处理
                    if (pay == "是")
                    {
                        cellStyle.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        cellStyle.BackColor = Color.LightYellow;
                    }
                }

                row.DefaultCellStyle = cellStyle;
            }
        }
        private void dataGridView_KeyDown(object sender, KeyEventArgs e)//删除选中行
        {
            if (e.KeyCode == Keys.Delete)
            {
                // 弹出提示框，询问用户是否确认删除数据
                DialogResult result = MessageBox.Show("确定要删除所有数据吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {

                    // return;

                }
                else
                {
                    // 获取选中的行  
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                    // 获取需要删除的数据  
                    string recordtime = selectedRow.Cells[12].Value.ToString();
                    //dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                    // 创建一个连接到Access数据库的连接对象  
                    using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
                    {

                        ILiteCollection<Account> collection = db.GetCollection<Account>("accounts");

 
                        // 删除Accounts表中符合条件的记录  
                        System.Collections.Generic.IEnumerable<Account> documentToDelete = collection.Find(x => x.RecordTime == recordtime);
                        if (documentToDelete != null)
                        {
                            _ = collection.DeleteMany(x => x.RecordTime == recordtime);
                            _ = MessageBox.Show("删除成功");
                        }

                    }


 

                }

            }
            RefreshData();
        }

        private void jisuan()
        {
            int hanng = 0;
            double total = 0.0;
            double totalyh = 0.0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            { 
                hanng++;
               
                string pay = row.Cells[13].Value?.ToString();
                
                if (pay == "否")
                {
                    total += Convert.ToDouble(row.Cells["subtotal"].Value);
                    totalyh += Convert.ToDouble(row.Cells["discount"].Value);
                }

             
            }

            totalprice.Text = "合计未结账：" + (total - totalyh).ToString() + "元";
        }
        private void yijie()
        {
            int hanng = 0;
            double total = 0.0;
            double totalyh = 0.0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                hanng++;

                string pay = row.Cells[13].Value?.ToString();

                if (pay == "是")
                {
                    total += Convert.ToDouble(row.Cells["subtotal"].Value);
                    totalyh += Convert.ToDouble(row.Cells["discount"].Value);
                }


            }

            totalprice.Text = "已结账单共计：" + (total - totalyh).ToString() + "元";
        }

        private void quanbu()
        {
            int hanng = 0;
            double total = 0.0;
            double totalyh = 0.0;

            double total1 = 0.0;
            double totalyh1 = 0.0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                hanng++;

                string pay = row.Cells[13].Value?.ToString();

                if (pay == "否")
                {
                    total += Convert.ToDouble(row.Cells["subtotal"].Value);
                    totalyh += Convert.ToDouble(row.Cells["discount"].Value);
                }
                else
                {
                    total1 += Convert.ToDouble(row.Cells["subtotal"].Value);
                    totalyh1 += Convert.ToDouble(row.Cells["discount"].Value);
                }

            }

            totalprice.Text = "账单总计：" + (total - totalyh+ total1 - totalyh1) + "元  未结："+(total - totalyh)+"元  已结："+(total1 - totalyh1)+"元" ;
        }




        private void IsPaidbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            paybybox.Enabled = IsPaidbox.Text != "否";
        }

        private void yi_TextChanged(object sender, EventArgs e)
        {
            if (yi.Text != "")
            {
                updatebtn.Enabled = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定一键批量结账吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {

                // return;

            }
            else
            {

                // 创建一个连接到Access数据库的连接对象  
                using (LiteDatabase db = new LiteDatabase(".\\ldatabase.db"))
                {
                    string name = CustomerNamebox.Text;
                    ILiteCollection<Account> collection = db.GetCollection<Account>("accounts");

                    // 更新特定条件的文档  
                    System.Collections.Generic.IEnumerable<Account> documentsToUpdate = collection.Find(x => x.CustomerName == name && x.IsPaid == "否");
                    foreach (Account document in documentsToUpdate)
                    {
                        document.IsPaid = "是";
                        document.payby = "";
                        document.Remark = DateTime.Now.ToString() + "一键批量结账";
                        _ = collection.Update(document);
                    }


                }


                //清空DataGridView原有数据
                //将查询结果绑定到DataGridView
                if (dataGridView.DataSource != null)
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                }


                jisuan();
                MessageBox.Show("清账完成？");
            }
        }
    }
}

