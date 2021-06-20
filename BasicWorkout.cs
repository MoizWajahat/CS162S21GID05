using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BasicWorkout : WorkoutBase
    {
        public String Name;
        private String Time;
        private List<Exercise> ExerciseList;
        private List<Trainer> Trainer;
        private List<Customer> Customer;
        private String Cost;
        private List<Machine> Machine;

        //Getters
        public override String GetName()
        {
            return Name;
        }

        //Setter
        public override Boolean SetName(String Nam)
        {
            Boolean Valid = true;

            for (int i = 0; i < Nam.Length; i++)
            {
                if (!(Nam[i] >= 'A' && Nam[i] <= 'Z'))
                {
                    Valid = false;
                    break;
                }
                else if (!(Nam[i] >= 'A' && Nam[i] <= 'Z'))
                {
                    Valid = false;
                    break;
                }
                else if (!(Nam[i] != ' '))
                {
                    Valid = false;
                    break;
                }
            }
            if (Nam.Length > 30)
            {
                Valid = false;
            }

            if (Valid)
            {
                Name = Nam;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
