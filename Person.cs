using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyListener
{
    internal class Person
    {
        public void Select()
        {
            Console.WriteLine("Select");
        }
        public void Space()
        {
            Console.WriteLine("Jump");
        }
        public void Escape()
        {
            Console.WriteLine("Exit");
        }
        public void F1()
        {
            Console.WriteLine("Info");
        }
        public void Left()
        {
            Console.WriteLine("Move to Left");
        }
        public void Right()
        {
            Console.WriteLine("Move to Right");
        }
        public void Up()
        {
            Console.WriteLine("Move to Up");
        }
        public void Down()
        {
            Console.WriteLine("Move to Down");
        }
    }
}
