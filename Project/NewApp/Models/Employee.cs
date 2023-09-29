namespace NewApp.Models
{
    public class Employee : Person
    {
        public string MaNV { get; set; }
        public int Luong { get; set; }
        public void EnterData()
        {
            base.EnterData();
            System.Console.Write("Ma nhan vien: ");
            MaNV = Console.ReadLine();
            System.Console.Write("Luong: ");
            Luong = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            base.Display();
            System.Console.Write("- Ma nhan vien: {0} - Luong: {1}", MaNV, Luong);
        }
    }
}