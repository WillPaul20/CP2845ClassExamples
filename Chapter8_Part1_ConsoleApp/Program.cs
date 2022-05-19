int[] numbers = new int[5];

// Print the first element
Console.WriteLine(numbers[0]);

numbers[0] = 1;
numbers[1] = 1;
numbers[2] = 2;
numbers[3] = 3;
numbers[4] = 5;

Console.WriteLine(numbers[4]); // prints 5

int[] fib = new int[5] { 1, 1, 2, 3, 5 };
Console.WriteLine(fib[4]); // prints 5

Console.WriteLine($"Length of fib = {fib.Length}");

for (int i = 0; i<fib.Length; i++)
{
    Console.Write(fib[i] + " ");
}
Console.WriteLine();

foreach (int num in fib)
{
    Console.Write(num + " ");
}
Console.WriteLine();