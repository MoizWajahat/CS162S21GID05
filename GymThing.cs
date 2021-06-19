using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class GymThing
    {
        private List<Exercise> ExerList;
        private List<WorkoutBase> WorkList;
        private List<Machine> MachList;
        private List<Item> ItemList;

        //Getter Functions
        public List<Exercise> ExerGet ()
        {
            return ExerList;
        }
        public List<WorkoutBase> WorkGet()
        {
            return WorkList;
        }
        public List<Machine> MachGet()
        {
            return MachList;
        }
        public List<Item> ItemGet()
        {
            return ItemList;
        }
    }
}
