using GymFitnessManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymFitnessManagement {
    internal class PremiumMember : Member {
        private double _personalTrainerFee;
        private double _dietPlanFee;

        public double PersonalTrainerFee
        {
            get { return _personalTrainerFee; }
            set 
            {
                InputValidator.CheckIfPositiveNumber(value);
                _personalTrainerFee = value; 
            }
        }
        public double DietPlanFee 
        { 
            get { return _dietPlanFee; }
            set 
            {
                InputValidator.CheckIfPositiveNumber(value);
                _dietPlanFee = value;
            }
        }

        public PremiumMember(string name, int age, int memberId, 
            double personalTrainerFee, double dietPlanFee)
            : base(name, age, memberId) 
        {
            PersonalTrainerFee = personalTrainerFee;
            DietPlanFee = dietPlanFee;
        }

        public override double CalculateMonthlyFee()
        {
            return 100.0 + PersonalTrainerFee + DietPlanFee;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"MemberId:{MemberId}, Name: {Name}, Age: {Age}, " +
                $"MonthlyFee: {CalculateMonthlyFee()}");
        }
    }
}
