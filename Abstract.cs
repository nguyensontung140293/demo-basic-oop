using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    abstract class Car
    {
        protected abstract void Color();

        public abstract void Price();

        public void RateGood()
        {
            Console.WriteLine("đánh giá 5 sao");
        }

        protected void RateBad()
        {
            Console.WriteLine("đánh giá 1 sao");
        }

    }

    class Ford : Car 
    {
        protected override void Color() 
        {
            Console.WriteLine("ford red");
        }

        public override void Price() 
        {
            Console.WriteLine("1000$");
        }

    }

    public class Abstract // tính trừu tượng
    {
        protected void Main() 
        {
            Ford myFord = new Ford();
            myFord.Price();
            myFord.RateGood();
        }

        public void Show() 
        {
            Main();
        }

    }
}
