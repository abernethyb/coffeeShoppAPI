using CoffeeShop.Models;
using System.Collections.Generic;

namespace CoffeeShop.Repositories
{
    public interface ICoffeeRepository
    {
        void Add(Coffee coffee);
        void Delete(int id);
        Coffee Get(int id);
        List<Coffee> GetAllCoffees();
        void Update(Coffee coffee);
    }
}