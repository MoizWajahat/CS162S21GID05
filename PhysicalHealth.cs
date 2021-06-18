using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PhysicalHealth
    {
        private DateTime LastChecked;
        private List<String> Parameters;

        //GETTER

        public DateTime GetLastChecked ()
        {
            return LastChecked;
        }
        public List<String> GetPara ()
        {
            return Parameters;
        }

        //SETTER

        public Boolean SetCheckDate (DateTime CHD)
        {
            if ()
            {
                LastChecked = CHD;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SetPara (List<String> Para)
        {
            if ()
            {
                Parameters = Para;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
