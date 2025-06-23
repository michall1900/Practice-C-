using GymFitnessManagement.Utilities;

namespace GymFitnessManagement {
    /// <summary>
    /// Represents a regular gym member with an additional workout plan fee.
    /// </summary>
    internal class RegularMember : Member {

        private double _workoutPlanFee;

        /// <summary>
        /// Gets or sets the fee for the workout plan.
        /// Must be a positive number.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when the value assigned is not positive.
        /// </exception>
        public double WorkoutPlanFee {
            get { return _workoutPlanFee; }
            set {
                InputValidator.CheckIfPositiveNumber(value);
                _workoutPlanFee = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegularMember"/> 
        /// class.
        /// </summary>
        /// <param name="name">The name of the member.</param>
        /// <param name="age">The age of the member. Must be between 0 
        /// and 120 (inclusive).</param>
        /// <param name="memberId">The unique identifier for the member. 
        /// Must be positive.</param>
        /// <param name="workoutPlanFee">The fee for the workout plan. 
        /// Must be positive.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="age"/> is outside the range 0 
        /// to 120,
        /// <paramref name="memberId"/> is not positive,
        /// or <paramref name="workoutPlanFee"/> is not positive.
        /// </exception>
        public RegularMember(string name, int age, int memberId, 
            double workoutPlanFee) : base(name, age, memberId)
        {
            WorkoutPlanFee = workoutPlanFee;
        }

        /// <summary>
        /// Calculates the monthly fee for the regular member.
        /// </summary>
        /// <returns>The total monthly fee as a double.</returns>
        public override double CalculateMonthlyFee()
        {
            return 50.0 + WorkoutPlanFee;
        }

        /// <summary>
        /// Displays the details of the regular member.
        /// </summary>
        public override void DisplayDetails()
        {
            Console.WriteLine($"MemberId:{MemberId}, Name: {Name}, " +
                $"Age: {Age}, MonthlyFee: {CalculateMonthlyFee()}");
        }
    }
}