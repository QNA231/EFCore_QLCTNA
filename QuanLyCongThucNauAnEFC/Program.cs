using QuanLyCongThucNauAnEFC.Entities;
using QuanLyCongThucNauAnEFC.IServices;
using QuanLyCongThucNauAnEFC.Services;

static void Main()
{
    Console.InputEncoding = System.Text.Encoding.UTF8;
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    ILoaiMonAnServices loaiMonAnServices = new LoaiMonAnServices();
    IMonAnServices monAnServices = new MonAnServices();
    INguyenLieuServices nguyenLieuServices = new NguyenLieuServices();
    ICongThucServices congThucServices = new CongThucServices();
    Console.Clear();
    Console.WriteLine("------------Quan ly cong thuc nau an------------");
    Console.WriteLine("1. Them loai mon an");
    Console.WriteLine("2. Them mon an");
    Console.WriteLine("3. Them nguyen lieu");
    Console.WriteLine("4. Them cong thuc");
    Console.WriteLine("5. Sua mon an");
    Console.WriteLine("6. Sua cong thuc");
    Console.WriteLine("7. Xoa mon an");
    Console.WriteLine("8. Xoa nguyen lieu");
    Console.WriteLine("9. Xoa cong thuc");
    Console.WriteLine("10. Hien thi danh sach cong thuc nau an");
    Console.WriteLine("11. Tim kiem ten mon an theo ten nguyen lieu");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Chon: ");
    string c = Console.ReadLine();
    Console.WriteLine();
    switch (c)
    {
        case "1":
            LoaiMonAn loai = new LoaiMonAn();
            loaiMonAnServices.ThemLoaiMonAn(loai);
            break;
        case "2":
            Console.WriteLine("Nhap Id loai mon an cho mon an dinh them: ");
            int loaiId = int.Parse(Console.ReadLine());
            monAnServices.ThemMonAn(loaiId);
            break;
        case "3":
            NguyenLieu nl = new NguyenLieu();
            nguyenLieuServices.ThemNguyenLieu(nl);
            break;
        case "4":
            Console.WriteLine("Nhap Id mon an can them cong thuc: ");
            int monId = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Id nguyen lieu cho cong thuc: ");
            int nlId = int.Parse(Console.ReadLine());
            congThucServices.ThemCongThuc(monId, nlId);
            break;
        case "5":
            Console.WriteLine("Nhap Id mon an can sua: ");
            int mon = int.Parse(Console.ReadLine());
            monAnServices.SuaMonAn(mon);
            break;
        case "6":
            Console.WriteLine("Nhap Id mon an can sua cong thuc: ");
            int mId = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Id cong thuc can sua: ");
            int ctId = int.Parse(Console.ReadLine());
            congThucServices.SuaCongThuc(mId, ctId);
            break;
        case "7":
            Console.WriteLine("Nhap Id mon an can xoa: ");
            int monid = int.Parse(Console.ReadLine());
            monAnServices.XoaMonAn(monid);
            break;
        case "8":
            Console.WriteLine("Nhap Id nguyen lieu can xoa: ");
            int nLId = int.Parse(Console.ReadLine());
            nguyenLieuServices.XoaNguyenLieu(nLId);
            break;
        case "9":
            Console.WriteLine("Nhap Id mon an can xoa cong thuc: ");
            int monID = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Id cong thuc can xoa: ");
            int ctID = int.Parse(Console.ReadLine());
            congThucServices.XoaCongThuc(monID, ctID);
            break;
        case "10":
            Console.WriteLine("Nhap ten mon an can hien thi cong thuc: ");
            string mo = Console.ReadLine();
            congThucServices.HienThiDanhSachCongThuc(mo);
            break;
        case "11":
            Console.WriteLine("Nhap ten nguyen lieu can tim (Hanh, Toi): ");
            string s = Console.ReadLine();
            nguyenLieuServices.TimKiem(s);
            break;
    }
}
Main();