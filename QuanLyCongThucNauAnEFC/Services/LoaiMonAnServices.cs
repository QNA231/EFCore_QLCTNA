using QuanLyCongThucNauAnEFC.Entities;
using QuanLyCongThucNauAnEFC.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongThucNauAnEFC.Services
{
    public class LoaiMonAnServices : ILoaiMonAnServices
    {
        private readonly AppDbContext DbContext;

        public LoaiMonAnServices()
        {
            DbContext = new AppDbContext();
        }

        public void ThemLoaiMonAn(LoaiMonAn loaiMonAn)
        {
            loaiMonAn.NhapThongTin();
            DbContext.Add(loaiMonAn);
            DbContext.SaveChanges();
            Console.WriteLine("Them loai mon an thanh cong!");
        }
    }
}
