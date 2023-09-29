using System;
using System.Security.AccessControl;
namespace NewApp.Models
{
    public class Employee
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }
        public void NhapTT()
        {
            System.Console.Write("Nhap ma NV: ");
            MaNV = Console.ReadLine();
            System.Console.Write("Ten nhan vien: ");
            TenNV = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Luong = ");
            Luong = Convert.ToInt32(Console.ReadLine());
        }
        public void HienThiTT ()
        {
            System.Console.WriteLine("Ma nhan vien: {0} - Ten: {1} - Tuoi: {2} tuoi - Luong: {3} USD", MaNV, TenNV, Tuoi, Luong);
        }
        //Phuong thuc khoi tao
        public Employee()
        {
            MaNV = "123";
            TenNV = "Nguyen Van Huan";
            Tuoi = 23;
            Luong = 2000;
        }
        //Phuong thuc co tham so
        public void HienThiTT2(string MaNV, string TenNV, int Tuoi, int Luong)
        {
            System.Console.WriteLine("Ma NV: {0} - Ten NV: {1} - {2} tuoi - Luong: {3}", MaNV, TenNV, Tuoi, Luong);
        }
        //Phuong thuc co gia tri tra ve
        public int doTuoi(int Tuoi)
        {
            int tuoiplus = Tuoi + 1;
            return tuoiplus;
        }
    }
}