
namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        Dictionary<string, List<Ride>> objUserRides = null;

        public RideRepository()
        {
            this.objUserRides = new Dictionary<string, List<Ride>>();
        }
        public void AddRide(string userID, Ride[] rides)
        {
            bool rideList = this.objUserRides.ContainsKey(userID);
            try
            {
                if (!rideList)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    this.objUserRides.Add(userID, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "Ride are Null");
            }
        }
        public Ride[] GetRides(string UserID)
        {
            try
            {
                return this.objUserRides[UserID].ToArray();
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid UserID");
            }
        }
    }
}
