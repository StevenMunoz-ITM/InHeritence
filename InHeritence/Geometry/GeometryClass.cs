namespace Geometry;
public abstract class GeometricFigure
{
    public string Name { get; set; } = null!;
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),12:N5}   Perimeter: {GetPerimeter(),10:N5}";
    }
}

public class Circle : GeometricFigure
{
    private double _r;

    private void ValidateR(double value)
    {
        if (value <= 0)
            throw new Exception($"Radius must be greater than zero. Given: {value}");
    }

    public double R
    {
        get => _r;
        set
        {
            ValidateR(value);
            _r = value;
        }
    }

    public Circle(string name, double radius)
    {
        Name = name;
        R = radius;
    }

    public override double GetArea()
    {
        return Math.PI * R * R;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }
}

public class Square : GeometricFigure
{
    private double _a;
    private void ValidateA(double value)
    {
        if (value <= 0)
            throw new Exception($"Side 'a' must be greater than zero. Given: {value}");
    }
    public double A
    {
        get => _a;
        set
        {
            ValidateA(value);
            _a = value;
        }
    }
    public Square(string name, double a)
    {
        Name = name;
        A = a;
    }
    public override double GetArea()
    {
        return A * A;
    }
    public override double GetPerimeter()
    {
        return 4 * A;
    }
}

public class Rhombus : Square
{
    private double _d1;
    private double _d2;

private void ValidateD1(double value)
    {
        if (value <= 0)
            throw new Exception($"Diagonal 'd1' must be greater than zero. Given: {value}");
    } 
    private void ValidateD2(double value)
    {
        if (value <= 0)
            throw new Exception($"Diagonal 'd2' must be greater than zero. Given: {value}");
    }
    public double D1
    {
        get => _d1;
        set
        {
            ValidateD1(value);
            _d1 = value;
        }
    }
    public double D2
    {
        get => _d2;
        set
        {
            ValidateD2(value);
            _d2 = value;
        }
    }
    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }
    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }
    public override double GetPerimeter()
    {
        return 4 * A;
    }
}

public class Kite : Rhombus 
{ 
private double _b;
    private void ValidateB(double value)
    {
        if (value <= 0)
            throw new Exception($"Side 'b' must be greater than zero. Given: {value}");
    }
    public double B
    {
        get => _b;
        set
        {
            ValidateB(value);
            _b = value;
        }
    }
    public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
    {
        B = b;
    }
    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }
    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

}
public class Rectangle : Square
{
    private double _b;
    private void ValidateB(double value)
    {
        if (value <= 0)
            throw new Exception($"Side 'b' must be greater than zero. Given: {value}");
    }
    public double B
    {
        get => _b;
        set
        {
            ValidateB(value);
            _b = value;
        }
    }
    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }
    public override double GetArea()
    {
        return A * B;
    }
    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}

public class Parallelogram : Rectangle 
{ 
private double _h;
    private void ValidateH(double value)
    {
        if (value <= 0)
            throw new Exception($"Height 'h' must be greater than zero. Given: {value}");
    }
    public double H
    {
        get => _h;
        set
        {
            ValidateH(value);
            _h = value;
        }
    }
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }
    public override double GetArea()
    {
        return B * H;
    }
    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}

public class Triangle : Rectangle 
{
    private double _c;
    private double _h;

    private void ValidateC(double value)
    {
        if (value <= 0)
            throw new Exception($"Side 'c' must be greater than zero. Given: {value}");
    }
    private void ValidateH(double value)
    {
        if (value <= 0)
            throw new Exception($"Height 'h' must be greater than zero. Given: {value}");
    }
    public double C
    {
        get => _c;
        set
        {
            ValidateC(value);
            _c = value;
        }
    }
    public double H
    {
        get => _h;
        set
        {
            ValidateH(value);
            _h = value;
        }
    }
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }
    public override double GetArea()
    {
        return (B * H) / 2;
    }
    public override double GetPerimeter()
    {
        return A + B + C;
    }
}

public class Trapeze : Triangle 
{
    private double _d;
    private void ValidateD(double value)
    {
        if (value <= 0)
            throw new Exception($"Side 'd' must be greater than zero. Given: {value}");
    }
    public double D
    {
        get => _d;
        set
        {
            ValidateD(value);
            _d = value;
        }
    }
    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
    {
        D = d;
    }
    public override double GetArea()
    {
        return (B + D) * H / 2;
    }
    public override double GetPerimeter()
    {
        return A + B + C + D;
    }
}