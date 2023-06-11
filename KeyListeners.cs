using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyListener
{
    internal class KeyListeners
    {
        public delegate void MethodContainer();

        //Событие OnCount c типом делегата MethodContainer.
        public event MethodContainer PressEnter;
        public event MethodContainer PressSpace;
        public event MethodContainer PressEscape;
        public event MethodContainer PressF1;
        public event MethodContainer PressLeft;
        public event MethodContainer PressRight;
        public event MethodContainer PressUp;
        public event MethodContainer PressDown;
        public void Listen()
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        {
                            if (PressEnter != null)
                            {
                                PressEnter();
                            }
                            break;
                        }
                    case ConsoleKey.Spacebar:
                        {
                            if (PressSpace != null)
                            {
                                PressSpace();
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (PressEscape != null)
                            {
                                PressEscape();
                            }
                            break;
                        }
                    case ConsoleKey.F1:
                        {
                            if (PressF1 != null)
                            {
                                PressF1();
                            }
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            if (PressLeft != null)
                            {
                                PressLeft();
                            }
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (PressRight != null)
                            {
                                PressRight();
                            }
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (PressUp != null)
                            {
                                PressUp();
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (PressDown != null)
                            {
                                PressDown();
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error input");
                            break;
                        }

                }
            } while (key != ConsoleKey.Escape);
        }
    }
}
