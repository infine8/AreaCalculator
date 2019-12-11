using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaCalculator.Shapes
{
    public class Triangle : BaseShape
    {
        private Func<bool> IsStraightforwardFunc { get; }

        public Triangle(double a, double b, double c)
        {
            var p = (a + b + c) / 2;

            CalcAreaFunc = () => Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            IsStraightforwardFunc = () => IsStraightforward(a, b, c);
        }

        public bool IsStraightforward()
        {
            if (IsStraightforwardFunc == null) throw new NotImplementedException("IsStraightforward function is not implemented");

            return IsStraightforwardFunc();
        }

        private bool IsStraightforward(double a, double b, double c)
        {
            var sides = new List<double> { a, b, c };
            var hypotenuse = sides.Max();
            var cathets = sides.Except(new[] { hypotenuse });

            return Math.Abs(cathets.Select(x => Math.Pow(x, 2)).Sum() - Math.Pow(hypotenuse, 2)) < hypotenuse / 1000;
        }
    }
}
