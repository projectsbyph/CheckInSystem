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
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("Airport Check-In").Color(Color.Blue));

            // Choose Airline
            var selectedAirline = AnsiConsole.Prompt(
                new SelectionPrompt<Airline>()
                    .Title("Please select [bold green]your airline[/]:")
                    .PageSize(50)
                    .UseConverter(airline => airline.Name) // Show airline name in the selection
                    .AddChoices(FlightData.Airlines));

            // Choose Flight
            DisplayFlights(selectedAirline);
        }

        public static void DisplayFlights(Airline airline)
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("Select Flight").Color(Color.Green));

            // Choose Flight from the selected airline
            var selectedFlight = AnsiConsole.Prompt(
                new SelectionPrompt<Flight>()
                    .Title($"Please select [bold green]your flight[/] for {airline.Name}:")
                    .PageSize(50)
                    .AddChoices(airline.Flights));

            // Proceed to check-in
            AnsiConsole.MarkupLine($"You have selected flight [bold yellow]{selectedFlight.Number}[/] to [bold yellow]{selectedFlight.Destination}[/]. With departure time [bold yellow]{selectedFlight.Departure}[/]");
            AnsiConsole.MarkupLine("[bold white]In the next step, you will be asked to enter your personal information for check-in.[/]");
            DisplayBagaggeInfo();

        }

        public static void DisplayBagaggeInfo()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("Bagagge Info").Color(Color.DarkRed_1));

            // Let user choose bagagge type
            var selectedBagagge = AnsiConsole.Prompt(
                new SelectionPrompt<Luggage>()
                    .Title($"Please select [bold green]your bagagge type to check in[/]:")
                    .UseConverter(luggage => $"{luggage.Name} - Quantity: {luggage.Quantity}, Weight: {luggage.Weight}, Dimensions: {luggage.Dimensions}") // Show luggage details in the selection
                    .PageSize(50)
                    .AddChoices(BagaggeInfo.Luggages));
            var amount = AnsiConsole.Ask<int>($"How many [bold green]{selectedBagagge.Name}[/] would you like to check in?");
            selectedBagagge.Quantity = amount;

            // Inform the user about their selection and then, proceed to passenger info
            AnsiConsole.MarkupLine($"You have selected [bold yellow]{selectedBagagge.Name}[/] with quantity [bold yellow]{amount}[/], weight [bold yellow]{selectedBagagge.Weight}[/], and dimensions [bold yellow]{selectedBagagge.Dimensions}[/].");
            AnsiConsole.MarkupLine("[bold white]In the next step, you will be asked to enter your personal information for check-in.[/]");
            Console.ReadLine();
            DisplayPassengerInfo();
        }

        // Display passenger information
        public static void DisplayPassengerInfo()
        {
            AnsiConsole.Clear();
            AnsiConsole.Write(new FigletText("Passenger Info").Color(Color.Green));
            // Prompt for passenger information
            var name = AnsiConsole.Ask<string>("Please enter your [bold green]full name[/]:");
            var passportNumber = AnsiConsole.Ask<string>("Please enter your [bold green]passport number[/]:");
            // Here you can add more prompts for additional passenger information as needed
            AnsiConsole.MarkupLine($"Thank you, [bold yellow]{name}[/]. Your check-in is complete!");
        }

    }

}
