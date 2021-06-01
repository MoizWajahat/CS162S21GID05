using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Excercise
    {
        private String Name;
        private String Description;
        private String Benefit;
        private String RecTime;
        private String AvoidRec;


        public bool SetName(String Name)
        {
            this.Name = Name;
            return true;
        }
        public bool SetDescription(String Description)
        {
            this.Description = Description;
            return true;
        }
        public bool SetBenefit(String Benefit)
        {
            this.Benefit = Benefit;
            return true;
        }
        public bool SetRecTime(String RecTime)
        {
            this.RecTime = RecTime;
            return true;
        }
        public bool SetAvoidRec(String AvoidRec)
        {
            this.AvoidRec = AvoidRec;
            return true;
        }
        
        public String getName()
        {
            return Name;
        }
        public String getDescription()
        {
            return Description;
        }
        public String getBenefit()
        {
            return Benefit;
        }
        public String getRecTime()
        {
            return RecTime;
        }
        public String getAvoidRec()
        {
            return AvoidRec;
        }


    }
}
