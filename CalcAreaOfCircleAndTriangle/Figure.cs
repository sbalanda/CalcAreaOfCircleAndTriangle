using System;

namespace CalcAreaOfCircleAndTriangle
{
    public abstract class Figure
    {
        private readonly Lazy<double> area;

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area => area.Value;

        protected Figure()
        {
            area = new Lazy<double>(CalculateArea);
        }

        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        protected abstract double CalculateArea();
    }
}
