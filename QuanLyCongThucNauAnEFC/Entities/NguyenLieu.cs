using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongThucNauAnEFC.Entities
{
    public class NguyenLieu
    {
        public int NguyenLieuId { get; set; }
        [Required]
        public string TenNguyenLieu { get; set; }
        public void NhapThongTIn()
        {
            Console.WriteLine("Nhap ten nguyen lieu: ");
            TenNguyenLieu = Console.ReadLine();
        }
    }
}
