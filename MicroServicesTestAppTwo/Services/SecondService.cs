using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesTestAppTwo.Services
{
    public class SecondService : ISecondService
    {
        public List<int> GetIntList()
        {
            var intList = new List<int>();

            const int a = 1; intList.Add(a);
            const int b = 2; intList.Add(b);
            const int c = 3; intList.Add(c);

            return intList;
        }

        public string GetHello()
        {
            return "Hello";
        }
    }
}
