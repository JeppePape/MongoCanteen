using CanteenDB.Models;
using MongoDB.Driver;

namespace CanteenDB.Services
{
    public class ReservationService
    {
        DBConnection db;
        private IMongoCollection<Reservation> Collection;
        private const string ReservationCollection = "Reservation";
    }
}
