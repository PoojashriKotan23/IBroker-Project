using IBrokerService.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IBrokerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIBrokerService" in both code and config file together.
    [ServiceContract]
    public interface IIBrokerService
    {
        [OperationContract]
        string  GetLogin(LoginDetails Login);
    }
}
