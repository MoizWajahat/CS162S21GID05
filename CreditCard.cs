using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CreditCard
    {
        private String CardNum;
        private String HolderName;
        private DateTime ExpDate;
        private String SecurityCode;
        private String BillingAdd;

        //Getters
        public String GetCardNum()
        {
            return CardNum;
        }
        public String GetHolderName()
        {
            return HolderName;
        }
        public DateTime GetExpDate()
        {
            return ExpDate;
        }
        public String GetSecurityCode()
        {
            return SecurityCode;
        }
        public String GetBillingAdd()
        {
            return BillingAdd;
        }

        //Setters
        public Boolean SetCardNum(String CardNo)
        {
            if ()
            {
                this.CardNum = CardNo;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SetHolderName(String Holder)
        {
            if ()
            {
                this.HolderName = Holder;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SetExpDate(DateTime Exp)
        {
            if ()
            {
                this.ExpDate = Exp;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SetSecurityCode(String Sec)
        {
            if ()
            {
                this.SecurityCode = Sec;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SetBillingAdd(String BillAdd)
        {
            if ()
            {
                this.BillingAdd = BillAdd;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
