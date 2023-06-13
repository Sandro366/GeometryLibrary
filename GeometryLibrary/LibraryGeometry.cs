using System;

namespace GeometryLibrary
{
    // Создаем интерфейс, который обязаует новый класс фигуры реализовать метод нахождения площади новой фигуры
    public interface IShape
    {
        double GetArea();
    }

    // Класс окружности, включающий конструктор и метод нахождения площади окружности
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Класс треугльника, включающий конструктор, метод нахождения площади треугольника
    // и метод проверки треугольника на прямоугльность
    public class Triangle : IShape
    {
        private double ab;
        private double bc;
        private double ac;

        public Triangle(double ab, double bc, double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
        }

        public double GetArea()
        {
            double p = (ab + bc + ac) / 2;
            return Math.Sqrt(p * (p - ac) * (p - bc) * (p - ac));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { ab, bc, ac };
            Array.Sort(sides);
            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }
    }

    
}