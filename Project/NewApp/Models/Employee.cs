namespace NewApp.Models
{
    //BTH_slide 43_c6
    public class Employee : Person
    {
        //BTH slide 16_6
        public string MaNV {get; set;}
        public string TenNV { get; set; }
        public string diachiNV { get; set; }
        public int AgeNV { get; set; }
        public int LuongNV { get; set; }
        //BTH_slide 22_c6
        public void NhapTTepl()
        {
            Console.Write("Nhap ma nv: ");
            MaNV = Console.ReadLine();
            Console.Write("Nhap ten nv: ");
            TenNV = Console.ReadLine();
            Console.Write("Nhap dia chi nv: ");
            diachiNV = Console.ReadLine();
            Console.Write("Nhap tuoi nv: ");
            try{
            AgeNV = Convert.ToInt16(Console.ReadLine());
            }catch(Exception e){
                AgeNV = 0;
            }
            Console.Write("Luong nv: ");
            LuongNV = Convert.ToInt32(Console.ReadLine());
        }
        public void HienthiTTepl()
        {
            System.Console.WriteLine("Ma nhan vien: {0} - Ten nhan vien: {1} - Dia chi: {2} - Tuoi: {3} - Luong: {4}", MaNV, TenNV, diachiNV, AgeNV, LuongNV);
        }
        
    }
}