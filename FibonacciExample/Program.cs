// See https://aka.ms/new-console-template for more information

// Naive fibonacci implementation
static decimal FibonacciRecursive(int n)
{
    if (n is 0 or 1)
    {
        return n;
    }

    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
}

const int max = 10000;
var current = 0;
while (current < max)
{
    Console.WriteLine($"F({current}) = {FibonacciRecursive(current)}");
    current += 1;
}

// Better recursive implementation
// static void FibonacciRecursiveInternal(double a,
//     double b)
// {
//     double next = a + b;
//     if (double.IsPositiveInfinity(next))
//     {
//         return;
//     }
//
//     Console.WriteLine(next);
//     FibonacciRecursiveInternal(b, next);
// }
//
// static void FibonacciRecursive()
// {
//     FibonacciRecursiveInternal(0, 1);
// }
//
// FibonacciRecursive();

// No recursion solution
// double a = 0;
// double b = 1;
//
// const int max = 100;
// var current = 0;
//
// while (current < max)
// {
//     double next = a + b;
//     Console.WriteLine(next);
//     a = b;
//     b = next;
//     current += 1;
// }
//
