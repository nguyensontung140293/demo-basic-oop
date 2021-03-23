using System;
using System.Collections.Generic;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Diff_List_arrayList list_ArrayList = new Diff_List_arrayList();
            list_ArrayList.Main();

            // sử dụng abstract 
            Console.WriteLine("-------------------------------");
            Console.WriteLine("sử dụng abstract");

            Abstract  abs = new Abstract();
            abs.Show();
            abs.Show();

            // sử dụng abstract 
            Console.WriteLine("-------------------------------");
            Console.WriteLine("sử dụng Polymorphism");


            Polymorphism poly_new = new Polymorphism();
            poly_new.Main();


            DemoLinq demoLinq = new DemoLinq();
            demoLinq.Main();




            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }

}