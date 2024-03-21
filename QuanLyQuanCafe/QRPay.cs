using CreateQRCode;
using Newtonsoft.Json;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class QRPay : Form
    {
        string total = "";
        public QRPay()
        {
            InitializeComponent();
        }

        public QRPay(string total)
        {
            InitializeComponent();
            this.total = total;
        }

        private void QRPay_Load(object sender, EventArgs e)
        {
            QRDTO QR = QRDAO.getQR();
            if (QR.Stk.Length > 0 && QR.TenTk.Length > 0 && QR.nganHang.Length > 0 && QR.Template.Length > 0)
            {
                string[] nganHang = QR.nganHang.Split(" ");

                var apiRequest = new ApiRequest();
                apiRequest.acqId = Convert.ToInt32(nganHang[0]);
                apiRequest.accountNo = long.Parse(QR.Stk);
                apiRequest.accountName = QR.TenTk;
                apiRequest.amount = Convert.ToInt32(total);
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
    }
}
