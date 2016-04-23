using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC
{
    class FoodCreate
    {
        int mapWeigth;
        int mapHigth;
        char sym;

        Random random = new Random();

        public FoodCreate(int mapWeigth, int mapHigth, char sym)
        {
            this.mapWeigth = mapWeigth;
            this.mapHigth = mapHigth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWeigth - 2);
            int y = random.Next(2, mapHigth - 2);
            return new Point(x, y, sym);
        }
    }
}
