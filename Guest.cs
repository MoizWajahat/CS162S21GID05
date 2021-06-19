using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Guest : Person
    {
        private String Name;
        private CreditCard Card;
        private String Id;
        //private DateTime DateArr;kjadbnfkjaen

        //GETTER
        public override String GetName()
        {
            return Name;
        }
        public override CreditCard GetCard()
        {
            return Card;
        }
        public override String GetId()
        {
            return Id;
        }

        //SETTER
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
                else if (!(Name[i] != ' '))
                {
                    Valid = false;
                    break;
                }
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

        public override DateTime GetDOB()
        {
            throw new NotImplementedException();
        }

        public override string GetEmail()
        {
            throw new NotImplementedException();
        }

        public override bool SetDOB(DateTime DOB)
        {
            throw new NotImplementedException();
        }

        public override bool SetEmail(string Email)
        {
            throw new NotImplementedException();
        }
    }
}
