using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IFoodService 
    {
        List<FoodDTO> GetAll();
        void Add(FoodDTO f);
        public void Remove(int id);
        void Update(int id, FoodDTO f);
    }
}
