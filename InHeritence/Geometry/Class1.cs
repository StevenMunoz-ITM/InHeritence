namespace Geometry;

public abstract class GeometricFigure
{
    public string Name { get; set; }
    protected GeometricFigure(string name) => Name = name;
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString() =>
        $"{Name,-12} => Area.....: {GetArea(),10:0.00000}   Perimeter: {GetPerimeter(),10:0.00000}";
}

public class Circle : GeometricFigure
{
    private double _r;
    public double R => _r;
    public Circle(string name, double r) : base(name) => _r = r;
    public override double GetArea() => Math.PI * _r * _r;
    public override double GetPerimeter() => 2 * Math.PI * _r;

}

public class Square : GeometricFigure
{
    protected double _a;
    public double A => _a;
    public Square(string name, double a) : base(name) => _a = a;
    public override double GetArea() => _a * _a;
    public override double GetPerimeter() => 4 * _a;
    public void ValidateA() { }
}

public class Rectangle : Square
{
    protected double _b;
    public double B => _b;
    public Rectangle(string name, double a, double b) : base(name, a) => _b = b;
    public override double GetArea() => _a * _b;
    public override double GetPerimeter() => 2 * (_a + _b);
    public void ValidateB() { }
}

public class Parallelogram : Rectangle
{
    private double _h;
    public double H => _h;
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b) => _h = h;
    public override double GetArea() => _b * _h;
    public override double GetPerimeter() => 2 * (_a + _b);
    public void ValidateH() { }
}

public class Triangle : Rectangle
{
    protected double _c;
    protected double _h;
    public double C => _c;
    public double H => _h;
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        _c = c;
        _h = h;
    }
    public override double GetArea() => (_b * _h) / 2;
    public override double GetPerimeter() => _a + _b + _c;
    public void ValidateC() { }
    public void ValidateH() { }
}

public class Trapeze : Triangle
{
    private double _d;
    public double D => _d;
    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h) => _d = d;
    public override double GetArea() => (_b + _d) * _h / 2;
    public override double GetPerimeter() => _a + _b + _c + _d;
    public void ValidateD() { }
}

public class Rhombus : Square
{
    private double _d1;
    private double _d2;
    public double D1 => _d1;
    public double D2 => _d2;
    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        _d1 = d1;
        _d2 = d2;
    }
    public override double GetArea() => (_d1 * _d2) / 2;
    public override double GetPerimeter() => 4 * _a;
    public void ValidateD1() { }
    public void ValidateD2() { }
}

public class Kite : Rhombus
{
    private double _b;
    public double B => _b;
    public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2) => _b = b;
    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 2 * (_a + _b);
    public void ValidateB() { }
}