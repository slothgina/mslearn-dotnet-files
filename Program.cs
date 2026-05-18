using System.IO;
using System.Collections.Generic;

var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);     
var salesFiles = FindFiles(storesDirectory);

File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

















/*var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);   // Add this line of code

//var salesFiles = FindFiles(storesDirectory);
//var salesFiles = FindFiles("stores");
IEnumerable<string> FindFiles(string folderName)
{
    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
    Console.WriteLine(Path.Combine("stores","201")); // outputs: stores/201
    Console.WriteLine(Path.GetExtension("sales.json")); // outputs: .json
}

File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);*/


//Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores","201","newDir"));
//bool doesDirectoryExist = Directory.Exists(filePath);
//File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");
/*var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");
var salesFiles = FindFiles(storesDirectory);
var salesFiles = FindFiles("stores");
foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}
//foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}
var salesFiles = FindFiles("stores");
IEnumerable<string> FindFiles(string folderName)
{
    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
    Console.WriteLine(Path.Combine("stores","201")); // outputs: stores/201
    Console.WriteLine(Path.GetExtension("sales.json")); // outputs: .json

string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

FileInfo info = new FileInfo(fileName);

Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more
// returns:
// stores\201 on Windows
//
// stores/201 on macOS*/
    //List<string> salesFiles = new List<string>();

    //var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

   // foreach (var file in foundFiles)
    //{
        //var extension = Path.GetExtension(file);
       // if (file.EndsWith("sales.json"))
    
        //if (extension == ".json")
        //{
           // salesFiles.Add(file);

