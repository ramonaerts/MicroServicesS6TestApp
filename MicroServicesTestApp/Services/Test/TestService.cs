using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesTestApp.Services.Test
{
    public class TestService : ITestService
    {
        public List<string> getTestList()
        {
            var stringList = new List<string>();

            const string a = "a"; stringList.Add(a);
            const string b = "b"; stringList.Add(b);
            const string c = "c"; stringList.Add(c);

            return stringList;
        }
    }
}
