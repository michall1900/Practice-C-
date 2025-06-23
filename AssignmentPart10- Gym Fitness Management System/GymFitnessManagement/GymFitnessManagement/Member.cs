using GymFitnessManagement.Utilities;

namespace GymFitnessManagement {
    /// <summary>
    /// Represents an abstract base class for a gym member.
    /// Contains common properties and methods for all member types.
    /// </summary>
    internal abstract class Member {
        private int _memberId;
        private int _age;

        /// <summary>
        /// Gets or sets the unique identifier for the member.
        /// Must be a positive number.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when the value assigned is not positive.
        /// </exception>
        public int MemberId {
            get { return _memberId; }
            set {
                InputValidator.CheckIfPositiveNumber(value);
                _memberId = value;
            }
        }

        /// <summary>
        /// Gets or sets the age of the member.
        /// Must be between 0 and 120 (inclusive).
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when the value assigned is outside the range 0 to 120.
        /// </exception>
        public int Age {
            get { return _age; }
            set {
                InputValidator.CheckIfIntInRange(value, 0, 120);
                _age = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the member.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        /// <param name="name">The name of the member.</param>
        /// <param name="age">The age of the member. Must be between 0 and 120 (inclusive).</param>
        /// <param name="memberId">The unique identifier for the member. Must be positive.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="age"/> is outside the range 0 to 120,
        /// or <paramref name="memberId"/> is not positive.
        /// </exception>
        public Member(string name, int age, int memberId)
        {
            Name = name;
            Age = age;
            MemberId = memberId;
        }

        /// <summary>
        /// Calculates the monthly fee for the member.
        /// Must be implemented by derived classes.
        /// </summary>
        /// <returns>The monthly fee as a double.</returns>
        public abstract double CalculateMonthlyFee();

        /// <summary>
        /// Displays the details of the member.
        /// Must be implemented by derived classes.
        /// </summary>
        public abstract void DisplayDetails();
    }
}