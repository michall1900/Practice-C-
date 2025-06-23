

using GymFitnessManagement.Utilities;

namespace GymFitnessManagement {
    internal class RegularMember : Member {
        
        private double _workoutPlanFee;

        public double WorkoutPlanFee {

            get { return _workoutPlanFee; }
            set {
                InputValidator.CheckIfPositiveNumber(value);    
                _workoutPlanFee = value; 
            }
        }

        public RegularMember(string name, int age, int memberId, double workoutPlanFee): 
            base(name, age, memberId) 
        {
            WorkoutPlanFee = workoutPlanFee;
        }

        public override double CalculateMonthlyFee()
        {
            return 50.0 + WorkoutPlanFee;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"MemberId:{MemberId}, Name: {Name}, Age: {Age}, " +
                $"MonthlyFee: {CalculateMonthlyFee()}");
        }
    }
}
