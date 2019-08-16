

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace netfrmwkremoting
{
    // Sample service
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class MyService : IWcf
    {
        public string Greet(string name)
        {
            return DateTime.Now.ToString() + name;
        }
    }
}
