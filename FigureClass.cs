using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Circle : Figure
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be positive.");
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    public class Rectangle : Figure
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0) throw new ArgumentOutOfRangeException("Dimensions must be positive.");
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }

    public class Trapezoid : Figure
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double HeightC { get; set; }

        public Trapezoid(double sideA, double sideB, double heightC)
        {
            if (sideA <= 0 || sideB <= 0 || heightC <= 0) throw new ArgumentOutOfRangeException("Dimensions must be positive.");
            SideA = sideA;
            SideB = sideB;
            HeightC = heightC;
        }

        public override double Area()
        {
            return (SideA + SideB) * HeightC / 2;
        }

        public override double Perimeter()
        {
            double sideC = Math.Sqrt(HeightC * HeightC + Math.Pow((SideB - SideA) / 2, 2));
            return SideA + SideB + 2 * sideC;
        }
    }

    public class FigureContainer
    {
        private List<Figure> figures;

        public FigureContainer()
        {
            figures = new List<Figure>();
        }

        public void AddFigure(Figure figure)
        {
            if (figure == null) throw new ArgumentNullException(nameof(figure));
            figures.Add(figure);
            OnFiguresUpdated();
        }

        public void RemoveFigure(Figure figure)
        {
            if (figure == null) throw new ArgumentNullException(nameof(figure));
            figures.Remove(figure);
            OnFiguresUpdated();
        }

        public List<string> GetFiguresInfo()
        {
            return figures.Select(figure =>
                $"Figure: {figure.GetType().Name}, Area: {figure.Area():F2}, Perimeter: {figure.Perimeter():F2}")
                .ToList();
        }

        public event EventHandler FiguresUpdated;

        protected virtual void OnFiguresUpdated()
        {
            FiguresUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
