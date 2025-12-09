using CIS_Task.Interfaces;
using CIS_Task.Models;

namespace CIS_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHouseRepository repo = new HouseRepo();
            repo.AddHouse(new House(1, "Abdelrahman", 2, 5, -5));
            repo.AddHouse(new House(2, "Mohammed", 1, 6, -2));
            repo.AddHouse(new House(3, "Ibrahem", 3, 4, -10));
            repo.AddHouse(new House(4, "Abdo", 2, 3, 0));
            repo.AddHouse(new CatShelter(5, "Ahmed", 1, 7, -8, "Whiskers"));

           
            Dictionary<int, double> latestTemps = new Dictionary<int, double>
        {
            {1, -7},
            {2, -3},
            {3, -12},
            {4, -1},
            {5, -9}
        };

            foreach (var house in repo.GetAllHouses())
            {
                if (latestTemps.TryGetValue(house.Id, out double temp))
                {
                    house.OutsideTemperature = temp;
                }
            }

            
            var billing = new BillingService(repo, CostStratigies.Standard_Cost);

           
            string report = billing.GenerateReport();

            Console.WriteLine("=== IceCity Heating Cost Report ===");
            Console.WriteLine(report);
        }
    }
}
