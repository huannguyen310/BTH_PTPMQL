
namespace NewApp.Models
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public void Nhap()
        {
            System.Console.Write("Nhap ID: ");
            StudentID = Console.ReadLine();
            System.Console.Write("Ten: ");
            StudentName = Console.ReadLine();
            System.Console.Write("Dia chi: ");
            StudentAddress = Console.ReadLine();
        }
        public void HienThi()
        {
            System.Console.WriteLine("ID: {0} - Ho va ten: {1} - Dia chi: {2}", StudentID, StudentName, StudentAddress);
        }
        //Phuong thuc khoi tao
        public Student()
        {
            StudentID = "12345";
            StudentName = "Nguyen Van Huan";
            StudentAddress = "Ha Noi";
        }
        //Phuong thuc co tham so
        public void HienThi2(string StudentID, string StudentName, string StudentAddress)
        {
            System.Console.WriteLine("ID: {0} - Ho va ten: {1} - Dia chi: {2}", StudentID, StudentName, StudentAddress);
        }
        //Phuong thuc co gia tri tra ve
        public string IDSpecial(string StudentID)
        {
            string kq = "H" + StudentID;
            return kq;
        }
    }
}