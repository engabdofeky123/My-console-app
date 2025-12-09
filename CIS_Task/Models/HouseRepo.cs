using CIS_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_Task.Models
{


    public class HouseRepo : IHouseRepository
    {
        private readonly List<House> houses;
        public HouseRepo()
        {
         houses = new List<House>();   
        }

        public void AddHouse(House house)
        {
            houses.Add(house);
        }

        public IEnumerable<House> GetAllHouses()
        {
            return houses;
        }
    }
}
