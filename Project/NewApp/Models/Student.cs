
namespace NewApp.Models
{
    public class Student
    {
        //BTH slide 16_6
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string Diachi { get; set; }
        public int Tuoi {get; set;}
        //BTH slide 22_c6
        public void NhapTT()
        {
            Console.Write("Nhap ID: ");
            StudentID = Console.ReadLine();
            Console.Write("Nhap ten: ");
            StudentName = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            Diachi = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Tuoi = Convert.ToInt16(Console.ReadLine());
        }
        public void HienthiTT()
        {
            System.Console.WriteLine("ID: {0} - Ten: {1} - Dia chi: {2} - Tuoi: {3}", StudentID, StudentName, Diachi, Tuoi);
        }
        
    }
}