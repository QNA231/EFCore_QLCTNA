using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongThucNauAnEFC.Entities
{
    public class MonAn
    {
        public int MonAnId { get; set; }
        [Required]
        public string TenMon { get; set; }
        public string GhiChu { get; set; }
        public int LoaiMonAnId { get; set; }
        public LoaiMonAn LoaiMonAn { get; set; }

        public void NhapThongTin(int loaiMonAnId)
        {
            MonAnId = 0;
            Console.WriteLine("Nhap ten mon: ");
            TenMon = Console.ReadLine();
            Console.WriteLine("Nhap ghi chu: ");
            GhiChu = Console.ReadLine();
            LoaiMonAnId = loaiMonAnId;
        }
    }
}
