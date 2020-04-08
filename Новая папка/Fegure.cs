using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Fegure
    {
        //Базовый класс 
        protected List<Point> pList;
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Fegure fegure)
        {
            foreach (var p in pList)
            {
                if (fegure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }

    }
}
