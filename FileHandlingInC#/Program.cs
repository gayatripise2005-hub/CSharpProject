

//File Handling in C#

// Using File class to create a file and write some text into it
//File is a static class in the System.IO namespace
//that provides methods for creating,
//copying, deleting, moving, and opening files,
//and helps in the creation of FileStream objects.

//File.Create("C:/test/test1.txt").Close();
// Create a file named "test.txt"
// and close it immediately

//File.AppendAllText("C:/test/test.txt", "\nWelcome to C# programming!");


//File.WriteAllText("C:/test/test.txt", "Hello, World!");

//File.WriteAllLines("C:/test/test.txt", new string[] { "Line 1", "Line 2", "Line 3" });

//File.AppendAllLines("C:/test/test.txt", new string[] { "Line 4", "Line 5" });

//var data=File.ReadAllBytes("C:/test/test.txt");

//foreach(var item in data)
//{
//    Console.WriteLine(item);
//}

//string data=File.ReadAllText("C:/Users/gayat/source/repos/FileHandlingInC#/Program.cs");
//Console.WriteLine(data);

//File.ReadAllLines("C:/Users/gayat/source/repos/FileHandlingInC#/Program.cs").ToList()
//    .ForEach(Console.WriteLine);


//File.Copy("C:/Users/gayat/source/repos/FileHandlingInC#/Program.cs", "C:/test/T1.txt");

//File.Move("C:/test/T1.txt", "C:\\Users\\gayat\\OneDrive\\DesktopT2.txt");
//File.Delete("C:/test/test.txt");

var files=Directory.GetFiles("C:\\Users\\gayat\\source\\repos\\techrel\\techrel");
foreach(var item in files)
{
    Console.WriteLine(item);
}
