using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServicesTestApp;
using MicroServicesTestAppTwo.Services;
using Microsoft.AspNetCore.Mvc;

namespace MicroServicesTestAppTwo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecondController : ControllerBase
    {
        private readonly ISecondService _secondService;

        public SecondController(ISecondService secondService)
        {
            _secondService = secondService;
        }

        [HttpGet]
        [Route("int")]
        public ApiResult GetIntList()
        {
            var stringList = _secondService.GetIntList();

            return ApiResult.Success(stringList);
        }

        [HttpGet]
        [Route("hello")]
        public ApiResult GetHello()
        {
            var hello = _secondService.GetHello();

            return ApiResult.Success(hello);
        }

        [HttpGet]
        [Route("rabbit")]
        public ApiResult GetRabbit()
        {

            return ApiResult.Success("");
        }
    }
}
