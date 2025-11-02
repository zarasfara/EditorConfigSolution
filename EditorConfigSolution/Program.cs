namespace EditorConfigSolution;

internal class Program
{
    private static void Main(string[] args)
    {
        // use collection expression suggestion
        List<int> numbers = new List<int>() { 1, 2, 3 };

        var number = 1;

        string superstring = StaticClass.StringMethod();

        Console.WriteLine("Hello, World!");
    }
}
