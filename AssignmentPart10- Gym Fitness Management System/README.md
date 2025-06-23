# Gym Fitness Management System

This C# console application implements a Gym Fitness Management System using **abstract classes**, **interfaces**, and **polymorphism**.

## Objective

The project demonstrates object-oriented principles by modeling different types of gym members (`RegularMember`, `PremiumMember`) and managing them via an interface-driven gym class (`Gym`). Validation utilities ensure that only valid data is accepted.

---

## Structure

### Abstract Class: `Member`
Defines the base structure for all members, including:
- `Name`, `Age`, `MemberId` properties with validation
- Abstract methods:
  - `CalculateMonthlyFee()`
  - `DisplayDetails()`

### Derived Classes
- **`RegularMember`**  
  Adds `WorkoutPlanFee`  
  - Monthly fee = `$50 + WorkoutPlanFee`

- **`PremiumMember`**  
  Adds `PersonalTrainerFee` and `DietPlanFee`  
  - Monthly fee = `$100 + PersonalTrainerFee + DietPlanFee`

### Interface: `IGymManagement`
Defines gym operations:
- `AddMember(Member member)`
- `DisplayAllMembers()`

### Class: `Gym`
Implements `IGymManagement` and holds a list of `Member` instances.

### Utility: `InputValidator`
Performs runtime validation on:
- Age and ID ranges
- Positive fee values

---

## How to Run

1. Clone or copy the project into a C# development environment (e.g., Visual Studio).
2. Build and run the project.
3. The `Main` method:
   - Creates a `Gym`
   - Adds two `RegularMember` and two `PremiumMember` instances
   - Displays their details and calculated monthly fees.

---

## Sample Output

MemberId:1, Name: John Doe, Age: 25, MonthlyFee: 70
MemberId:2, Name: Jane Smith, Age: 30, MonthlyFee: 65
MemberId:3, Name: Mike Brown, Age: 35, MonthlyFee: 180
MemberId:4, Name: Anna White, Age: 28, MonthlyFee: 185.44


---

## Key Concepts Demonstrated
- Abstract class inheritance
- Method overriding and polymorphism
- Interface implementation
- Input validation and exception handling
- Clear XML documentation for each class and method

---

## File Structure

GymFitnessManagement/
│
├── Program.cs
├── Member.cs (abstract)
├── RegularMember.cs
├── PremiumMember.cs
├── Gym.cs
├── IGymManagement.cs
└── Utilities/
└── InputValidator.cs


---

## Requirements

- .NET 6.0 or higher (or compatible environment)
- Console-based execution

---

## License

For educational purposes only.
