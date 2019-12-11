using System;
using System.Collections.Generic;
using System.Linq;
using AreaCalculator.Models;

namespace AreaCalculator.Shapes
{
    public class RandomShape : BaseShape
    {
        public RandomShape(IEnumerable<Point> points)
        {
            var pointList = points.ToList();

            CalcAreaFunc = () => 
                Math.Abs(
                    pointList.Take(pointList.Count - 1)
                    .Select((p, i) => (pointList[i + 1].X - p.X) * (pointList[i + 1].Y + p.Y))
                    .Sum() / 2
                );
        }
    }
}
