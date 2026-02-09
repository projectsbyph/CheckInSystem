using System;
using System.Collections.Generic;
using System.Text;
using Spectre.Console;

namespace CheckInSystem
{
    public class Flight
    {
        public string Number { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public string Departure { get; set; } = string.Empty;

        // Method to arrange what shows in the menu
        public override string ToString()
        {
            return string.Format("{0} - {1} ({2})", Number, Destination, Departure);
        }

    }

    public class Airline
    {
        public string Name { get; set; } = string.Empty;
        public List<Flight> Flights { get; set; } = new List<Flight>();
    }
}
