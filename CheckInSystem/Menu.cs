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

            var airlineList = new List<string> { "Scandinavian Airlines (SAS)", "Norwegian", "Sunclass Airlines", "British Airways", "Emirates", "Qatar Airways", "Finnair", "PopulAir", "Eurowings", "Lufthansa", "Brussels Airlines", "Icelandair", "Thai Airways", "Air France", "NyxAir", "Delta Airlines", "United Airlines", "Norse Atlantic", "TUI", "Air China", "All Nippon Airways (ANA)", "Iberia", "Ryanair", "TAP" };

            var airline = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select an [green]airline[/]:")
                    .PageSize(40)
                    .AddChoices(airlineList));

            AnsiConsole.MarkupLine("[bold blue]You selected: [green]{0}[/][/]", airline);
            DisplayFlights(airline);

        }

        public static void DisplayFlights(string airline)
        {
            if (airline == "Scandinavian Airlines (SAS)")
            {
                // Display flights for Scandinavian Airlines
                AnsiConsole.MarkupLine("[bold cyan]Flights for Scandinavian Airlines:[/]");
                
                // Add code to display flights for Scandinavian Airlines
            }

            else if (airline == "Norwegian")
            {
                // Display flights for Norwegian
                AnsiConsole.MarkupLine("[bold cyan]Flights for Norwegian:[/]");
                // Add code to display flights for Norwegian
            }

            else if (airline == "Sunclass Airlines")
            {
                // Display flights for Sunclass Airlines
                AnsiConsole.MarkupLine("[bold cyan]Flights for Sunclass Airlines:[/]");
                // Add code to display flights for Sunclass Airlines
            }

            else if (airline == "British Airways")
            {
                // Display flights for British Airways
                AnsiConsole.MarkupLine("[bold cyan]Flights for British Airways:[/]");
                // Add code to display flights for British Airways
            }

            else if (airline == "Emirates")
            {
                // Display flights for Emirates
                AnsiConsole.MarkupLine("[bold cyan]Flights for Emirates:[/]");
                // Add code to display flights for Emirates
            }

            else if (airline == "Qatar Airways")
            {
                // Display flights for Qatar Airways
                AnsiConsole.MarkupLine("[bold cyan]Flights for Qatar Airways:[/]");
                // Add code to display flights for Qatar Airways
            }

            else if (airline == "Finnair")
            {
                // Display flights for Finnair
                AnsiConsole.MarkupLine("[bold cyan]Flights for Finnair:[/]");
                // Add code to display flights for Finnair
            }

            else if (airline == "PopulAir")
            {
                // Display flights for PopulAir
                AnsiConsole.MarkupLine("[bold cyan]Flights for PopulAir:[/]");
                // Add code to display flights for PopulAir
            }

            else if (airline == "Eurowings")
            {
                // Display flights for Eurowings
                AnsiConsole.MarkupLine("[bold cyan]Flights for Eurowings:[/]");
                // Add code to display flights for Eurowings
            }

            else if (airline == "Lufthansa")
            {
                // Display flights for Lufthansa
                AnsiConsole.MarkupLine("[bold cyan]Flights for Lufthansa:[/]");
                // Add code to display flights for Lufthansa
            }

            else if (airline == "Brussels Airlines")
            {
                // Display flights for Brussels Airlines
                AnsiConsole.MarkupLine("[bold cyan]Flights for Brussels Airlines:[/]");
                // Add code to display flights for Brussels Airlines
            }

            else if (airline == "Icelandair")
            {
                // Display flights for Icelandair
                AnsiConsole.MarkupLine("[bold cyan]Flights for Icelandair:[/]");
                // Add code to display flights for Icelandair
            }

            else if (airline == "Thai Airways")
            {
                // Display flights for Thai Airways
                AnsiConsole.MarkupLine("[bold cyan]Flights for Thai Airways:[/]");
                // Add code to display flights for Thai Airways
            }

            else if (airline == "Air France")
            {
                // Display flights for Air France
                AnsiConsole.MarkupLine("[bold cyan]Flights for Air France:[/]");
                // Add code to display flights for Air France
            }

            else if (airline == "NyxAir")
            {
                // Display flights for NyxAir
                AnsiConsole.MarkupLine("[bold cyan]Flights for NyxAir:[/]");
                // Add code to display flights for NyxAir
            }

            else if (airline == "Delta Airlines")
            {
                // Display flights for Delta Airlines
                AnsiConsole.MarkupLine("[bold cyan]Flights for Delta Airlines:[/]");
                // Add code to display flights for Delta Airlines
            }

            else if (airline == "United Airlines")
            {
                // Display flights for United Airlines
                AnsiConsole.MarkupLine("[bold cyan]Flights for United Airlines:[/]");
                // Add code to display flights for United Airlines
            }

            else if (airline == "Norse Atlantic")
            {
                // Display flights for Norse Atlantic
                AnsiConsole.MarkupLine("[bold cyan]Flights for Norse Atlantic:[/]");
                // Add code to display flights for Norse Atlantic
            }

            else if (airline == "TUI")
            {
                // Display flights for TUI
                AnsiConsole.MarkupLine("[bold cyan]Flights for TUI:[/]");
                // Add code to display flights for TUI
            }

            else if (airline == "Air China")
            {
                // Display flights for Air China
                AnsiConsole.MarkupLine("[bold cyan]Flights for Air China:[/]");
                // Add code to display flights for Air China
            }

            else if (airline == "All Nippon Airways (ANA)")
            {
                // Display flights for All Nippon Airways (ANA)
                AnsiConsole.MarkupLine("[bold cyan]Flights for All Nippon Airways (ANA):[/]");
                // Add code to display flights for All Nippon Airways (ANA)
            }

            else if (airline == "Iberia")
            {
                // Display flights for Iberia
                AnsiConsole.MarkupLine("[bold cyan]Flights for Iberia:[/]");
                // Add code to display flights for Iberia
            }

            else if (airline == "Ryanair")
            {
                // Display flights for Ryanair
                AnsiConsole.MarkupLine("[bold cyan]Flights for Ryanair:[/]");
                // Add code to display flights for Ryanair
            }

            else if (airline == "TAP")
            {
                // Display flights for TAP
                AnsiConsole.MarkupLine("[bold cyan]Flights for TAP:[/]");
                // Add code to display flights for TAP
            }

            else 
            {
                AnsiConsole.MarkupLine("[bold red]Invalid airline selection.[/]");
            }




            // This method can be implemented to display flights for the selected airline
        }




        }
}
