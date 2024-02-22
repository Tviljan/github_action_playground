//print out version and assembly version

using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine($"AssemblyVersion: {typeof(Program).Assembly.GetName().Version}");
//print fileVresion
Console.WriteLine($"FileVersion: {typeof(Program).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version}");

await Runner.RunAsync();