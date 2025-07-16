using Domain;
using Contracts;
namespace App
{
    public class FoodServices : FoodInterface
    {
        public List<Food> _foodList = new List<Food>();

        public List<FoodDTO> GetAll()
        {
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

        public void add(FoodDTO f)
        {
            if (_foodList.Any(o => o.Name.Equals(f.Name)))
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

        public void remove(FoodDTO f)
        {
            Food food = _foodList.FirstOrDefault(x => x.Id == f.Id);
            if (!food.isDeleted && food != null)
            {
                food.isDeleted = true;
                Console.WriteLine($"food '{f.Name}' has been deleted");
            }
            else
                Console.WriteLine($"food'{f.Name}' is not exist");
        }

        public void update(FoodDTO foodn, FoodDTO foodo)
        {
            Food food1 = _foodList.FirstOrDefault(o => o.Name == foodo.Name);

            if (food1 != null && !food1.isDeleted)
            {
                food1.Name = foodn.Name;
                food1.Price = foodn.Price;
                food1.Category = foodn.Category;
                food1.isUpdated = true;

                Console.WriteLine($"food'{food1.Name}' has been updated");
            }
            else
                Console.WriteLine($"food'{food1.Name}' is not exist");
        }
    }
}
