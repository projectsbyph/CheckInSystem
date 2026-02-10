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

    public class PassengerInformation
    {
        public string Name { get; set; } = string.Empty;
        public string PassportNumber { get; set; } = string.Empty;
        public Flight FlightNumber { get; set; } = new Flight();
        public Luggage Luggages { get; set; } = new Luggage();
    }

    public class Luggage
    {
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Weight { get; set; } = string.Empty;
        public string Dimensions { get; set; } = string.Empty;
        public List<Luggage> Luggages { get; set; } = new List<Luggage>();


    }

    public class Seating
    {
        public string SeatNumber { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
    }

    public class BoardingPass
    {
        public PassengerInformation Passenger { get; set; } = new PassengerInformation();
        public Airline Airline { get; set; } = new Airline();
        public Flight Flight { get; set; } = new Flight();
        public Luggage Luggage { get; set; } = new Luggage();
        public Seating Seat { get; set; } = new Seating();
    }

}
