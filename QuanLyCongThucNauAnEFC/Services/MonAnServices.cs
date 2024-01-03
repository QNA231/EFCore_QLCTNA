using QuanLyCongThucNauAnEFC.Entities;
using QuanLyCongThucNauAnEFC.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongThucNauAnEFC.Services
{
    public class MonAnServices : IMonAnServices
    {
        private readonly AppDbContext DbContext;

        public MonAnServices()
        {
            DbContext = new AppDbContext();
        }

        public void SuaMonAn(int monAnId)
        {
            if(DbContext.MonAn.Any(x => x.MonAnId == monAnId))
            {
                var monAn = DbContext.MonAn.Find(monAnId);
                Console.WriteLine("Nhap ten mon an: ");
                monAn.TenMon = Console.ReadLine();
                Console.WriteLine("Nhap ghi chu: ");
                monAn.GhiChu = Console.ReadLine();
                DbContext.Update(monAn);
                DbContext.SaveChanges();
                Console.WriteLine("Sua mon an thanh cong!");
            }
            Console.WriteLine("Mon an khong ton tai!");
        }

        public void ThemMonAn(int loaiMonAnId)
        {
            MonAn ma = new MonAn();
            LoaiMonAn loai = DbContext.LoaiMonAn.FirstOrDefault(x => x.LoaiMonAnId == loaiMonAnId);
            if(loai == null)
            {
                Console.WriteLine("Loai mon an khong ton tai!");
            }
            ma.NhapThongTin(loaiMonAnId);
            DbContext.Add(ma);
            DbContext.SaveChanges();
            Console.WriteLine("Them mon an thanh cong!");
        }

        public void XoaMonAn(int monAnId)
        {
            if(DbContext.MonAn.Any(x => x.MonAnId == monAnId))
            {
                var mon = DbContext.MonAn.Find(monAnId);
                DbContext.Remove(mon);
                DbContext.SaveChanges();
                Console.WriteLine("Xoa mon an thanh cong!");
            }
            Console.WriteLine("Mon an khong ton tai!");
        }
    }
}
