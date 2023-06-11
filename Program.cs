using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyListener
{
    internal class Program
    {
        static void Main()
        {
            Person person = new Person();
            KeyListeners key = new KeyListeners();

            key.PressEnter += person.Select;
            key.PressSpace += person.Space;
            key.PressEscape += person.Escape;
            key.PressF1 += person.F1;
            key.PressLeft += person.Left;
            key.PressRight += person.Right;
            key.PressUp += person.Up;
            key.PressDown += person.Down;

            key.Listen();
        }
    }
}
