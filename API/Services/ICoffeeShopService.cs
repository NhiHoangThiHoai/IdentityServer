using API.Models;

namespace API.Services
{
    public interface ICoffeeShopService
    {
        public Task<List<CoffeeShopModel>> List();
    }
}
