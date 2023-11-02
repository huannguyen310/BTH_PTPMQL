namespace NewApp.Models
{
    public class Employee : Person
    {
        public string MaNV {get; set;}
        public string TenNV { get; set; }
        public string diachiNV { get; set; }
        public int AgeNV { get; set; }
        public int LuongNV { get; set; }
        public void NhapTTepl()
        {
            Console.Write("Nhap ma nv: ");
            MaNV = Console.ReadLine();
            Console.Write("Nhap ten nv: ");
            TenNV = Console.ReadLine();
            Console.Write("Nhap dia chi nv: ");
            diachiNV = Console.ReadLine();
            Console.Write("Nhap tuoi nv: ");
            AgeNV = Convert.ToInt16(Console.ReadLine());
            Console.Write("Luong nv: ");
            LuongNV = Convert.ToInt32(Console.ReadLine());
        }
        public void HienthiTTepl()
        {
            System.Console.WriteLine("Ma nhan vien: {0} - Ten nhan vien: {1} - Dia chi: {2} - Tuoi: {3} - Luong: {4}", MaNV, TenNV, diachiNV, AgeNV, LuongNV);
        }
        //BTH slide 16_6
    }
}