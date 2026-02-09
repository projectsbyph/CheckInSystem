using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CheckInSystem
{
    public static class FlightData
    {
        public static List<Airline> Airlines = new List<Airline>
        {
            new Airline
            {
                Name = "Scandinavian Airlines (SAS)",
                Flights = new List<Flight>
                {
                    new Flight {Number = "SK1555", Destination = "Amsterdam", Departure = "15:05"},
                    new Flight {Number = "SK903", Destination = "New York (EWR)", Departure = "10:45"},
                    new Flight {Number = "SK165", Destination = "Gothenburg Landvetter", Departure = "10:45"},
                    new Flight {Number = "SK527", Destination = "London (LHR)", Departure = "15:20"}
                }
            },

            new Airline
            {
                Name = "Norwegian",
                Flights = new List<Flight>
                {
                    new Flight {Number = "DY5701", Destination = "Gran Canaria (LPA)", Departure = "11:50"},
                    new Flight {Number = "DY817", Destination = "Oslo", Departure = "16:30"},
                    new Flight {Number = "DY2613", Destination = "Helsinki", Departure = "17:20"},
                    new Flight {Number = "DY5503", Destination = "Barcelona", Departure = "19:05"}

                }

            },

            new Airline
            {
                Name = "Sunclass Airlines",
                Flights = new List<Flight>
                {
                    new Flight {Number = "DK1728", Destination = "Tenerife", Departure = "08:55"},
                    new Flight {Number = "DK818", Destination = "Sal (Cape Verde)", Departure = "09:10"}
                }

            },

            new Airline
            {
                Name = "British Airways",
                Flights = new List<Flight>
                {
                    new Flight {Number = "BA785", Destination = "London (LHR)", Departure = "07:10"},
                    new Flight {Number = "BA777", Destination = "London (LHR)", Departure = "11:45"},
                    new Flight {Number = "BA779", Destination = "London (LHR)", Departure = "15:15"},
                    new Flight {Number = "BA783", Destination = "London (LHR)", Departure = "20:10"},
                }
            },

            new Airline
            {
                Name = "Emirates",
                Flights = new List<Flight>
                {
                    new Flight {Number = "EK158", Destination = "Dubai (DXB)", Departure = "14:30"},
                }

            },

            new Airline
            {
                Name = "Qatar Airways",
                Flights = new List<Flight>
                {
                    new Flight {Number = "QR168", Destination = "Doha", Departure = "14:55"}
                }
            },

            new Airline
            {
                Name = "Finnair",
                Flights = new List<Flight>
                {
                    new Flight {Number = "AY826", Destination = "Helsinki", Departure = "06:20"},
                    new Flight {Number = "AY802", Destination = "Helsinki", Departure = "07:55"},
                    new Flight {Number = "AY804", Destination = "Helsinki", Departure = "08:30"},
                    new Flight {Number = "AY806", Destination = "Helsinki", Departure = "10:50"},
                    new Flight {Number = "AY808", Destination = "Helsinki", Departure = "13:15"},
                    new Flight {Number = "AY810", Destination = "Helsinki", Departure = "14:10"},
                    new Flight {Number = "AY814", Destination = "Helsinki", Departure = "16:55"},
                    new Flight {Number = "AY816", Destination = "Helsinki", Departure = "18:10"},
                    new Flight {Number = "AY820", Destination = "Helsinki", Departure = "21:05"},
                }
            },

            new Airline
            {
                Name = "PopulAir",
                Flights = new List<Flight>
                {
                    new Flight {Number = "HP552", Destination = "Hemavan Tärnaby via Arvidsjaur", Departure = "08:20"},
                    new Flight {Number = "HP302", Destination = "Örnsköldsvik", Departure = "08:40"},
                    new Flight {Number = "HP422", Destination = "Vilhelmina via Lycksele", Departure = "08:50"},
                    new Flight {Number = "HP282", Destination = "Mariehamn", Departure = "09:00"},
                    new Flight {Number = "HP662", Destination = "Gällivare via Kramfors", Departure = "09:10"},
                    new Flight {Number = "HP788", Destination = "Arvidsjaur", Departure = "17:30"},
                    new Flight {Number = "HP306", Destination = "Örnsköldsvik", Departure = "18:05"},
                    new Flight {Number = "HP424", Destination = "Vilhelmina via Lycksele", Departure = "18:45"},
                    new Flight {Number = "HP664", Destination = "Gällivare via Kramfors", Departure = "19:15"},
                    new Flight {Number = "HP284", Destination = "Mariehamn", Departure = "20:00"},
                }
            },

            new Airline
            {
                Name = "Eurowings",
                Flights = new List<Flight>
                {
                    new Flight {Number = "EW9217", Destination = "Düsseldorf", Departure = "17:55" }
                }
            },

            new Airline
            {
                Name = "Lufthansa",
                Flights = new List<Flight>
                {
                    new Flight {Number = "LH811", Destination = "Frankfurt", Departure = "06:15"},
                    new Flight {Number = "LH2421", Destination = "Munich", Departure = "07:10"}
                }
            },

            new Airline
            {
                Name = "Brussels Airlines",
                Flights = new List<Flight>
                {
                    new Flight {Number = "SN2298", Destination = "Brussels", Departure = "06:30"},
                    new Flight {Number = "SN2294", Destination = "Brussels", Departure = "17:25"}

                }
            },

            new Airline
            {
                Name = "Icelandair",
                Flights = new List<Flight>
                {
                    new Flight {Number = "FI307", Destination = "Reykjavik", Departure = "12:45"}
                }
            },

            new Airline
            {
                Name = "Thai Airways",
                Flights = new List<Flight>
                {
                    new Flight {Number = "TG961", Destination = "Bangkok (BKK)", Departure = "13:00"}
                }
            },

            new Airline
            {
                Name = "Air France",
                Flights = new List<Flight>
                {
                    new Flight {Number = "AF1463", Destination = "Paris (CDG)", Departure = "06:15"},
                    new Flight {Number = "AF1263", Destination = "Paris (CDG)", Departure = "12:45"}
                }
            },

            new Airline
            {
                Name = "NyxAir",
                Flights = new List<Flight>
                {
                    new Flight {Number = "OJ625", Destination = "Karlstad", Departure = "12:45"}
                }
            },

            new Airline
            {
                Name = "Delta Airlines",
                Flights = new List<Flight>
                {
                    new Flight {Number = "DL205", Destination = "New York (JFK)", Departure = "11:30"}
                }
            },

            new Airline
            {
                Name = "United Airlines",
                Flights = new List<Flight>
                {
                    new Flight {Number = "UA69", Destination = "New York (EWR)", Departure = "09:10"}
                }
            },

            new Airline
            {
                Name = "Norse Atlantic",
                Flights = new List<Flight>
                {
                    new Flight {Number = "Z082", Destination = "Bangkok (BKK)", Departure = "15:00"}
                }
            },

            new Airline
            {
                Name = "TUI",
                Flights = new List<Flight>
                {
                    new Flight {Number = "BLX165", Destination = "Gran Canaria (LPA)", Departure = "07:35"},
                    new Flight {Number = "BLX247", Destination = "Krabi", Departure = "15:30"}
                }
            },

            new Airline
            {
                Name = "Air China",
                Flights = new List<Flight>
                {
                    new Flight {Number = "CA912", Destination = "Beijing", Departure = "18:20"}
                }
            },

            new Airline
            {
                Name = "All Nippon Airways (ANA)",
                Flights = new List<Flight>
                {
                    new Flight {Number = "NH222", Destination = "Tokyo (HND)", Departure = "09:35"}
                }
            },

            new Airline
            {
                Name = "Iberia",
                Flights = new List<Flight>
                {
                    new Flight {Number = "IB824", Destination = "Madrid", Departure = "14:45"}
                }
            },

            new Airline
            {
                Name = "Ryanair",
                Flights = new List<Flight>
                {
                    new Flight {Number = "FR4616", Destination = "Gdansk", Departure = "08:00"},
                    new Flight {Number = "FR3037", Destination = "Barcelona", Departure = "09:55"},
                    new Flight {Number = "FR1462", Destination = "London (STN)", Departure = "13:00"},
                    new Flight {Number = "FR4691", Destination = "Thessaloniki", Departure = "15:00"}
                }
            },

            new Airline
            {
                Name = "TAP",
                Flights = new List<Flight>
                {
                    new Flight {Number = "TP781", Destination = "Lisbon", Departure = "14:20"}
                }
            }



        };
    }
}







