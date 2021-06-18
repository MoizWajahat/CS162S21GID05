using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SystemFunctions
    {
        private SystemFunctions() { }
        private static SystemFunctions Instance = null;

        public static SystemFunctions GetInstance ()
        {
            if (Instance == null)
            {
                Instance = new SystemFunctions();
            }
            return Instance;
        }

        private List<Guest> GuestList;
        private List<Customer> CustoList;
        private List<Employee> EmploList;
        private List<String> FactsList;

        //Getter
        public List<Guest> GetGList ()
        {
            return GuestList;
        }
        public List<Customer> GetCList()
        {
            return CustoList;
        }
        public List<Employee> GetEList()
        {
            return EmploList;
        }
        public List<String> GetFList()
        {
            return FactsList;
        }
        //OTHER
        public void LoadFromFiles ()
        {

        }
        public void AddGlist (Guest G)
        {
            GuestList.Add(G);
        }
        public void AddClist(Customer C)
        {
            CustoList.Add(C);
        }
        public void AddElist(Employee E)
        {
            EmploList.Add(E);
        }
        public void AddFlist(String F)
        {
            FactsList.Add(F);
        }

        public void DELGuest (String ID)
        {
            for (int i = 0; i < GuestList.Count; i++)
            {
                if (GuestList[i].GetId() == ID )
                {
                    GuestList.RemoveAt(i);
                    break;
                }
            }
        }
        public void DELCusto(String ID)
        {
            for (int i = 0; i < CustoList.Count; i++)
            {
                if (CustoList[i].GetId() == ID)
                {
                    CustoList.RemoveAt(i);
                    break;
                }
            }
        }
        public void DELEmplo(String ID)
        {
            for (int i = 0; i < EmploList.Count; i++)
            {
                if (EmploList[i].GetId() == ID)
                {
                    EmploList.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
