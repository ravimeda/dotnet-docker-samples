using dotnetlib;
using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace dotnetapp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string message = "Dotnet-bot: Welcome to using .NET Core!";

            if (args.Length > 0)
            {
                message = String.Join(" ", args);
            }

            WriteLine(Message.GetBot(message));
            WriteLine("**Environment**");
            WriteLine($"Platform: .NET Core 2.0");
            WriteLine($"OS: {RuntimeInformation.OSDescription}");
            WriteLine();
        }
    }
}
