const string root = @"/Users/julianadler/Desktop/test-recursion";

// Example of problem we can solve, iterating through directories.
// string[] subDirectories = Directory.GetDirectories(root);
// foreach (string subDirectory in subDirectories)
// {
//     Console.WriteLine(subDirectory);
//
//     string[] subSubDirectories = Directory.GetDirectories(subDirectory);
//
//     foreach (string subSubDirectory in subSubDirectories)
//     {
//         Console.WriteLine($"\t{subSubDirectory}");
//         string[] subSubSubDirectories = Directory.GetDirectories(subSubDirectory);
//
//         foreach (string subSubSubDirectory in subSubSubDirectories)
//         {
//             Console.WriteLine($"\t\t{subSubSubDirectory}");
//         }
//     }
// }


// Solve the problem above with recursion:
// static void ListDirectoriesRecursive(string path,
//     int depth)
// {
//     var prefix = new string('\t', depth);
//     Console.WriteLine($"{prefix}{path}");
//
//     string[] directories = Directory.GetDirectories(path);
//
//     foreach (string directory in directories)
//     {
//         ListDirectoriesRecursive(directory, depth + 1);
//     }
// }
//
// static void ListDirectories(string path)
// {
//     ListDirectoriesRecursive(path, 0);
// }
//
// ListDirectories(root);


// Solve without recursion, with stack
// var stack = new Stack<string>();
// stack.Push(root);
//
// while (stack.TryPop(out string path))
// {
//     Console.WriteLine(path);
//
//     string[] directories = Directory.GetDirectories(path);
//     foreach (string directory in directories)
//     {
//         stack.Push(directory);
//     }
// }


// Solve without recursion, with queue
// var queue = new Queue<string>();
// queue.Enqueue(root);
//
// while (queue.TryDequeue(out string path))
// {
//     Console.WriteLine(path);
//
//     string[] directories = Directory.GetDirectories(path);
//     foreach (string directory in directories)
//     {
//         queue.Enqueue(directory);
//     }
// }




// Solve without recursion, with stack and depth
var stack = new Stack<PrintableDirectory>();
stack.Push(new PrintableDirectory
{
    Path = root,
    Depth = 0
});

while (stack.TryPop(out PrintableDirectory printableDirectory))
{
    var prefix = new string('\t', printableDirectory.Depth);
    Console.WriteLine($"{prefix}{printableDirectory.Path}");

    string[] directories = Directory.GetDirectories(printableDirectory.Path);
    foreach (string directory in directories)
    {
        stack.Push(new PrintableDirectory
        {
            Path = directory,
            Depth = printableDirectory.Depth + 1
        });
    }
}

internal class PrintableDirectory
{
    public string Path { get; set; }
    public int Depth { get; set; }
}
