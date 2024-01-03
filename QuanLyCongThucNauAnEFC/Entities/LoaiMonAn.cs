using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongThucNauAnEFC.Entities
{
    public class LoaiMonAn
    {
        public int LoaiMonAnId { get; set; }
        [Required]
        public string TenLoai { get; set; }
        public IEnumerable<MonAn> MonAn { get; set; }
        public void NhapThongTin()
        {
            LoaiMonAnId = 0;
            Console.WriteLine("Nhap ten loai mon an: ");
            TenLoai = Console.ReadLine();
        }
    }
}
