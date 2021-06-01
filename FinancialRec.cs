using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FinancialRec
    {
        public String Amount;
        public String Reason;
        public String ID;
        public DateTime DateNTime;

        public bool SetAmount(String Amount)
        {
            this.Amount = Amount;
                return true;
        }
        public bool SetReason(String Reason )
        {
            this.Reason = Reason;
                return true;
        }
        public bool SetID(String ID )
        {
            this.ID = ID;
                return true;
        }

        public bool SetDateNTime(DateTime DateNTime)
        {
            this.DateNTime = DateNTime;
            return true;
        }

         public String getAmount()
        {
            return Amount;
        }
        public String getReason()
        {
            return Reason;
        }
        public String getID()
        {
            return ID;
        }
      
        public DateTime getDateNTime()
        {
            return DateNTime;
        }

    }
}
