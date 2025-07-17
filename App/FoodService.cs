using Domain;
using Contracts;
namespace App
{
    public class FoodService : IFoodService
    {
        private List<Food> _foodList = new List<Food>();
        public List<FoodDTO> GetAll()
        {
            if (_foodList == null)
            {
                Console.WriteLine("Food list is not initialized.");
                return new List<FoodDTO>();
            }
            return _foodList
                .Where(f => !f.isDeleted)
                .Select(f => new FoodDTO
                {
                    Id = f.Id,
                    Name = f.Name,
                    Category = f.Category,
                    Price = f.Price
                }).ToList();
        }

        public void Add(FoodDTO f)
        {
            if (f == null)
            {
                Console.WriteLine("Cannot add: input is null.");
                return;
            }
            if (_foodList.Any(o => o.Name.Equals(f.Name, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"food'{f.Name}' is already exist");
            }
            else
            {
                Food food = new Food(f.Name, f.Category, f.Price);
                _foodList.Add(food);
                Console.WriteLine($"food '{f.Name}' is added ");
            }
        }

        public void Remove(int id)
        {
            var food = _foodList.FirstOrDefault(x => x.Id == id);
            if (food == null)
            {
                Console.WriteLine($"Cannot delete: food with ID {id} not found.");
                return;
            }
            if (food.isDeleted)
            {
                Console.WriteLine($"Food with ID {id} is already deleted.");
                return;
            }
            food.isDeleted = true;
            Console.WriteLine($"Food '{food.Name}' has been deleted.");
        }

        public void Update(int id, FoodDTO f)
        {
            if (f == null)
            {
                Console.WriteLine("Cannot update: updated data is null.");
                return;
            }
            Food food = _foodList.FirstOrDefault(f => f.Id == id && !f.isDeleted);
            if (food != null)
            {
                food.Name = f.Name;
                food.Price = f.Price;
                food.Category = f.Category;
                Console.WriteLine($"Food ID {id} ('{food.Name}') has been updated.");
            }
            else
            {
                Console.WriteLine($"Food with ID {id} not found or has been deleted.");
            }
        }
    }
}
