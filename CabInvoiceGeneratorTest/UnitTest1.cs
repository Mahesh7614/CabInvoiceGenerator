using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerator objInvoiceGenerator = null;

        [TestMethod]
        public void GivenDistanceAndTime_ReturnTotalFare()
        {
            objInvoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 6.0;
            int time = 15;

            double fare = objInvoiceGenerator.CalculateFare(distance, time);
            double expected = 75;

            Assert.AreEqual(expected, fare);
        }

        [TestMethod]
        public void GivenMultipleRides_ReturnInvoiceSummary()
        {
            objInvoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(6.0, 15), new Ride(3.1, 8) };

            InvoiceSummary summary = objInvoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 114.0);

            Assert.AreEqual(expectedSummary, summary);
        }
    }
}