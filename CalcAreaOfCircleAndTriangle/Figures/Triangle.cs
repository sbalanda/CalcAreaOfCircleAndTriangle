using System;

namespace CalcAreaOfCircleAndTriangle
{
    public class Triangle : Figure
    {
        double sideA, sideB, sideC;

        public double SideA
        {
            get { return sideA; }
            set { sideA = CheckNumberIsMoreZero(value); }
        }
        public double SideB
        {
            get { return sideB; }
            set { sideB = CheckNumberIsMoreZero(value); }
        }
        public double SideC
        {
            get { return sideC; }
            set { sideC = CheckNumberIsMoreZero(value); }
        }

        public Triangle() { }
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            IsTriangleExist();
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        protected override double CalculateArea()
        {
            IsTriangleExist();
            double halfPer = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(halfPer * (halfPer - sideA) * (halfPer - sideB) * (halfPer - sideC));
        }

        /// <summary>
        /// Проверить, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            IsTriangleExist();

            double a = sideA, b = sideB, c = sideC;

            if (a > 0 && b > 0 && c > 0)
            {
                if (sideA > sideB)
                    if (sideA > sideC)
                    {
                        c = sideA;
                        a = sideC;
                    }
                    else if (sideB > sideC)
                    {
                        c = sideB;
                        b = sideC;
                    }

                return (c * c == a * a + b * b) ? true : false;
            }
            else
                return false;
        }

        private void IsTriangleExist()
        {
            if (!((sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA)))
            {
                throw new Exception("Треугольник с такими сторонами не существует!");
            }
        }

        private double CheckNumberIsMoreZero(double number)
        {
            return number > 0 ? number : throw new Exception("Сторона треугольника должна быть > 0!");
        }

    }
}
