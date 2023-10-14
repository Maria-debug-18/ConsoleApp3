using System;

class Romb
{
    protected double d1, d2;

    public Romb(double d1, double d2)
    {
        this.d1 = d1;
        this.d2 = d2;
    }

    public void Print()
    {
        Console.WriteLine("╔══════════╦══════════╗");
        Console.WriteLine($"║    D1    ║    D2    ║");
        Console.WriteLine("╠══════════╬══════════╣");
        Console.WriteLine($"║ {d1,-8:F1} ║ {d2,-8:F1} ║");
        Console.WriteLine("╚══════════╩══════════╝");
    }

    public double Sqr()
    {
        return d1 * d2 / 2;
    }

    public virtual double Side()
    {
        return Math.Sqrt((Math.Pow(d1, 2) + Math.Pow(d2, 2)) / 2);
    }
}

class Kvadrat : Romb
{
    public Kvadrat(double d) : base(d, d)
    {
    }

    public override double Side()
    {
        return (d1 * Math.Sqrt(2)) / 2;
    }

    public double Radius()
    {
        return d1 / 2;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Romb romb;
        for (int i = 0; i < 5; i++)
        {
            if (new Random().Next(0, 2) == 0)
            {
                double d1 = new Random().Next(1, 10);
                double d2 = new Random().Next(1, 10);
                romb = new Romb(d1, d2);
                Console.WriteLine("╔══════════╦══════════╗");
                Console.WriteLine("║  Ромб    ║          ║");
                Console.WriteLine("╠══════════╬══════════╣");
                romb.Print();
                Console.WriteLine("╠══════════╬══════════╣");
                Console.WriteLine($"║  Площа   ║ {romb.Sqr(),-8:F1} ║");
                Console.WriteLine("╠══════════╬══════════╣");
                Console.WriteLine($"║  Сторона ║ {romb.Side(),-8:F1} ║");
                Console.WriteLine("╚══════════╩══════════╝");
            }
            else
            {
                double d = new Random().Next(1, 10);
                Kvadrat kvadrat = new Kvadrat(d);
                Console.WriteLine("╔══════════╦══════════╗");
                Console.WriteLine("║ Квадрат  ║          ║");
                Console.WriteLine("╠══════════╬══════════╣");
                kvadrat.Print();
                Console.WriteLine("╠══════════╬══════════╣");
                Console.WriteLine($"║  Площа   ║ {kvadrat.Sqr(),-8:F1} ║");
                Console.WriteLine("╠══════════╬══════════╣");
                Console.WriteLine($"║  Сторона ║ {kvadrat.Side(),-8:F1} ║");
                Console.WriteLine("╠══════════╬══════════╣");
                Console.WriteLine($"║  Радіус  ║ {kvadrat.Radius(),-8:F1} ║");
                Console.WriteLine("╚══════════╩══════════╝");
            }
        }
    }
}
