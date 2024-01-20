using System;
using System.Collections;

namespace TutorBuoi1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region buoi 1
            ////int la kieu so nguyen
            //int a;
            ////double la kieu so thuc
            //double b;
            ////string la kieu chuoi
            //string hoTen;
            ////var la kieu du lieu khong tuong minh
            //var d="ghfghfhg";

            //#region Nhap tu ban phim
            //// Console.WriteLine de display ra man hinh
            //Console.WriteLine("Nhap bien a:");
            ////Convert.ToInt32(Console.ReadLine()) nhap kieu du lieu int
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nhap bien b:");
            ////Convert.ToDouble(Console.ReadLine()) nhap kieu du lieu double
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Nhap Ho Ten:");
            ////Console.ReadLine() nhap kieu chuoi
            //hoTen = Console.ReadLine();
            //#endregion

            ////Display ra man hinh
            ////Console.WriteLine("A =: " + a);
            ////Console.WriteLine($"A= {a}");
            ////Console.WriteLine("A = {0}", a);

            //#region Demo ve IF
            ////if (a<0)
            ////{
            ////    Console.WriteLine("a La so am");
            ////}if (b>0)
            ////{
            ////    Console.WriteLine("b la so duong");
            ////}
            ////if (hoTen.Equals("Giap"))
            ////{
            ////    Console.WriteLine("Dung r");
            ////}

            //if (a < 0)
            //{
            //    Console.WriteLine("a La so am");
            //}
            //else if (b > 0)
            //{
            //    Console.WriteLine("b la so duong");

            //}
            //else if (hoTen.Equals("Giap"))
            //{
            //    Console.WriteLine("Dung r");

            //}
            //else
            //{
            //    Console.WriteLine("Cha cai dung ca");
            //}

            //#endregion
            #region pt bậc 2
            //Console.WriteLine("ax^2 + bx + c = 0");
            //Console.WriteLine("Nhap a: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Nhap b: ");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Nhap c: ");
            //double c = Convert.ToDouble(Console.ReadLine());
            //double delta = Math.Pow(b, 2) - (4 * a * c);
            //if (a == 0)
            //{
            //    if (b == 0)
            //    {
            //        Console.WriteLine("Phuong trinh vo nghiem");
            //    }else
            //    {
            //        if(c == 0)
            //        {
            //            Console.WriteLine("Phuong trinh vo so nghiem");
            //        }
            //        else
            //        {
            //            double x0 = -c / b;
            //            Console.WriteLine("Phuong trinh co nghiem la: " + x0);
            //        }
            //    }
            //}
            //else
            //{
            //    if(delta == 0)
            //    {
            //        double x = -b / (2 * a);
            //        Console.WriteLine("Phuong trinh co nghiem kep x = x1 = x2 = " + x);
            //    }else if(delta > 0)
            //    {
            //        double x1 = (b + Math.Sqrt(delta)) / (2 * a );
            //        double x2 = (b - Math.Sqrt(delta)) / (2 * a);
            //        Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
            //        Console.WriteLine("x1 = " + x1);
            //        Console.WriteLine("x2 = " + x2);
            //    }else if (delta < 0)
            //    {
            //        Console.WriteLine("Phuong trinh vo nghiem");
            //    }
            //}
            #endregion
            #endregion

            #region Buoi 2
            int a, b = 1;
            Console.WriteLine("Nhap so lan:");
            a = Convert.ToInt32(Console.ReadLine());
            //while (b<=a)
            //{
            //    Console.WriteLine("{0} AXL", b);
            //    b++;
            //}
            do
            {

                Console.WriteLine("{0}.AXL", b);
                b++;

            } while (b <= a);

            #endregion
            Console.ReadKey();
        }
    }
}
