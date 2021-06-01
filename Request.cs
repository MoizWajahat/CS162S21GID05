using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Request
    {
        private String Title;
        private String Reasoning;
        private String Status;
        private String Requestor;
        private DateTime DateTimeRequested;

        public bool SetTitle(String Title)
        {
            this.Title = Title;
            return true;
        }
        public bool SetReasoning(String Reasoning)
        {
            this.Reasoning = Reasoning;
            return true;
        }
        public bool SetStatus(String Status)
        {
            this.Status = Status;
            return true;
        }
        public bool SetRequestor(String Requestor)
        {
            this.Requestor = Requestor;
            return true;
        }
        public bool SetDateTimeRequested(DateTime DateTimeRequested)
        {
            this.DateTimeRequested = DateTimeRequested;
            return true;
        }
        public String getTitle()
        {
            return Title;
        }
        public String getReasoning()
        {
            return Reasoning;
        }
        public String getStatus()
        {
            return Status;
        }
        public String getRequestor()
        {
            return Requestor;
        }

        public DateTime getDateTimeRequested()
        {
            return DateTimeRequested;
        }
    }
}
