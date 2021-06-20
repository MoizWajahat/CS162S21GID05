using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class WorkoutBase
    {
        public String Name;
        public DateTime time;
        public List<Exercise> ExcerciseList;
        public List<Customer> CoustomerList;
        public List<Trainer> TrainerList;
        public List<Machine> MachineList;
        public String Cost;

        //Getter
        public abstract String GetName();

        //Setter
        public abstract Boolean SetName(String Nam);
    }
}
