using System;

namespace AreaCalculator.Shapes.Impl
{
    public class Circle : BaseShape
    {
        public Circle(double radius)
        {
            CalcAreaFunc = () => Math.PI * Math.Pow(radius, 2);
        }
    }
}
