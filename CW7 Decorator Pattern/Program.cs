﻿// Curt Lynch
// 02/14/2023
// I sell widget and widget accessories.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7_Decorator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Widget widget = new TextField(40, 20);
            Random rand = new Random();
            int numOfDecorators = rand.Next() % 50 + 10;
            for (int i = 0 ; i < numOfDecorators; i++)
            {
                if (rand.Next() % 2 == 0)
                {
                    widget = new BorderDecorator(widget);
                }
                else
                {
                    widget = new ScrollDecorator(widget);
                }
            }
            widget.draw();
            Console.ReadKey();
        }
    }
}
