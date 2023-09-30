using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        //Person
        Person ps = new Person();
        ps.EnterData();
        ps.Display();
        //SinhVien
        SinhVien sv1 = new SinhVien();
        SinhVien sv2 = new SinhVien();
        sv1.NhapThongTinSV();
        sv1.HienThiThongTinSV();
        sv2.NhapThongTinSV();
        sv2.HienThiThongTinSV();
        //Student
        //Khoi tao kich thuoc cua mang
        int n;
        do
        {
            try
            {
            System.Console.Write("So luong sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                n = 0;
            }
        }while (n<1);
        //Khoi tao mang
        Student[] stdArray = new Student[n];
        //NhapTT
        for (int i = 0; i < stdArray.Length; i++)
        {
            Console.WriteLine("Nhap thong tin sinh vien thu {0}:", (i + 1));
            Student std = new Student();
            std.NhapTT();
            stdArray[i] = std;
        }
        //HienthiTT
        foreach (Student std in stdArray)
        {
            std.HienthiTT();
        }
        //Themmoi
        //Employee
        int m;
        do
        {
            try
            {
            System.Console.Write("So luong nhan vien: ");
            m = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                m = 0;
            }
        }while (m<1);
        Employee [] eplArray = new Employee[m];
        for(int i = 0; i < eplArray.Length; i++)
        {
            Console.WriteLine("Nhap thong tin nhan vien thu {0}: ", (i +1));
            Employee epl = new Employee();
            epl.NhapTTepl();
            eplArray[i] = epl;
        }
        foreach( Employee epl in eplArray)
        {
            epl.HienthiTTepl();
        }
        //Fruit
        Fruit fr1 = new Fruit();
        Fruit fr2 = new Fruit();
        Fruit fr3 = new Fruit();
        fr1.nhaptt();
        fr1.hienthiTT();
        fr2.hienthiTT();
        string FruitName = "Le";
        string Xuatxu = "Viet Nam";
        int GiaThanh = 200;
        fr3.hienthiTT2(FruitName, Xuatxu, GiaThanh);
        Console.WriteLine("Ten loai hoa qua: {0} - Xuat xu: {1} - Gia: {2}", FruitName, Xuatxu, fr3.GiaThanhplus(GiaThanh));
    }
}