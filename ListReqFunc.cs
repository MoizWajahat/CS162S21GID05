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

        private HashSet<Exercise> ExerList;
        private HashSet<Machine> MachList;
        private List<Request> RequList;
        private List<Item> ItemList;
        private HashSet<WorkoutBase> WorkList;
        private List<FinancialRec> FineList;

        //Getter Functions
        public HashSet<Exercise> ExerGet()
        {
            return ExerList;
        }
        public HashSet<Machine> MachGet()
        {
            return MachList;
        }
        public List<Request> RequGet()
        {
            return RequList;
        }
        public List<Item> ItemGet()
        {
            return ItemList;
        }
        public HashSet<WorkoutBase> WorkGet()
        {
            return WorkList;
        }
        public List<FinancialRec> FineGet()
        {
            return FineList;
        }

        //Adder Funcs
        public void AddExer (Exercise E)
        {
            ExerList.Add(E);
        }
        public void AddMach(Machine M)
        {
            MachList.Add(M);
        }
        public void AddRequ(Request R)
        {
            RequList.Add(R);
        }
        public void AddItem(Item I)
        {
            ItemList.Add(I);
        }
        public void AddWork(WorkoutBase W)
        {
            WorkList.Add(W);
        }
        public void AddFine(FinancialRec F)
        {
            FineList.Add(F);
        }

        //DEL Funcs
        public Boolean DELExer (String Ename)
        {
            Boolean Done = false;

            foreach (Exercise Ex in ExerList)
            {
                if (Ex.getName() == Ename)
                {
                    ExerList.Remove(Ex);
                    Done = true;
                    break;
                }
            }

            return Done;
        }
        public Boolean DELMach(String Mname)
        {
            Boolean Done = false;

            foreach (Machine Ma in MachList)
            {
                if (Ma.getName() == Mname)
                {
                    MachList.Remove(Ma);
                    Done = true;
                    break;
                }
            }

            return Done;
        }
        public Boolean DELRequ(String REID)
        {
            Boolean Done = false;

            for (int i = 0; i < RequList.Count; i++)
            {
                if (RequList[i].GetReqID() == REID)
                {
                    RequList.RemoveAt(i);
                    Done = true;
                    break;
                }
            }

            return Done;
        }

    }
}
