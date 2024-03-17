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

namespace QuanLyQuanCafe
{
    public partial class ListFood : Form
    {
        TableDTO table = new TableDTO();
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
            List<FoodDTO> listFood = FoodDAO.getAllFood();
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
                label.Name = "label" + i;
                label.Text = listFood[i].FoodName;
                label2.AutoSize = true; // Auto size the label based on its contents
                label2.Margin = new Padding(20, 70, label.Margin.Right, label.Margin.Bottom);
                label2.Font = new System.Drawing.Font(label.Font.FontFamily, 10, FontStyle.Bold);
                label2.Name = "label" + i;
                label2.Text = listFood[i].FoodPrice.ToString() +"đ";
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
    }
}
