using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Admin : Employee
    {
        
        public new String GetType ()
        {
            TheType = "Admin";
            return TheType;
        }
        public new Boolean SetType (String T)
        {
            if (T == "Admin")
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
