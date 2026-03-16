Console.WriteLine("=== Statistics Program ===");

Console.WriteLine("Enter numbers separated by space:");

string input = Console.ReadLine();

string[] parts = input.Split(" ");

int[] numbers = new int[parts.Length];

try
{
    for (int i = 0; i < parts.Length; i++)
    {
        numbers[i] = int.Parse(parts[i]);
    }

    Console.WriteLine("Input processed successfully.");
}
catch
{
    Console.WriteLine("Error: Invalid input. Please enter numbers only.");
}
public static double CalculateAverage(int[] values)
{
    return values.Average();
}
public static int CalculateMax(int[] values)
{
    return values.Max();
}
public static int CalculateMin(int[] values)
{
    if (values.Length == 0) return 0;// Finds the lowest value
    return values.Min();
}
Console.WriteLine("Statistics program v1");