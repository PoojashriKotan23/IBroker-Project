using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBroker.Models
{
    internal class DashboardCase
    {
        public DashboardCase(string User, string Case_Desc, string Status, string Last_Update, string Tracking_ID)
        {
           this. User = User;
           this.Case_Desc = Case_Desc;
            this.Status = Status;
            this.Last_Update = Last_Update;
            this.Tracking_ID = Tracking_ID;
        }

        public string User { get; set; }
        public string Case_Desc { get; set; }
        public string Status { get; set; }
        public string Last_Update { get; set; }
        public string Tracking_ID { get; set; }
     

    }
}
