using CanteenDB.Models;
using MongoDB.Driver;

namespace CanteenDB.Services
{
    public class ReservationlistService
    {
        DBConnection db;
        private IMongoCollection<Reservationlist> Collection;
        private const string CitizenCollection = "Reservationlist";
    }
}
