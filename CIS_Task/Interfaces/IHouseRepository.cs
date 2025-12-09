using CIS_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_Task.Interfaces
{
    public interface IHouseRepository 
    {
        public IEnumerable<House> GetAllHouses();
        public void AddHouse(House house);
    }
}
