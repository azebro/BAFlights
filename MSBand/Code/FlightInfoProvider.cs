using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace BAFlightsProvider
{
    public class FlightInfoProvider
    {
        private readonly string _baseUrl = "https://api.ba.com/rest-v1/v1/flights;scheduledArrivalDate={0};flightNumber={1}";
        public async Task<FlightInfo> GetFlightsByNumber(string flightNumber, DateTime date)
        {
            if (flightNumber == null) throw new ArgumentNullException(nameof(flightNumber));
            var stringDate = date.ToString("yyyy-MM-dd");
            var serialiser = new Newtonsoft.Json.JsonSerializer();
            var url = String.Format(_baseUrl, stringDate, flightNumber);
            var request = WebRequest.CreateHttp(new Uri(url));
            request.Headers["client-Key"] = "2b44b9vva5m4sq493s88ew9t";
            FlightInfo flightInfoResponse = null;
            using (var response = await request.GetResponseAsync())
            {
                using (var responseStream = response.GetResponseStream())
                    using(var text = new StreamReader(responseStream))
                    {
                        //var text2 = text.ReadToEnd();
                    flightInfoResponse = serialiser.Deserialize<FlightInfo>(new JsonTextReader(text));
                }
                
            }
            return flightInfoResponse;

        }
    }
}
