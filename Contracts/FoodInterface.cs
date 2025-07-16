using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface FoodInterface 
    {
        List<FoodDTO> GetAll();

        void add(FoodDTO f);

        void remove(FoodDTO f);

        void update(FoodDTO fn, FoodDTO fo);
    }
}
