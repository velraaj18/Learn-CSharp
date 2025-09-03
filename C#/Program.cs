using Generics;

public class Program()
{
    public static void Main()
    {
        var test = new GenericsBasics();

        var biggerInt = test.Max(1, 2);
        Console.WriteLine(biggerInt);

        var biggerString = test.Max("Velraaj", "ViratKohli");
        Console.WriteLine(biggerString);
    }
}