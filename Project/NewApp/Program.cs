using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
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
        Student std1 = new Student();
        Student std2 = new Student();
        std1.EnterData();
        std1.StudentCode = "12345";
        std1.Display();
        std2.EnterData();
        std2.Display();
        //Employee
        Employee epl1 = new Employee();
        Employee epl2 = new Employee();
        epl1.EnterData();
        epl1.MaNV = "123";
        epl1.Luong = 2000;
        std1.Display();
        std2.EnterData();
        std2.Display();
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