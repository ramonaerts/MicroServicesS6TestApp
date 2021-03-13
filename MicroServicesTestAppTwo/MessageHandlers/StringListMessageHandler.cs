using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServicesTestAppTwo.Messages;
using Shared.Messaging;

namespace MicroServicesTestAppTwo.MessageHandlers
{
    public class StringListMessageHandler : IMessageHandler<StringList>
    {
        public StringListMessageHandler()
        {
            
        }

        public async Task HandleMessageAsync(string messageType, StringList message)
        {
            foreach (var item in message.List)
            {
                Console.WriteLine(item);
            }
        }
    }
}
