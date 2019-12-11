using System;

namespace AreaCalculator.Shapes.Impl
{
    public abstract class BaseShape
    {
        protected Func<double> CalcAreaFunc { get; set; }

        public double CalculateArea()
        {
            if (CalcAreaFunc == null) throw new NotImplementedException("Calculate Area function is not implemented");

            return CalcAreaFunc();
        }
    }
}
