# IceCity Heating Management

## Project Description
This is a C# Console Application that simulates managing heating costs in IceCity during a severe ice storm.  
The project focuses on:

- Managing houses and their heating usage.
- Calculating monthly heating costs using different strategies (Delegates).
- Generating a detailed report using `StringBuilder`.
- Demonstrating inheritance with `CatShelter` as a special type of house.

**Note:** This simplified version does not include sensors or events.

---

## Main Components

- **House**  
  Represents a house with properties such as number of heaters, hours per day, and outside temperature.

- **CatShelter**  
  Inherits from `House` and adds a `CatName` property.

- **IHouseRepository / InMemoryHouseRepository**  
  Stores houses in memory.

- **BillingService**  
  Calculates monthly heating costs for all houses and supports multiple cost strategies.

- **CostStrategies**  
  Provides different strategies for cost calculation using Delegates.

- **EmptyClass.cs**  
  A placeholder empty class as required for GitHub submission.

---

## How to Run

1. Open the project in any C# IDE (Visual Studio, VS Code, etc.).
2. Ensure all required files are included:
   - `Program.cs`
   - `House.cs`
   - `CatShelter.cs`
   - `IHouseRepository.cs`
   - `InMemoryHouseRepository.cs`
   - `BillingService.cs`
   - `CostStrategies.cs`
   - `EmptyClass.cs`
3. Run the project.
4. The console will display the heating cost report for all houses.
