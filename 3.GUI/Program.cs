using _3.GUI.View;
using _3.GUI.View.BanHang;
using _3.GUI.View.FrmNhanvien;
using _3.GUI.View.FromSanPham;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

namespace _3.GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FRDangNhap());
            //Hieuphph40428@gmail.com mk 123
            // M?i ng�?i d�ng Clone using the web URL �? m? file nh� n?u t?i xu?ng theo t?p zip th? ph?i b? ch?n ? Windows Explorer ch?n .resx r?i chu?t tr�i ?n b? ch?n 
        }
    }
}