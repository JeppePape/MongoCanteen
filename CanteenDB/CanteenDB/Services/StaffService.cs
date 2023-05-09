using CanteenDB.Models;
using MongoDB.Driver;

namespace CanteenDB.Services
{
    public class StaffService
    {
        DBConnection db;
        private IMongoCollection<Staff> Collection;
        private const string StaffCollection = "Staff";
    }
}
