using CreateQRCode;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using QuanLyCafe.DAO;
using QuanLyCafe.Del;
using QuanLyCafe.Models;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.Models;
using QuanLyQuanCafe.PayQR;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
        }

        private void tpAccount_Click(object sender, EventArgs e)
        {

        }
        string UsernameNow = "";

        public void loadTableManager()
        {
            cbSearchRoomName.DataSource = TableDAO.getAllRoomName();
            cbAddTable_Room.DataSource = TableDAO.getAllRoomName();
            cbAddRoom_Name.DataSource = TableDAO.getAllRoomName();
            loadTable(TableDAO.getRoomByName(cbSearchRoomName.Text), textSearchTableName.Text);
            LoadDgvAccount();
            LoadDgvFood();
            cbSearchFoodType.SelectedIndex = 0;
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);
                cb_nganhang.DataSource = listBankData.data;
                cb_nganhang.DisplayMember = "custom_name";
            }
        }
        private void TableManager_Load(object sender, EventArgs e)
        {
            loadTableManager();
        }

        //function Account

        public void LoadDgvAccount()
        {
            dgvAccount.DataSource = AccountDAO.getAllAccount();
            for (int i = 5; i < dgvFood.Columns.Count; i++)
            {
                dgvFood.Columns[i].Visible = false;
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvAccount.Rows[e.RowIndex];
                AccountDTO accountDTO = (AccountDTO)selectedRow.DataBoundItem;
                textName.Text = accountDTO.Name;
                textUsername.Text = accountDTO.Username;
                textPassword.Text = accountDTO.Password;
                textPhone.Text = accountDTO.Phone;
                UsernameNow = accountDTO.Username;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa account này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                errorFullName.Text = "";
                errorPassword.Text = "";
                errorPhone.Text = "";
                errorUsername.Text = "";
                int countError = 0;
                if (textName.Text.Length == 0)
                {
                    errorFullName.Text = "Không được bỏ trống";
                    countError = 1;
                }
                if (textPassword.Text.Length == 0)
                {
                    errorPassword.Text = "Không được bỏ trống";
                    countError = 1;
                }
                try
                {
                    if (textPhone.Text.Length != 10)
                    {
                        errorPhone.Text = "Sđt không hợp lệ";
                        countError = 1;
                    }
                    if (textUsername.Text.Length == 0)
                    {
                        errorUsername.Text = "Sđt không hợp lệ";
                        countError = 1;
                    }
                    int phone = int.Parse(textPhone.Text);


                }
                catch (Exception ex) { errorPhone.Text = "Sđt không hợp lệ"; countError = 1; }
                try
                {
                    if (countError == 0)
                    {
                        bool check = AccountDAO.updateAccount(UsernameNow, textUsername.Text, textPassword.Text, textName.Text, textPhone.Text);
                        if (check)
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo");
                        }
                        else { MessageBox.Show("Sửa không thành công", "Thông báo"); }
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sđt hoặc username đã tồn tại");
                }
            }
            LoadDgvAccount();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa account này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (UsernameNow != null)
                {
                    bool check = AccountDAO.deleteAccount(UsernameNow);
                    if (check)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        dgvAccount.DataSource = AccountDAO.getAllAccount();
                        for (int i = 5; i < dgvAccount.Columns.Count; i++)
                        {
                            dgvAccount.Columns[i].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công thành công", "Thông báo");

                    }
                }
            }
            LoadDgvAccount();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDgvAccount();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvAccount.DataSource = AccountDAO.getAccountByFullName(txtSearchFullName.Text);
            for (int i = 5; i < dgvAccount.Columns.Count; i++)
            {
                dgvAccount.Columns[i].Visible = false;
            }
        }
        //


        //function Food
        public void errorReset()
        {
            errorFoodName.Text = "";
            errorFoodPrice.Text = "";
            errorFoodQuantity.Text = "";
            errorFoodType.Text = "";
            errorFoodAddQuantity.Text = "";
            errorFoodID.Text = "";
        }
        public void LoadDgvFood()
        {
            numberAddQuantity.Value = 0;
            dgvFood.DataSource = FoodDAO.getAllFood();
            for (int i = 5; i < dgvAccount.Columns.Count; i++)
            {
                dgvAccount.Columns[i].Visible = false;
            }
        }
        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorReset();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvFood.Rows[e.RowIndex];
                FoodDTO foodDTO = (FoodDTO)selectedRow.DataBoundItem;
                if (foodDTO.FoodCategoryID == 1)
                {
                    cbFoodType.SelectedIndex = 0;
                }
                else cbFoodType.SelectedIndex = 1;
                textFoodName.Text = foodDTO.FoodName;
                textFoodPrice.Text = foodDTO.FoodPrice.ToString();
                numberQuantity.Value = foodDTO.Quantity;
                textFoodID.Text = foodDTO.FoodId.ToString();

            }
        }
        public void searchFood()
        {
            int select = 0;
            if (cbSearchFoodType.SelectedIndex == 0)
            {
                select = 0;
            }
            else if (cbSearchFoodType.SelectedIndex == 1)
            {
                select = 1;
            }
            else select = 2;
            dgvFood.DataSource = FoodDAO.getSearchFood(textSearchName.Text, select);
            for (int i = 5; i < dgvAccount.Columns.Count; i++)
            {
                dgvAccount.Columns[i].Visible = false;
            }
        }
        private void cbSearchFoodType_SelectedValueChanged(object sender, EventArgs e)
        {
            searchFood();
        }
        private void btnLoadFood_Click(object sender, EventArgs e)
        {
            LoadDgvFood();
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            errorReset();
            int type = 0;
            int countError = 0;
            if (textFoodName.Text.Length == 0)
            {
                errorFoodName.Text = "Không được để trống";
                countError = 1;
            }
            try
            {
                float check = float.Parse(textFoodPrice.Text);
                if (check < 0) { errorFoodPrice.Text = "Giá phải >= 0"; countError = 1; }
            }
            catch (Exception ex) { errorFoodPrice.Text = "Vui lòng nhập 1 số"; countError = 1; }
            if (numberQuantity.Value <= 0)
            {
                errorFoodQuantity.Text = "Số lượng phải > 0";
                countError = 1;
            }
            if (cbFoodType.SelectedIndex == 0)
            {
                type = 1;
            }
            else if (cbFoodType.SelectedIndex == 1)
            {
                type = 2;
            }
            else { countError = 1; }
            try
            {
                if (countError == 0)
                {
                    bool check = FoodDAO.insertFood(textFoodName.Text, float.Parse(textFoodPrice.Text), type, (int)numberQuantity.Value, txtLinkImg.Text);
                    if (check) { MessageBox.Show("Thêm thành công", "Thông báo"); }
                    else { MessageBox.Show("Thêm không thành công", "Thông báo"); }
                }

            }
            catch (Exception ex) { MessageBox.Show("Tên đồ ăn đã tồn tại vui lòng nhập lại", "Thông báo"); }
            LoadDgvFood();
        }
        private void textSearchName_TextChanged(object sender, EventArgs e)
        {
            searchFood();
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa đồ ăn này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                errorReset();
                int type = 0;
                int countError = 0;
                if (textFoodID.Text.Length == 0)
                {
                    errorFoodID.Text = "Không được để trống";
                    countError = 1;
                }
                if (textFoodName.Text.Length == 0)
                {
                    errorFoodName.Text = "Không được để trống";
                    countError = 1;
                }
                try
                {
                    float check = float.Parse(textFoodPrice.Text);
                    if (check < 0) { errorFoodPrice.Text = "Giá phải >= 0"; countError = 1; }
                }
                catch (Exception ex) { errorFoodPrice.Text = "Vui lòng nhập 1 số"; countError = 1; }
                if (numberQuantity.Value <= 0)
                {
                    errorFoodQuantity.Text = "Số lượng phải > 0";
                    countError = 1;
                }
                if (cbFoodType.SelectedIndex == 0)
                {
                    type = 1;
                }
                else if (cbFoodType.SelectedIndex == 1)
                {
                    type = 2;
                }
                else { countError = 1; }
                try
                {
                    if (countError == 0)
                    {
                        bool check = FoodDAO.updateFood(int.Parse(textFoodID.Text), textFoodName.Text, float.Parse(textFoodPrice.Text), type, (int)numberAddQuantity.Value, txtLinkImg.Text);
                        if (check) { MessageBox.Show("Sửa thành công", "Thông báo"); }
                        else { MessageBox.Show("Sửa thất bại", "Thông báo"); }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Tên đồ ăn trùng lặp vui lòng nhập lại", "Thông báo"); }
                LoadDgvFood();
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa đồ ăn này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                errorReset();
                if (textFoodID.Text.Length == 0)
                {
                    errorFoodID.Text = "Id không được trống";
                }
                else
                {
                    bool check = FoodDAO.deleteFood(int.Parse(textFoodID.Text));
                    if (check) { MessageBox.Show("Xóa thành công", "Thông báo"); }
                    else { MessageBox.Show("Xóa thất bại", "Thông báo"); }
                }
                LoadDgvFood();
            }
        }



        //

        //fuction bàn ăn
        string TableName = "";
        public void loadTable(int id, string TableName)
        {
            flpListTable.Controls.Clear();
            List<TableDTO> listTable = TableDAO.getAllTableByRoomAndName(id, textSearchTableName.Text);
            foreach (var item in listTable)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.TableName + Environment.NewLine;
                btn.BackColor = Color.White;
                btn.Cursor = Cursors.Hand;
                btn.Click += btn_Click;
                btn.Tag = item;
                flpListTable.Controls.Add(btn);
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button; // lop System.Windows.Forms.Button, sender là đối tượng của nut  button click ko phai TableDTO nen phai doi trc khi doi thanh DTO
            if (clickedButton != null)
            {
                TableDTO table = clickedButton.Tag as TableDTO;
                if (table != null)
                {
                    textAddTable_Name.Text = table.TableName;
                    cbAddTable_Room.Text = RoomDAO.getRoomByID(table.RoomID);
                    TableName = textAddTable_Name.Text;
                }
            }
        }

        private void cbSearchRoomName_SelectedValueChanged(object sender, EventArgs e)
        {
            loadTable(TableDAO.getRoomByName(cbSearchRoomName.Text), textSearchTableName.Text);
        }

        private void textSearchTableName_TextChanged(object sender, EventArgs e)
        {
            loadTable(TableDAO.getRoomByName(cbSearchRoomName.Text), textSearchTableName.Text);
        }

        public void voidResetErrorTable()
        {
            errorAddRoom.Text = string.Empty;
            errorAddTable_Name.Text = string.Empty;
            errorAddTable_Room.Text = string.Empty;
        }
        private void btnAddRoom_Name_Click(object sender, EventArgs e)
        {
            voidResetErrorTable();
            if (cbAddRoom_Name.Text.Length == 0)
            {
                errorAddRoom.Text = "Không được để trống";
            }
            else
            {
                try
                {
                    bool check = RoomDAO.insertRoom(cbAddRoom_Name.Text);
                    if (check) { MessageBox.Show("Thêm thành công", "Thông báo"); }
                    else MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                catch (Exception ex) { MessageBox.Show("Room đã tồn tại", "Thông báo"); }
            }
            loadTableManager();
        }

        private void btnDeleteRoom_Name_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                voidResetErrorTable();
                if (cbAddRoom_Name.Text.Length == 0)
                {
                    errorAddRoom.Text = "Không được để trống";
                }
                else
                {
                    try
                    {
                        bool check = RoomDAO.deleteRoom(cbAddRoom_Name.Text);
                        if (check) { MessageBox.Show("Xóa thành công", "Thông báo"); }
                        else MessageBox.Show("Room không tồn tại", "Thông báo");
                    }
                    catch (Exception ex) { MessageBox.Show("Room không tồn tại", "Thông báo"); }
                }
                loadTableManager();
            }
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            voidResetErrorTable();
            int errorCount = 0;
            if (textAddTable_Name.Text.Length == 0)
            {
                errorAddTable_Name.Text = "Không được để trống";
                errorCount = 1;
            }
            TableDTO table = TableDAO.getTableByRoomAndName(TableDAO.getRoomByName(cbAddTable_Room.Text), textAddTable_Name.Text);
            if (table != null)
            {
                MessageBox.Show("Tên phòng đã tồn tại", "Thông báo");
                errorCount = 1;
            }
            if (cbAddTable_Room.Text.Length == 0)
            {
                errorAddTable_Room.Text = "Không được để trống";
                errorCount = 1;
            }
            if (errorCount == 0)
            {
                try
                {
                    bool chek = TableDAO.insertTable(textAddTable_Name.Text, TableDAO.getRoomByName(cbAddTable_Room.Text));
                    if (chek)
                    {
                        MessageBox.Show("Thêm bàn thành công", "Thông báo");
                        loadTable(TableDAO.getRoomByName(cbAddTable_Room.Text), "");
                    }
                    else MessageBox.Show("Thêm bàn thất bại", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Phòng này không tồn tại", "Thông báo");
                }
            }

        }
        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn sửa bàn này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                voidResetErrorTable();
                if (TableName.Length > 0)
                {
                    if (textAddTable_Name.Text.Length > 0)
                    {
                        try
                        {
                            TableDTO checkTable = TableDAO.getTableByRoomAndName(TableDAO.getRoomByName(cbAddTable_Room.Text), textAddTable_Name.Text);
                            if (checkTable == null)
                            {
                                bool check = TableDAO.updateTable(TableName, TableDAO.getRoomByName(cbAddTable_Room.Text), textAddTable_Name.Text);
                                if (check)
                                {
                                    MessageBox.Show("Sửa thành công", "Thông báo");
                                    loadTable(TableDAO.getRoomByName(cbAddTable_Room.Text), "");
                                }
                                else MessageBox.Show("Phòng không tồn tại", "Thông báo");
                            }
                            else MessageBox.Show("Bàn đã tồn tại", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Phòng không tồn tại", "Thông báo");
                        }
                    }
                    else errorAddTable_Name.Text = "Không được để trống";
                }
                else MessageBox.Show("Chưa chọn bàn", "Thông báo");
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa bàn này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                voidResetErrorTable();
                int errorCount = 0;
                if (textAddTable_Name.Text.Length == 0)
                {
                    errorAddTable_Name.Text = "Không được để trống";
                    errorCount = 1;
                }
                if (cbAddTable_Room.Text.Length == 0)
                {
                    errorAddTable_Room.Text = "Không được để trống";
                    errorCount = 1;
                }
                TableDTO table = TableDAO.getTableByRoomAndName(TableDAO.getRoomByName(cbAddTable_Room.Text), textAddTable_Name.Text);
                if (errorCount == 0 && table != null)
                {
                    try
                    {
                        bool check = TableDAO.deleteTable(textAddTable_Name.Text, TableDAO.getRoomByName(cbAddTable_Room.Text));
                        if (check)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo");
                            loadTable(TableDAO.getRoomByName(cbAddTable_Room.Text), "");
                        }
                        else MessageBox.Show("Xóa thất bại", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Phòng không tồn tại", "Thông báo");

                    }
                }
                else MessageBox.Show("Bàn không tồn tại", "Thông báo");
            }
        }

        //

        //function Doanh THu
        public static int PageNow = 1;

        public int countPage()
        {
            int countPage = 0;
            int count = BillDAO.countBillByDay(dateStart.Text, dateEnd.Text);
            if (count > 0)
            {
                if (count % 15 == 0) { countPage = count / 15; }
                else { countPage = count / 15 + 1; }
            }
            return countPage;
        }
        public void getBill()
        {
            int CountError = 0;
            DateTime Start = DateTime.Parse(dateStart.Text);
            DateTime End = DateTime.Parse(dateEnd.Text);
            float doanhThu = BillDAO.doanhThuByDay(dateStart.Text, dateEnd.Text);
            txtdoanhThu.Text = doanhThu.ToString() + " đ";

            if (Start > End)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Thông báo");
                CountError = 1;
            }
            if (CountError == 0)
            {
                dgvBill.DataSource = BillDAO.getAllBillByDay(dateStart.Text, dateEnd.Text, PageNow);
                for (int i = 6; i < dgvBill.Columns.Count; i++)
                {
                    dgvBill.Columns[i].Visible = false;
                }
                int count = countPage();
                if (count > 0)
                {
                    Page.Text = "" + PageNow + "/" + count;
                }
                else { Page.Text = "" + 0 + "/" + 0; }
            }
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            getBill();
        }

        public void loadListBillInfo(int BillID)
        {
            listBillInfo.Items.Clear();
            listBillInfo.Columns.Clear();
            listBillInfo.DataBindings.Clear();
            listBillInfo.Columns.Add("Tên đồ ăn", 140);
            listBillInfo.Columns.Add("Giá tiền", 120);
            listBillInfo.Columns.Add("Số lượng", 50);
            listBillInfo.Columns.Add("Tổng tiền", 100);
            float total = 0;
            List<BillInfoDTO> listBill = BillInfoDAO.getAllBillInfoByID(BillID);
            foreach (BillInfoDTO billInfo in listBill)
            {
                FoodDTO food = FoodDAO.getFoodByID(billInfo.FoodID);
                ListViewItem item = new ListViewItem();
                item.Text = food.FoodName;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = food.FoodPrice.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = billInfo.Quantity.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (food.FoodPrice * billInfo.Quantity).ToString() });
                total += food.FoodPrice * billInfo.Quantity;
                listBillInfo.Items.Add(item);
            }
            ListViewItem itemTotal = new ListViewItem();
            itemTotal.Text = "Total";
            itemTotal.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            itemTotal.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
            itemTotal.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = total.ToString() });
            listBillInfo.Items.Add(itemTotal);

        }

        private void dgvBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvBill.Rows[e.RowIndex];
                BillDTO billDTO = (BillDTO)selectedRow.DataBoundItem;
                loadListBillInfo(billDTO.BillID);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel worbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Tên đồ ăn";
                    ws.Cells[1, 2] = "Giá tiền";
                    ws.Cells[1, 3] = "Số lượng";
                    ws.Cells[1, 4] = "Tổng tiền";
                    int i = 2;
                    foreach (ListViewItem item in listBillInfo.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("In thành công");
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int pageEnd = countPage();
            if (PageNow < pageEnd)
            {
                PageNow++;
                getBill();
            }
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            if (PageNow > 1)
            {
                PageNow--;
                getBill();
            }

        }

       

        //


        //Page QR

        public void resetError()
        {
            errorNganHang.Text = "";
            errorStk.Text = "";
            errorTenTk.Text = "";
            errorTemplate.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            resetError(); 
            QRDTO QR = QRDAO.getQR();
            if (QR.Stk.Length > 0 && QR.TenTk.Length > 0 && QR.nganHang.Length > 0 && QR.Template.Length > 0)
            {
                string[] nganHang = QR.nganHang.Split(" ");

                var apiRequest = new ApiRequest();
                apiRequest.acqId = Convert.ToInt32(nganHang[0]);
                apiRequest.accountNo = long.Parse(QR.Stk);
                apiRequest.accountName = QR.TenTk;
                apiRequest.amount = Convert.ToInt32("0");
                apiRequest.format = "text";
                apiRequest.template = QR.Template;
                var jsonRequest = JsonConvert.SerializeObject(apiRequest);
                // use restsharp for request api.
                var client = new RestClient("https://api.vietqr.io/v2/generate");
                var request = new RestRequest();

                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");

                request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

                var response = client.Execute(request);
                var content = response.Content;
                var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);


                var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("QR chưa đúng vui lòng update", "Thông báo");
            }
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            resetError();
            int counrError = 0;
            if (cb_nganhang.Text.Length <= 0)
            {
                errorNganHang.Text = "Ngân hàng không được trống";
                counrError = 1;
            }
            if (txtSTK.Text.Length <= 0)
            {
                errorStk.Text = "STK không được trống";
                counrError = 1;
            }
            if (cb_template.Text.Length <= 0)
            {
                errorTemplate.Text = "Template không được trống";
                counrError = 1;
            }
            if (txtTenTaiKhoan.Text.Length <= 0)
            {
                errorTenTk.Text = "Tên tk không được trống";
                counrError = 1;
            }

            if (counrError == 0)
            {

                bool check = QRDAO.updateQR(cb_nganhang.Text, txtSTK.Text, cb_template.Text, txtTenTaiKhoan.Text, txtInfo.Text);
                if (check)
                {
                    MessageBox.Show("Update thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Update thất bại", "Thông báo");
                }
            }
        }

        
        //
    }
}
