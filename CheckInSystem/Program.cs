using System;
using System.Collections.Generic;
using System.Linq;
using Spectre.Console;

namespace CheckInSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Menu.CheckInOptions();
                AnsiConsole.MarkupLine("[bold green]Press any key to return to the menu...[/]");
                Console.ReadKey();
                Console.Clear();
            }


        }
    }
}