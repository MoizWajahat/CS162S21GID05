using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Employee : Person
    {
        protected String Name;
        protected DateTime DateOfBirth;
        protected String Email;
        protected CreditCard Card;
        protected String Id;
        protected GymThing GymItems;
        protected DateTime DateJoined;
        protected FinancialRec Financial;
        protected List<Request> RequestList;
        protected String Profession;
        protected String TheType;
        protected Int64 Funds;

        //Getter
        public override String GetName()
        {
            return Name;
        }
        public override DateTime GetDOB()
        {
            return DateOfBirth;
        }
        public override String GetEmail()
        {
            return Email;
        }
        public override CreditCard GetCard()
        {
            return Card;
        }
        public override String GetId()
        {
            return Id;
        }
        public Boolean Getmemb()
        {
            return Membership;
        }
        public GymThing GetGItems()
        {
            return GymItems;
        }
        public DateTime GetJoin()
        {
            return DateJoined;
        }
        public FinancialRec GetFinancial()
        {
            return Financial;
        }
        public List<Request> GetRequests()
        {
            return RequestList;
        }
        public String GetProf()
        {
            return Profession;
        }
        public new String GetType()
        {
            TheType = "Other";
            return TheType;
        }
        public Int64 GetFunds()
        {
            return Funds;
        }

        //Setter
        public override Boolean SetName(String Nam)
        {
            Boolean Valid = true;

            for (int i = 0; i < Nam.Length; i++)
            {
                if (!(Nam[i] >= 'A' && Nam[i] <= 'Z'))
                {
                    Valid = false;
                    break;
                }
                else if (!(Nam[i] >= 'A' && Nam[i] <= 'Z'))
                {
                    Valid = false;
                    break;
                }
                else if (!(Nam[i] != ' '))
                {
                    Valid = false;
                    break;
                }
            }
            if (Nam.Length > 70)
            {
                Valid = false;
            }

            if (Valid)
            {
                Name = Nam;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override Boolean SetDOB(DateTime DOB)
        {
            if ()
            {
                DateOfBirth = DOB;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override Boolean SetEmail(String Email)
        {
            bool flag = false;
            for (int i = 0; i < Email.Length; i++)
            {
                if (Email[i] >= 'A' && Email[i] <= 'Z' && Email[i] == '@' && Email[i] == '.' || Email[i] >= 'a' && Email[i] <= 'z' && Email[i] == '@' && Email[i] == '.')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }
        public override Boolean SetCard(CreditCard Credit)
        {
            if ()
            {
                Card = Credit;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override Boolean SetId(String ID)
        {
            bool flag = false;
            for (int i = 0; i < ID.Length; i++)
            {
                if (ID[i] >= '0' && ID[i] <= '9')
                {
                    Id = ID;
                    flag = true;
                }
            }
            return flag;
        }
        public Boolean SetGymT(GymThing Item)
        {
            if ()
            {
                GymItems = Item;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SetJoin(DateTime Join)
        {
            if ()
            {
                DateJoined = Join;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SetFRec(FinancialRec Rec)
        {
            if ()
            {
                Financial = Rec;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SetReqList(List<Request> RList)
        {
            if ()
            {
                RequestList = RList;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SetProf (String Prof)
        {
            bool flag = false;
            for(int i=0;i<Prof.Length;i++)
            {
                if(Prof[i]>='A' && Prof[i]<='Z'  || Prof[i] >= 'a' && Prof[i] <= 'z' || Prof[i]==' ')
                {
                    this.Profession = Prof;
                    flag = true;
                }
            }
            return flag;
        }
        public Boolean SetType (String T)
        {
            if (T == "Other")
            {
                TheType = T;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SetFunds (Int64 FF)
        {
            if ()
            {
                Funds = FF;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
