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

    Console.WriteLine("Numbers were successfully read.");
}
catch
{
    Console.WriteLine("Invalid input");
}