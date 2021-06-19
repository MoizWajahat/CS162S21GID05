using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Customer : Person
    {
        private String Name;
        private DateTime DateOfBirth;
        private String Email;
        private CreditCard Card;
        private String Id;
        private Boolean Membership;
        private GymThing GymItems;
        private DateTime DateJoined;
        private FinancialRec Financial;
        private Trainer PersonalTrainer;
        private List<Request> RequestList;
        private PhysicalHealth Health;

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
        public Trainer GetPTrainer()
        {
            return PersonalTrainer;
        }
        public List<Request> GetRequests()
        {
            return RequestList;
        }
        public PhysicalHealth GetHealth ()
        {
            return Health;
        }

        //Setter
        public override Boolean SetName(String Nam)
        {
            Boolean Valid = true;

            for (int i=0; i<Nam.Length; i++)
            {
                if (!(Nam[i] >= 'A' && Nam[i] <= 'Z' ))
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
        public Boolean SetMemb(Boolean Status)
        {
            if ()
            {
                Membership = Status;
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
        public Boolean SetPTrain(Trainer mem)
        {
            if ()
            {
                PersonalTrainer = mem;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
