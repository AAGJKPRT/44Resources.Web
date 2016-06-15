using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _44Resources.WCF.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "_44Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select 44Service.svc or 44Service.svc.cs at the Solution Explorer and start debugging.
    public class _44Service : I44Service
    {
        public string DoWork()
        {
            return "Foo";
        }
    }
}
