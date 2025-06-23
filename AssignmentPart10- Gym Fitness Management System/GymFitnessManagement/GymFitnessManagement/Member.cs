using GymFitnessManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymFitnessManagement {
    internal abstract class Member {

        private int _memberId;
        private int _age;

        public int MemberId 
        { 
            get { return _memberId; }
            set 
            {
                InputValidator.CheckIfPositiveNumber(value);
                _memberId = value;
            }    
        }

        public int Age 
        {
            get { return _age; }
            set {
                InputValidator.CheckIfIntInRange(value, 0, 120);
                _age = value;
            }
        }

        public string Name { get; set; }

        public Member(string name, int age, int memberId)
        {
            Name = name;
            Age = age;
            MemberId = memberId;
        }

        public abstract double CalculateMonthlyFee();
        public abstract void DisplayDetails();

    }
}
