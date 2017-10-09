using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceProjectTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class IzingaService : IIzingaService
    {
        public List<Log> GetLogs(string parameter1 = "", string parameter2 = "")
        {
            
        }
    }
}
