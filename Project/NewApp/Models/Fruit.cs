namespace NewApp.Models
{
    public class Fruit
    {
        public string FruitName { get; set; }
        public string Xuatxu { get; set; }
        public int GiaThanh { get; set; }
        public void nhaptt()
        {
            System.Console.Write("Ten: ");
            FruitName = Console.ReadLine();
            System.Console.Write("Xuat xu: ");
            Xuatxu = Console.ReadLine();
            System.Console.Write("Gia: ");
            GiaThanh = Convert.ToInt32(Console.ReadLine());
        }
        public void hienthiTT()
        {
            System.Console.WriteLine("Name: {0} - Xuat xu: {1} - Gia thanh: {2}", FruitName, Xuatxu, GiaThanh);
        }
    }
}