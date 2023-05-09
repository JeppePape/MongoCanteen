using CanteenDB.Models;
using MongoDB.Driver;

namespace CanteenDB.Services
{
    public class CustomerService
    {
        DBConnection db;
        private IMongoCollection<Customer> Collection;
        private const string CitizenCollection = "Customer";
    }
}
