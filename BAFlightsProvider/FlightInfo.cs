using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAFlightsProvider
{

    public class FlightInfo
    {
        public Flightsresponse FlightsResponse { get; set; }
    }

    public class Flightsresponse
    {
        public Flight[] Flight { get; set; }
        public DateTime DataLastUpdated { get; set; }
    }

    public class Flight
    {
        public string MarketingCarrierCode { get; set; }
        public int FlightNumber { get; set; }
        public Sector Sector { get; set; }
    }

    public class Sector
    {
        public string DepartureStatus { get; set; }
        public string ArrivalStatus { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public int DepartureTerminal { get; set; }
        public DateTime ScheduledDepartureDateTime { get; set; }
        public DateTime ScheduledArrivalDateTime { get; set; }
        public DateTime ReportedDepartureDateTime { get; set; }
        public DateTime ReportedArrivalDateTime { get; set; }
        public string OperatingCarrierCode { get; set; }
        public object AircraftTypeCode { get; set; }
        public bool MatchesRequest { get; set; }
        public Departuregateinformation DepartureGateInformation { get; set; }
    }

    public class Departuregateinformation
    {
        public string GateNumber { get; set; }
        public string GateStatus { get; set; }
    }

    
}
