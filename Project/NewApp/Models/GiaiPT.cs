using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    //BTH slide 34_c6
    public class GiaiPT
    {
        public string GPTBac1(double a, double b)
        {
            string ketqua = "";
            if(a == 0 && b == 0){
                ketqua = "Phuong trinh co vo so nghiem!";
            }else{
                if(a == 0){
                    ketqua = "Phuong trinh vo nghiem!";
                }else{
                    ketqua = "Nghiem cua phuong trinh: x = " + (-b/a);
                }
            }
            return ketqua;
        }
        public string GPTBac2(double x, double y, double z)
        {
            string message = "";
                        if(x == 0 && y == 0 && z == 0)
            {
                message = "Phuong trinh vo so nghiem!";
            }
            else
            {
                if(x == 0 && y == 0)
                {
                    message = "Phuong trinh vo nghiem!";
                }
                else
                {
                    if(x == 0)
                    {
                        message = "Phuong trinh co nghiem duy nhat:  x = " + (-z/y);
                    }
                    else
                    {
                        double delta;
                        delta = y*y - 4*x*z;
                        if(delta < 0)
                        {
                            message = "Phuong trinh vo nghiem!";
                        }
                        else
                        {
                            if(delta == 0)
                            {
                                message = "Phuong trinh co nghiem kep: x1 = x2 = " + (-y/(2*x));
                            }
                            else
                            {
                                message = "Phuong trinh co hai nghiem phan biet: x1 = " + ((-y) - Math.Sqrt(delta)/(2*x)) + "; x2 = " + (-y + Math.Sqrt(delta)/(2*x));
                            }
                        }
                    }
                }
            }
            return message;    
        }
    }
}