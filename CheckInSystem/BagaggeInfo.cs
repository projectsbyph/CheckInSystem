using System;
using System.Collections.Generic;
using System.Text;
using Spectre.Console;

namespace CheckInSystem
{
    public static class BagaggeInfo
    {
        public static List<Luggage> Luggages = new List<Luggage>
        {
            new Luggage
            {
                Name = "Carry On Luggage",
                Luggages = new List<Luggage>
                {
                    new Luggage {Name = "Carry On Big Luggage", Dimensions = "Max: 55x40x23cm", Quantity = 1, Weight = "Max: 8kg"},
                    new Luggage {Name = "Carry On Small Luggage", Dimensions = "Max: 40x30x15cm", Quantity = 1, Weight = "Must fit under seat in front of you"},

                }
            },

            new Luggage
            {
                Name = "Checked In Luggage",
                Luggages = new List<Luggage>
                {
                    new Luggage {Name = "Normal Checked In Luggage", Dimensions = "Max: total sum of 158cm (width+heigth+depth)", Quantity = 1, Weight = "Max 23kg"},
                }
            },

            new Luggage
            {
                Name = "Special Luggage",
                Luggages = new List <Luggage>
                {
                    new Luggage {Name = "Sport Luggage (Golf, Hockey etc.)", Dimensions = "Max: 315cm", Quantity = 1, Weight = "Max: 32kg"},
                    new Luggage {Name = "Anmials", Dimensions = "One carrier", Quantity = 1, Weight = "Pets over 8kg must travel in cargo according to IATA rules"},
                    new Luggage {Name = "Bicycles", Dimensions = "Max 280cm", Quantity = 1, Weight = "Bicycles can only be accepted if they are packed in a suitable bicycle travel case or a similar container." }
                }

            }

        };


    }
}
