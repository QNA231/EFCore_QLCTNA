using QuanLyCongThucNauAnEFC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongThucNauAnEFC.IServices
{
    public interface IMonAnServices
    {
        void ThemMonAn(int loaiMonAnId);
        void SuaMonAn(int monAnId);
        void XoaMonAn(int monAnId);

    }
}
