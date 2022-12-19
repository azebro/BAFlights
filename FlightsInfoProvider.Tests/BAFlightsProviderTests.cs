using System;
using BAFlightsProvider;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace FlightsInfoProvider.Tests
{
    [TestClass]
    public class BAFlightsProviderTests
    {
        [TestMethod]
        public async void GetFlightsByNumber()
        {

            try
            {
                var provider = new FlightInfoProvider();
                var output = await provider.GetFlightsByNumber("1423", new DateTime(2015, 5, 15));
            }
            catch (Exception e)
            {
                var aa = e;
            }

        }

        private async void Execute()
        {
            var provider = new BAFlightsProvider.FlightInfoProvider();
            var output = await provider.GetFlightsByNumber("1423", new DateTime(2015, 5, 15));
        }
    }
}
