using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Person
    {
        private String Name;
        private DateTime DateOfBirth;
        private String Email;
        private CreditCard Card;
        private String Id;

        //Getter
        public abstract String GetName();
        public abstract DateTime GetDOB();
        public abstract String GetEmail();
        public abstract CreditCard GetCard();
        public abstract String GetId();

        //Setter
        public abstract Boolean SetName();
        public abstract Boolean SetDOB();
        public abstract Boolean SetEmail();
        public abstract Boolean SetCard();
        public abstract Boolean SetId();

    }
}
