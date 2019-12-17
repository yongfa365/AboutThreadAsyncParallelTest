using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    //need to set server's MinThread to get the best performance
    public class DefaultController : Controller
    {
        public async Task<ActionResult> AsyncTest()
        {
            var client = new HttpClient();
            var cnt = await client.GetStringAsync("http://localhost:36020/api/test/sleep/10000");
            return Content(cnt);
        }

        public ActionResult SyncTest()
        {
            var client = new HttpClient();
            var cnt = client.GetStringAsync("http://localhost:36020/api/test/sleep/10000").Result;
            return Content(cnt);
        }
























        public async Task<ActionResult> AsyncTest2()
        {
            await Task.Delay(10000);
            return Content("123");
        }

        public ActionResult SyncTest2()
        {
            Thread.Sleep(10000);
            return Content("123");
        }

        public ActionResult HighSpeed()
        {
            return Content("123");
        }
    }
}