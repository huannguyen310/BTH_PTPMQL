namespace NewApp.Models
{
    public class Fruit
    {
        //BTH slide 16_6
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
        //BTH_slide 22_c6
        public void hienthiTT()
        {
            System.Console.WriteLine("Name: {0} - Xuat xu: {1} - Gia thanh: {2}", FruitName, Xuatxu, GiaThanh);
        }
        //Phuong thuc khoi tao
        public Fruit()
        {
            FruitName = "Tao";
            Xuatxu = "Viet Nam";
            GiaThanh = 200;
        }
        //Phuong thuc co tham so
        public void hienthiTT2(string FruitName,string Xuatxu, int GiaThanh)
        {
            System.Console.WriteLine("Ten loai hoa qua: {0} - Xuat xu: {1} - Gia: {2}", FruitName, Xuatxu, GiaThanh);
        }
        //Phuong thuc co gia tri tra ve
        public int GiaThanhplus(int GiaThanh)
        {
            int giahoaqua = GiaThanh *2;
            return giahoaqua;
        }
        
    }
}