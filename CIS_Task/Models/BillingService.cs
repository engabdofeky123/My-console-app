using CIS_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_Task.Models
{

    public delegate double CostStrategy(House house);


    public class BillingService
    {
        private readonly IHouseRepository repository;
        private CostStrategy costStrategy; 
        public BillingService(IHouseRepository repo, CostStrategy st)
        {
            repository = repo;
            costStrategy = st;
        }

        public void SetStrategy(CostStrategy strategy)
        {
            costStrategy = strategy ;
        }

        public double CalculateMonthlyCost(House house)
        {
            return house.Calculate_Monthly_Cost(costStrategy);
        }

        public string GenerateReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("IceCity Heating Report:");
            foreach (var house in repository.GetAllHouses())
            {
                sb.AppendLine($"{house.Generate_Report()} - Monthly Cost: {CalculateMonthlyCost(house):C}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
