using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServicesTestApp.Services.Test;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.Messaging;

namespace MicroServicesTestApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;
        private readonly IMessagePublisher _messagePublisher;

        public TestController(ITestService testService, IMessagePublisher messagePublisher)
        {
            _testService = testService;
            _messagePublisher = messagePublisher;
        }

        [HttpGet]
        [Route("test")]
        public ApiResult GetRestList()
        {
            var stringList = _testService.getTestList();

            _messagePublisher.PublishMessageAsync("StringList", new { List = stringList });

            return ApiResult.Success(stringList);
        }
    }
}
