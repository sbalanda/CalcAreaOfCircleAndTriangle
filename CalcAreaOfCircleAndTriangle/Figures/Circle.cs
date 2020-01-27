using System;

namespace CalcAreaOfCircleAndTriangle
{
    public class Circle : Figure
    {
        double radius;

        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                    throw new Exception("Радиус должен быть > 0!");
                else
                    radius = value;
            }
        }

        public Circle() { }

        /// <summary>
        /// Определение окружности
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius) => Radius = radius;

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        protected override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
