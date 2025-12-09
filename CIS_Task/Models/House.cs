using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_Task.Models
{
    public class House
    {
        public int Id { get; set; }
        public string OwnerName { get;  set; }
        public int Heaters { get;  set; }
        public double HoursPerDay { get;  set; }
        public double OutsideTemperature { get;  set; }

        public House(int id, string ownerName, int heaters, double hoursPerDay, double outsideTemperature)
        {
            if(id<=0)
                throw new ArgumentException("Id must be > 0");
            if (string.IsNullOrEmpty(ownerName))
                throw new ArgumentException("Name is required");
            if (heaters < 0) 
                throw new ArgumentException("Heaters cannot be negative");
            if (hoursPerDay < 0 || hoursPerDay > 24) 
                throw new ArgumentException("Hours per day must be 0-24");

            Id = id;
            OwnerName = ownerName;
            Heaters = heaters;
            HoursPerDay = hoursPerDay;
            OutsideTemperature = outsideTemperature;
        }

        public double Calculate_Monthly_Cost(CostStrategy str)
        {
            return str(this);
        }
        public virtual string Generate_Report()=>  $"House {Id} :\n\n ({OwnerName}):- {Heaters} heaters running {HoursPerDay}h/day, Outside Temp: {OutsideTemperature}°C";

        public void UpdateUsage(int? heaters, double? hoursPerDay)
        {
            if (heaters is not null && heaters > 0 )
                Heaters =(int) heaters;
            if (hoursPerDay is not null && hoursPerDay > 0)
                HoursPerDay = (int)hoursPerDay;
        }
    }
}
