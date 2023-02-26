// See https://aka.ms/new-console-template for more information
//https://dotnet.microsoft.com/en-us/learn/dotnet/hello-world-tutorial/
Console.WriteLine("Hello, World!");

//custom code!!!
Console.WriteLine("Enter your username:");
string userName = Console.ReadLine();
Console.WriteLine("Username is: " + userName);
System.Diagnostics.Process.Start("CMD.exe", userName);
