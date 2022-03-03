

class Program
{
    static void Main()
    {
        var r1 = new RomanNumber(15);
        r1 = r1 / new RomanNumber(0);
        Console.WriteLine(r1);
    }
}