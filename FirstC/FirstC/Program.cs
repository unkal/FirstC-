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
           
            HorizontalLine Uline = new HorizontalLine(0,78,0,'-');
            HorizontalLine Dline = new HorizontalLine(0,78,24, '-');
            Verticalline Lline = new Verticalline(0,24,0,'|');
            Verticalline Rline = new Verticalline(0,24,78,'|');
            Uline.Draw();
            Dline.Draw();

            Lline.Draw();
            Rline.Draw();


            Point p = new Point(1, 3, '*');
            Snake snake = new Snake(p,4,Direction.RIGHT);

            snake.Draw();
            Console.ReadLine();
        }
    }
}
