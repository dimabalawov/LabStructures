using System;
Complex a = new Complex(3, 4);
Complex b = new Complex(1, 2);

Complex sum = a + b;
Complex difference = a - b;
Complex product = a * b;
Complex quotient = a / b;

Console.WriteLine($"a: {a}");
Console.WriteLine($"b: {b}");
Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Разность: {difference}");
Console.WriteLine($"Произведение: {product}");
Console.WriteLine($"Частное: {quotient}");
public struct Complex
{
    public double Real { get; set; } 
    public double Imaginary { get; set; } 

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }
    public static Complex operator *(Complex a, Complex b)
    {
        double realPart = a.Real * b.Real - a.Imaginary * b.Imaginary;
        double imaginaryPart = a.Real * b.Imaginary + a.Imaginary * b.Real;
        return new Complex(realPart, imaginaryPart);
    }
    public static Complex operator /(Complex a, Complex b)
    {
        double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
        double realPart = (a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator;
        double imaginaryPart = (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator;
        return new Complex(realPart, imaginaryPart);
    }
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}
