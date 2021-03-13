using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesTestApp.Services.Test
{
    public interface ITestService
    {
        List<string> getTestList();
    }
}
