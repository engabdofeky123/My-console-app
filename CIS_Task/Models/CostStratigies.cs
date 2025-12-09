using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_Task.Models
{
    public static class CostStratigies
    {
        public static double Standard_Cost(House house)
        {
            double costHeaterPerHour = 0.5;
            return house.Heaters * house.HoursPerDay * costHeaterPerHour * 30;
        }

        public static double Winter_Peak_Cost(House house)
        { 
            double costHeaterPerHour = 0.7; // higher rate for extreme cold
            return house.Heaters * house.HoursPerDay * costHeaterPerHour * 30;
        }
    }
}
