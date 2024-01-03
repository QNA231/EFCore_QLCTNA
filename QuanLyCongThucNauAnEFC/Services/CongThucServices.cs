using QuanLyCongThucNauAnEFC.Entities;
using QuanLyCongThucNauAnEFC.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongThucNauAnEFC.Services
{
    public class CongThucServices : ICongThucServices
    {
        private readonly AppDbContext DbContext;

        public CongThucServices()
        {
            DbContext = new AppDbContext();
        }

        public void SuaCongThuc(int monId, int ctId)
        {
            if (DbContext.MonAn.Any(x => x.MonAnId == monId))
            {
                if (DbContext.CongThuc.Any(x => x.CongThucId == ctId))
                {
                    var congthuc = DbContext.CongThuc.Find(ctId);
                    Console.WriteLine("Nhap Id nguyen lieu: ");
                    congthuc.NguyenLieuId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap so luong: ");
                    congthuc.SoLuong = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap don vi tinh: ");
                    congthuc.DonViTinh = Console.ReadLine();
                    DbContext.Update(congthuc);
                    DbContext.SaveChanges();
                    Console.WriteLine("Sua cong thuc cua mon an thanh cong!");
                }
            }
            Console.WriteLine("Mon an khong ton tai!");
        }

        public void ThemCongThuc(int monId, int nLieuId)
        {
            CongThuc ct = new CongThuc();
            MonAn mo = DbContext.MonAn.FirstOrDefault(x => x.MonAnId == monId);
            NguyenLieu nl = DbContext.NguyenLieu.FirstOrDefault(x => x.NguyenLieuId == nLieuId);
            if(mo == null)
            {
                Console.WriteLine("Mon an khong ton tai!");
            }
            ct.NhapThongTin(mo.MonAnId, nl.NguyenLieuId);
            DbContext.Add(ct);
            DbContext.SaveChanges();
            Console.WriteLine("Them cong thuc cho mon an thanh cong!");
        }

        public void XoaCongThuc(int monId, int ctId)
        {
            if(DbContext.MonAn.Any(x => x.MonAnId == monId))
            {
                if(DbContext.CongThuc.Any(x => x.CongThucId == ctId))
                {
                    var congthuc = DbContext.CongThuc.Find(ctId);
                    DbContext.Remove(congthuc);
                    DbContext.SaveChanges();
                    Console.WriteLine("Xoa cong thuc cua mon an thanh cong!");
                }
            }
            Console.WriteLine("Mon an khong ton tai!");
        }

        public void HienThiDanhSachCongThuc(string tenMonAn)
        {
            var congthuc = DbContext.MonAn
                .Join(DbContext.CongThuc, ma => ma.MonAnId, ct => ct.MonAnId, (ma, ct) => new { MonAn = ma, CongThuc = ct })
                .Join(DbContext.NguyenLieu, ct => ct.CongThuc.NguyenLieuId, nl => nl.NguyenLieuId, (ct, nl) => new { CongThuc = ct, NguyenLieu = nl })
                .Where(x => x.CongThuc.MonAn.TenMon.ToLower() == tenMonAn.ToLower())
                .Select(x => new {x.CongThuc.MonAn.TenMon, x.NguyenLieu.TenNguyenLieu, x.CongThuc.CongThuc.SoLuong, x.CongThuc.CongThuc.DonViTinh})
                .ToList();
            if(congthuc.Count > 0)
            {
                Console.WriteLine($"Ten mon an: {tenMonAn}");
                foreach(var congThuc in congthuc)
                {
                    Console.WriteLine($"{congThuc.TenNguyenLieu} - {congThuc.SoLuong} - {congThuc.DonViTinh}");
                }
            }
            else
            {
                Console.WriteLine($"Khong tim thay cong thuc cho mon {tenMonAn}");
            }
        }
    }
}
