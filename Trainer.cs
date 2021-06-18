using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Trainer : Employee
    {
        private PhysicalHealth Health;
        private List<String> Proficiency;
        private List<Customer> PersCustomers;

        //Getter
        public PhysicalHealth GetHealth()
        {
            return Health;
        }
        public List<String> GetProfi()
        {
            return Proficiency;
        }
        public List<Customer> GetPCusts()
        {
            return PersCustomers;
        }
        public new String GetType()
        {
            TheType = "Trainer";
            return TheType;
        }

        //Setter
        public Boolean SetHealth(PhysicalHealth HP)
        {
            if ()
            {
                Health = HP;
                return true;
            }
            else
            {
                return false;

            }
        }
        public Boolean SetProfi(List<String> Pr)
        {
            if ()
            {
                Proficiency = Pr;
                return true;
            }
            else
            {
                return false;

            }
        }
        public Boolean SetPCusts(List<Customer> PCust)
        {
            if ()
            {
                PersCustomers = PCust;
                return true;
            }
            else
            {
                return false;

            }
        }
        public new Boolean SetType(String T)
        {
            if (T == "Trainer")
            {
                TheType = T;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}



