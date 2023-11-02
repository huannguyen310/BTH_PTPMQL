namespace NewApp.Models
{
    public class SinhVien
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int Tuoi { get; set;}
        public int SDT { get; set;}
        public void NhapThongTinSV()
        {
            System.Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();
            System.Console.Write("Dia chi: ");
            DiaChi = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            try{
            Tuoi = Convert.ToInt16(Console.ReadLine());
            }catch(Exception e){
                Tuoi = 0;
            }
            System.Console.Write("SDT: ");
            SDT = Convert.ToInt32(Console.ReadLine());
        }
        public void HienThiThongTinSV()
        {
            System.Console.WriteLine("Ho ten: {0} - Dia chi: {1} - Tuoi: {2} - SDT: {3}", HoTen, DiaChi, Tuoi, SDT);
        }
        //BTH slide 22_c6
    }
}