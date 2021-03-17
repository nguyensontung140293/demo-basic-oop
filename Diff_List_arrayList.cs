using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;  // use ArrayList

namespace Demo
{
    public class Diff_List_arrayList
    {
        public void Main() {
            int tong = 0;

            List<int> City = new List<int>();

            City.Add(123);
            //City.Add("HCM"); //xảy ra lỗi ngay trong quá trình thêm dữ liệu
            City.Add(456);

            foreach (var item in City)
            {
                Console.WriteLine(item);
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add("");
            arrayList.Add(123);
            arrayList.Add("tung");

            foreach (var item in arrayList)
            {
               // tong += item; //xảy ra lỗi trong quá gì nối chuỗi
            }


            foreach (var item in City)
            {
                tong += item;
            }

            //foreach (var item in arrayList)
            //{
            //    tong += item;
            //}
        }
    }
}
