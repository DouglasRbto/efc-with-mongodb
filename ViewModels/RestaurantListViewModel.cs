using RestRes.Models;
using System.Transactions;

namespace RestRes.ViewModels
{
    public class RestaurantListViewModel
    {
        public IEnumerable<Restaurant>? Restaurants { get; set; }
    }
}
