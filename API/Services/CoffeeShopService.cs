using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class CoffeeShopService : ICoffeeShopService
    {
        private readonly ApplicationDbContext dbContext;

        public CoffeeShopService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<CoffeeShopModel>> List()
        {
            var coffeeShops = await (from Shop in dbContext.CoffeeShops
                                     select new CoffeeShopModel()
                                     {
                                         Id = Shop.Id,
                                         Name = Shop.Name,
                                         OpeningHours = Shop.OpeningHours,
                                         Address = Shop.Address,
                                     }).ToListAsync();
            return coffeeShops;
        }
    }
}
