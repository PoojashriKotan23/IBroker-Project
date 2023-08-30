using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBroker.Models
{
    public class DTOLogin
    {
        public string User_ID { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string Param { get; set; }
    }
}
