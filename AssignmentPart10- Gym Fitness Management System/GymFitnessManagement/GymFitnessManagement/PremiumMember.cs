using GymFitnessManagement.Utilities;

namespace GymFitnessManagement {
    /// <summary>
    /// Represents a premium gym member with additional personal trainer 
    /// and diet plan fees.
    /// </summary>
    internal class PremiumMember : Member {
        private double _personalTrainerFee;
        private double _dietPlanFee;

        /// <summary>
        /// Gets or sets the fee for the personal trainer.
        /// Must be a positive number.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when the value assigned is not positive.
        /// </exception>
        public double PersonalTrainerFee {
            get { return _personalTrainerFee; }
            set {
                InputValidator.CheckIfPositiveNumber(value);
                _personalTrainerFee = value;
            }
        }

        /// <summary>
        /// Gets or sets the fee for the diet plan.
        /// Must be a positive number.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when the value assigned is not positive.
        /// </exception>
        public double DietPlanFee {
            get { return _dietPlanFee; }
            set {
                InputValidator.CheckIfPositiveNumber(value);
                _dietPlanFee = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PremiumMember"/> 
        /// class.
        /// </summary>
        /// <param name="name">The name of the member.</param>
        /// <param name="age">The age of the member. Must be between 0 
        /// and 120 (inclusive).</param>
        /// <param name="memberId">The unique identifier for the member. 
        /// Must be positive.</param>
        /// <param name="personalTrainerFee">The fee for the 
        /// personal trainer. Must be positive.</param>
        /// <param name="dietPlanFee">The fee for the diet plan. 
        /// Must be positive.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="age"/> is outside the 
        /// range 0 to 120,
        /// <paramref name="memberId"/> is not positive,
        /// <paramref name="personalTrainerFee"/> is not positive,
        /// or <paramref name="dietPlanFee"/> is not positive.
        /// </exception>
        public PremiumMember(string name, int age, int memberId,
            double personalTrainerFee, double dietPlanFee)
            : base(name, age, memberId)
        {
            PersonalTrainerFee = personalTrainerFee;
            DietPlanFee = dietPlanFee;
        }

        /// <summary>
        /// Calculates the monthly fee for the premium member.
        /// </summary>
        /// <returns>The total monthly fee as a double.</returns>
        public override double CalculateMonthlyFee()
        {
            return 100.0 + PersonalTrainerFee + DietPlanFee;
        }

        /// <summary>
        /// Displays the details of the premium member.
        /// </summary>
        public override void DisplayDetails()
        {
            Console.WriteLine($"MemberId:{MemberId}, Name: {Name}, " +
                $"Age: {Age}, MonthlyFee: {CalculateMonthlyFee()}");
        }
    }
}