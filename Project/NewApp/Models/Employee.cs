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
    }
}