using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceAnastassia
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWelcomeWCFService" in both code and config file together.
    [ServiceContract]
    public interface IWelcomeWCFService
    { 
        [OperationContract]
        void DoWork();
        [OperationContract]
        [WebGet(UriTemplate = "/Welcome/{name}")]
        string Welcome(string name);
    }
}
