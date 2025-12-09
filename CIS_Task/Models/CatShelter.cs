using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_Task.Models
{
    public class CatShelter : House
    {
        public string CatName { get; private set; }

        public CatShelter(int id, string ownerName, int heaters, double hoursPerDay, double outsideTemperature, string catName)
            : base(id, ownerName, heaters, hoursPerDay, outsideTemperature)
        {
            if (string.IsNullOrWhiteSpace(catName)) throw new ArgumentException("Cat name is required");
            CatName = catName;
        }

        public override string Generate_Report()
        {
            return base.Generate_Report() + $", Cat: {CatName}";
        }

    }
}
 