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



int[,] matrix = new int[3, 2];

matrix[0, 0] = 10;
matrix[2, 1] = 20;

Console.WriteLine(matrix[2, 1]);

// PRACTICE TASK ON 2D ARRAYS
/* Create a program to ask the user
 * for the size of the 2d array.
 * Then create a int[,] 2d array.
 * Ask the user to enter values for
 * each of the elements of the 2d arr.
 * Display the 2d array in a rect
 * format. and also, display the sum and
 * average. */


// JAGGED ARRAY

int[][] nums = new int[3][];

nums[0] = new int[3];
nums[1] = new int[2];
nums[2] = new int[4];

nums[2][0] = 50;

foreach (int[] row in nums)
{
    foreach (int num in row)
    {
        Console.WriteLine(num);
    }
}


int[] arr1 = new int[3] {1,2,3};
int[] arr2 = arr1; // By reference!
int[] arr3 = new int[3];

Array.Copy(arr1, arr3, arr1.Length); // By Value

arr2[0] = 10;
arr3[0] = 20;


// prints arr1[0] = 10; arr2[0] = 10 
Console.WriteLine($"arr1[0] = {arr1[0]}; arr2[0] = {arr2[0]}");

// prints arr1[0] = 10; arr3[0] = 20
Console.WriteLine($"arr1[0] = {arr1[0]}; arr3[0] = {arr3[0]}");
