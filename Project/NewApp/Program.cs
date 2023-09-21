using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        //Person
        Person ps1 = new Person();
        Person ps2 = new Person();
        ps1.FullName = "Nguyen Van A";
        ps1.Address = "Ha Noi";
        ps1.Age = 21;
        ps1.Display();
        ps2.EnterData();
        ps2.Display();
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
        std1.Nhap();
        std1.HienThi();
        std2.Nhap();
        std2.HienThi();
        //Employee
        Employee epl1 = new Employee();
        Employee epl2 = new Employee();
        epl1.NhapTT();
        epl1.HienThiTT();
        epl2.NhapTT();
        epl2.HienThiTT();
        //Fruit
        Fruit fr1 = new Fruit();
        Fruit fr2 = new Fruit();
        fr1.nhaptt();
        fr1.hienthiTT();
        fr2.nhaptt();
        fr2.hienthiTT();
    }
}