using QuanLyCongThucNauAnEFC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongThucNauAnEFC.IServices
{
    public interface ICongThucServices
    {
        void ThemCongThuc(int monId, int nLieuId);
        void SuaCongThuc(int monId, int nLieuId);
        void XoaCongThuc(int monId, int ctId);
        void HienThiDanhSachCongThuc(string tenMonAn);
    }
}
