using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyazPractice
{
    public class Ticket
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public string PNR { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public List<Passenger> Passengers { get; set; }

        public FareDetail Fare { get; set; }
    }

    public class Passenger
    {
        public string PassengerName { get; set; }
        public int PassengerAge { get; set; }
        public string PassengerGender { get; set; }
    }

    public class FareDetail
    {
        public double TicketPrice { get; set; }
        public double Discount { get; set; }
        public GST GST { get; set; }
    }

    public class GST
    {
        public double StateGST { get; set; }
        public double CentralGST { get; set; }
    }
}
