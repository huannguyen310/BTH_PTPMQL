namespace NewApp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        //Phuong thuc khoi tao
        public Person()
        {
            FullName = "Ho ten mac dinh";
            Address = "Dia chi mac dinh";
            Age = 20;
        }
        public void EnterData()
        {
            System.Console.Write("Full Name: ");
            FullName = Console.ReadLine();
            System.Console.Write("Address: ");
            Address = Console.ReadLine();
            System.Console.Write("Age: ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", FullName, Address, Age);
        }
        //Phuong thuc co tham so
        public void Display2(string ten, int tuoi)
        {
            System.Console.WriteLine("Doi tuong {0} - {1} tuoi", ten, tuoi);
        }
        //Phuong thuc co gia tri tra ve
        public int GetYearOfBirth(int age)
        {
            int yearOfBirth = 2023 - age;
            return yearOfBirth;
        }
    }
}