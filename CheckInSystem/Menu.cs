using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckInSystem
{
    public class Menu
    {
        public static void CheckInOptions()
        {
            var options = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Please select an option:")
                    .AddChoices(new[] { "Check-In", "Exit" }));

            switch (options)
            {
                case "Check-In":
                    DisplayAirlines();
                    break;
                case "Exit":
                    Environment.Exit(0);
                    break;
            }
        }


        public static void DisplayAirlines()
        {
            AnsiConsole.MarkupLine("[bold yellow]Welcome to the Check-In System![/]");

            var airlineList = new List<string> { "Scandinavian Airlines (SAS)", "Norwegian", "Sunclass Airlines", "British Airways", "Emirates", "Qatar Airways", "Finnair", "PopulAir", "Eurowings", "Lufthansa", "Brussels Airlines", "Icelandair", "Thai Airways", "Air France", "NyxAir", "Delta Airlines", "United Airlines", "Norse Atlantic", "TUI", "Air China", "All Nippon Airways (ANA)", "Iberia", "Ryanair", "TAP" }
                .Select(f => f.ToUpper())
                .ToList();

            var airline = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select an [green]airline[/]:")
                    .PageSize(40)
                    .AddChoices(airlineList));

            AnsiConsole.MarkupLine("[bold blue]You selected: [green]{0}[/][/]", airline);

        }

        public static void DisplayFlights(string airline)
        {
            // This method can be implemented to display flights for the selected airline
        }




    }
}
