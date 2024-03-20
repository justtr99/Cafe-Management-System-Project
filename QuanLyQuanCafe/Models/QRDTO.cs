using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.Models
{
    public class QRDTO
    {
        public int QRId { get; set; }
        public string nganHang {  get; set; }
        public string Stk {  get; set; }
        public string Template { get; set; }
        public string TenTk { get; set; }
        public string ThongTinThem { get; set; }

        public QRDTO(int qRId, string nganHang, string stk, string template, string tenTk, string thongTinThem)
        {
            QRId = qRId;
            this.nganHang = nganHang;
            Stk = stk;
            Template = template;
            TenTk = tenTk;
            ThongTinThem = thongTinThem;
        }

        public QRDTO()
        {
        }
    }
}
