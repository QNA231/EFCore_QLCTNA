using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongThucNauAnEFC.Entities
{
    public class CongThuc
    {
        public int CongThucId { get; set; }
        public int MonAnId { get; set; }
        public int NguyenLieuId { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public string DonViTinh { get; set; }
        public MonAn MonAn { get; set; }
        public NguyenLieu NguyenLieu { get; set; }
        public void NhapThongTin(int monId, int nLieuId)
        {
            CongThucId = 0;
            MonAnId = monId;
            NguyenLieuId = nLieuId;
            Console.WriteLine("Nhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap don vi tinh: ");
            DonViTinh = Console.ReadLine();
        }
    }
}
