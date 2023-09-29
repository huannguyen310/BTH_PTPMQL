namespace NewApp.Models
{
    public class FruitPlus : Fruit
    {
        public string HSD { get; set; }
        public void nhaptt()
        {
            base.nhaptt();
            System.Console.Write("Han su dung: ");
            HSD = Console.ReadLine();
        }
        public void hienthiTT()
        {
            base.hienthiTT();
            System.Console.Write("- Han su dung: {0}", HSD);
        }
    }
}