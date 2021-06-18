using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ListReqFunc
    {
        private ListReqFunc() { }
        private static ListReqFunc Instance = null;

        public static ListReqFunc GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ListReqFunc();
            }
            return Instance;
        }

        private List<Exercise> ExerList;
        private List<Machine> MachList;
        private List<Request> RequList;
        private List<Item> ItemList;
        private List<WorkoutBase> WorkList;
        private List<FinancialRec> FineList;
    }
}
