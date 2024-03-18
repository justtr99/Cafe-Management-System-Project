using QuanLyCafe.DAO;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyQuanCafe.Form1;

namespace QuanLyQuanCafe
{
    public partial class ListFood : Form
    {
        TableDTO table = new TableDTO();
        List<FoodDTO> listOrder = new List<FoodDTO>();
        public ListFood()
        {
            InitializeComponent();
        }
        public ListFood(TableDTO table)
        {
            InitializeComponent();
            this.table = table;
        }




        private void ListFood_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
            loadTable();
        }


        public void loadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            List<FoodDTO> listFood = FoodDAO.getAllFoodByNameAndType(txtFoodName.Text, cbType.Text);
            if (cbType.Text.Equals("Tất cả"))
            {
                listFood = FoodDAO.getAllFoodByNameAndType(txtFoodName.Text, "");
            }
            for (int i = 0; i < listFood.Count; i++)
            {
                PictureBox pictureBoxFood = new PictureBox();
                pictureBoxFood.Size = new Size(150, 100); // Set the size to 50x50
                pictureBoxFood.SizeMode = PictureBoxSizeMode.StretchImage; // Set the SizeMode to StretchImage
                pictureBoxFood.Margin = new Padding(20, 30, pictureBoxFood.Margin.Right, pictureBoxFood.Margin.Bottom);
                LoadImageIntoPictureBox(pictureBoxFood, listFood[i].imgLink);
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
                label.AutoSize = true; // Auto size the label based on its contents
                label.Margin = new Padding(20, 70, label.Margin.Right, label.Margin.Bottom);
                label.Font = new System.Drawing.Font(label.Font.FontFamily, 10, FontStyle.Bold);
                label.Name = "Name" + i;
                label.Text = listFood[i].FoodName;
                label2.AutoSize = true; // Auto size the label based on its contents
                label2.Margin = new Padding(20, 70, label.Margin.Right, label.Margin.Bottom);
                label2.Font = new System.Drawing.Font(label.Font.FontFamily, 10, FontStyle.Bold);
                label2.Name = "Price" + i;
                label2.Text = listFood[i].FoodPrice.ToString() + "đ";
                NumericUpDown numericUpDownFood = new NumericUpDown();
                numericUpDownFood.Margin = new Padding(20, 70, label.Margin.Right, label.Margin.Bottom);
                numericUpDownFood.Name = "Numeric" + i;
                numericUpDownFood.Maximum = listFood[i].Quantity;
                Button button = new Button();
                button.Text = "Thêm món";
                button.Name = "" + i;
                button.Margin = new Padding(20, 70, label.Margin.Right, label.Margin.Bottom);
                button.Size = new Size(100, 30);
                button.Cursor = Cursors.Hand;
                button.Click += btn_Click;
                flowLayoutPanel1.Controls.Add(pictureBoxFood);
                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(label2);
                flowLayoutPanel1.Controls.Add(numericUpDownFood);
                flowLayoutPanel1.Controls.Add(button);
            }
        }


        private void btn_Click(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                int index = int.Parse(button.Name);
                System.Windows.Forms.Label labelName = flowLayoutPanel1.Controls["Name" + index] as System.Windows.Forms.Label;
                System.Windows.Forms.Label labelPrice = flowLayoutPanel1.Controls["Price" + index] as System.Windows.Forms.Label;
                NumericUpDown numericUpDownFood = flowLayoutPanel1.Controls["Numeric" + index] as NumericUpDown;
                if (labelName != null && numericUpDownFood != null && labelPrice != null)
                {
                    string foodName = labelName.Text;
                    int quantity = (int)numericUpDownFood.Value;
                    string[] getPrice = labelPrice.Text.Split("đ");
                    float price = float.Parse(getPrice[0]);
                    if (quantity > 0)
                    {
                        listOrder.Add(new FoodDTO(foodName, quantity, price));
                    }

                    loadListView();
                }

            }
        }

        public void loadListView()
        {
            listViewOrder.Items.Clear();
            listViewOrder.Columns.Clear();
            listViewOrder.DataBindings.Clear();
            listViewOrder.Columns.Add("Tên đồ ăn", 140);
            listViewOrder.Columns.Add("Giá tiền", 120);
            listViewOrder.Columns.Add("Số lượng", 100);
            foreach (var order in listOrder)
            {
                ListViewItem item = new ListViewItem();
                item.Text = order.FoodName;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = order.FoodPrice.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = order.Quantity.ToString() });
                listViewOrder.Items.Add(item);
            }
        }

        private async void LoadImageIntoPictureBox(PictureBox pictureBox, string imageUrl)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = await webClient.DownloadDataTaskAsync(imageUrl);
                    using (var stream = new System.IO.MemoryStream(data))
                    {
                        Image image = Image.FromStream(stream);
                        pictureBox.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listOrder.Count > 0)
            {
                int id = BillDAO.getBillByTable(table.TableID);
                if (id > 0)
                {
                    foreach (var item in listOrder)
                    {
                        int FoodID = FoodDAO.getFoodIDByName(item.FoodName);
                        bool check = BillInfoDAO.insertBillInfo(id, FoodID, item.Quantity);
                    }
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    this.Close();
                }
                else if (id == 0)
                {
                    bool check = BillDAO.insertBill(table.TableID, Account.account.Id);
                    int idNew = BillDAO.getBillByTable(table.TableID);
                    foreach (var item in listOrder)
                    {
                        int FoodID = FoodDAO.getFoodIDByName(item.FoodName);
                        bool checkx = BillInfoDAO.insertBillInfo(idNew, FoodID, item.Quantity);
                    }
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    this.Close();
                }


            }
        }

        private void txtFoodName_TextChanged(object sender, EventArgs e)
        {
            loadTable();
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}
