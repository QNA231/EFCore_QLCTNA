using QuanLyCongThucNauAnEFC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongThucNauAnEFC.IServices
{
    public interface INguyenLieuServices
    {
        void ThemNguyenLieu(NguyenLieu nl);
        void XoaNguyenLieu(int nlId);
        public void TimKiem(string tenNguyenLieu);
    }
}
