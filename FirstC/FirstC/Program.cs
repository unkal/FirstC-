﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            Point p2 = new Point(4,5,'#');

            p1.Draw();p2.Draw();

            HorizontalLine line = new HorizontalLine(5,10,8,'-');
            line.Draw();

            Console.ReadLine();
        }
    }
}
