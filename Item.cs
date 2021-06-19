using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Item
    {
        private String Name;
        private String Description;
        private String Type;

        //Getter
        public String GetName ()
        {
            return Name;
        }
        public String GetDesc()
        {
            return Description;
        }
        public new String GetType()
        {
            return Type;
        }

        //Setter
        public Boolean SetName(String Nam)
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
        public Boolean SetDesc(String Desc)
        {
            Boolean Valid = true;

            for (int i = 0; i < Desc.Length; i++)
            {
                if (!(Desc[i] >= 'A' && Desc[i] <= 'Z'))
                {
                    Valid = false;
                    break;
                }
                else if (!(Desc[i] >= 'A' && Desc[i] <= 'Z'))
                {
                    Valid = false;
                    break;
                }
                else if (!(Desc[i] != ' '))
                {
                    Valid = false;
                    break;
                }
            }

            if (Desc.Length > 150)
            {
                Valid = false;
            }

            if (Valid)
            {
                Description = Desc;
                return true;
            }
            else
            {
                return false;
            }
        }
        public new Boolean SetType (String It)
        {
            Boolean Valid = true;

            for (int i = 0; i < It.Length; i++)
            {
                if (!(It[i] >= 'A' && It[i] <= 'Z'))
                {
                    Valid = false;
                    break;
                }
                else if (!(It[i] >= 'A' && It[i] <= 'Z'))
                {
                    Valid = false;
                    break;
                }
                else if (!(It[i] != ' '))
                {
                    Valid = false;
                    break;
                }
            }

            if (It.Length > 25)
            {
                Valid = false;
            }

            if (Valid)
            {
                Type = It;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
