using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            FoodCreate foodcreator = new FoodCreate(80, 25, '$');
            Point food = foodcreator.CreateFood();
            food.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Draw();


            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood();
                    food.Draw();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handlkey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

        }
    }
}
