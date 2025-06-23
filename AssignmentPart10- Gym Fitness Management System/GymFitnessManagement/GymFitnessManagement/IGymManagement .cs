using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymFitnessManagement {
    internal interface IGymManagement 
    {
        void AddMember(Member newMember);
        void DisplayAllMembers();
    }
}
