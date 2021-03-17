using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Animal 
    {
        public virtual void Sound() 
        {
            Console.WriteLine("Sound Animal");
        }

    }

    class Dog : Animal 
    {
        public override void Sound()
        {
            Console.WriteLine("Sound Dog");
        }
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Sound Cat");
        }
    }

   class Polymorphism
    {
        public  void Main() 
        {
            // sử dụng virtual ở hàm base và override lại ở hàm con

            Animal animal = new Animal();
            animal.Sound();

            Animal mydog = new Dog();
            mydog.Sound();

            Animal mycat = new Cat();
            mycat.Sound();

        }
    }
}
