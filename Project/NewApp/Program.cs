using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewApp.Models;
public class Program
{
    public static void Main(string[] args)
    {
        ArrayList StudentList = new ArrayList();
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
        //Them moi
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"[{i}]");
            Student std = new Student();
            std.NhapTT();
            StudentList.Add(std);
        }
        //Hien thi
        foreach(Student std in StudentList)
        {
            std.HienthiTT();
        }
        //Sua TT
        string StdID = null;
        System.Console.WriteLine("Nhap ID student can sua: ");
        StdID = Console.ReadLine();
        for (int i = 0; i < StudentList.Count; i++)
        {
            Student std = (Student) StudentList[i];
            if(std.StudentID == StdID)
            {
                std.NhapTT();
                break;
            }
            else
            {
                System.Console.WriteLine("No data!");
                break;
            }
        }
        foreach(Student std in StudentList)
        {
            std.HienthiTT();
        }
        //Xoa phan tu trong danh sach
        System.Console.WriteLine("Nhap ID Student muon xoa: ");
        StdID = Console.ReadLine();
        for(int i = 0; i < StudentList.Count; i++)
        {
            Student std = (Student) StudentList[i];
            if(std.StudentID == StdID)
            {
                StudentList.RemoveAt(i);
                System.Console.WriteLine($"Da xoa student ID: {StdID}");
                break;
            }
        }
        foreach(Student std in StudentList)
        {
            System.Console.WriteLine("Danh sach sau khi xoa:");
            std.HienthiTT();
        }
    }
}