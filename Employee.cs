using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Employee : Person
    {
        private String Name;
        private DateTime DateOfBirth;
        private String Email;
        private CreditCard Card;
        private String Id;
        private GymThing GymItems;
        private DateTime DateJoined;
        private FinancialRec Financial;
        private List<Request> RequestList;
        private String Profession;
        private String TheType;
        private Int64 Funds;

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
            return TheType;
        }
        public Int64 GetFunds()
        {
            return Funds;
        }

        //Setter
        public override Boolean SetName(String Nam)
        {
            if ()
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
            if ()
            {
                this.Email = Email;
                return true;
            }
            else
            {
                return false;
            }
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
            if ()
            {
                Id = ID;
                return true;
            }
            else
            {
                return false;
            }
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
            if ()
            {
                Profession = Prof;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean SetType (String T)
        {
            if ()
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
