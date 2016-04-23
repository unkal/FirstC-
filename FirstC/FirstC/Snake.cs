﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC
{
    class Snake:Figure
    {

        public Snake(Point tail,int Lengt,Direction direction)
        {
            pList = new List<Point>(); 
            for(int i=0;i<=Lengt;i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
