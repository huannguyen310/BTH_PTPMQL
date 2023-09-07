using System.Reflection.Metadata;

internal class Program
{
    private static void Main(String[] args)
    {
        int songuyen;
        float sothuc;
        string chuoi;
        char kytu;
        bool dungsai;
        songuyen = 10;
        sothuc = 5.5F;
        chuoi = "chuoi";
        kytu = 'h';
        dungsai = true;
        Console.WriteLine("Kieu so nguyen: {0}",songuyen);
        Console.WriteLine("Kieu so thuc: {0}",sothuc);
        Console.WriteLine("Kieu chuoi:{0}",chuoi);
        Console.WriteLine("Kieu ky tu: {0}",kytu);
        Console.WriteLine("Kieu bool: {0}",dungsai);
    }
}