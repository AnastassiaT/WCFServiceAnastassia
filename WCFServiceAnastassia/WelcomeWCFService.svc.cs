using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceAnastassia
{
    public class WelcomeWCFService : IWelcomeWCFService
    {
        public void DoWork()
        {
            throw new NotImplementedException();
        }
        public string Welcome(string name)
        {
            return "Welcome to the first WCF Web Service Application " + name;
        }
    }
}
