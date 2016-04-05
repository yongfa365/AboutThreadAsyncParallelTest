using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace ApiServer.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        [Route("api/Test/Sleep/{seconds}")]
        public string Sleep(int seconds)
        {
            var timer = DateTime.Now;
            Thread.Sleep(seconds);
            return $"{DateTime.Now - timer} OK";
        }

        [HttpGet]
        [Route("api/Test/Size/{seconds}/{length}")]
        public string Size(int seconds, int length)
        {
            var timer = DateTime.Now;
            Thread.Sleep(seconds);
            return $"{DateTime.Now - timer} OK".PadRight(length,'★');
        }

        [HttpGet]
        [Route("api/Test/Init/{workerThreads}/{completionPortThreads}")]
        public string Init(int workerThreads, int completionPortThreads)
        {
            var timer = DateTime.Now;
            var isOK = ThreadPool.SetMinThreads(workerThreads, completionPortThreads);

            return $"{DateTime.Now - timer} OK:{isOK}";
        }

    }
}
