using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesTestAppTwo.Services
{
    public interface ISecondService
    {
        List<int> GetIntList();
        string GetHello();
    }
}
