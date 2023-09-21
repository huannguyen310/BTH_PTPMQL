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
    }
}