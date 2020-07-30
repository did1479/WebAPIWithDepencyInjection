using System;
using System.Web.Http;
using System.Web.Mvc;
using WebAPIWithDependencyInjection.BusinessAccess.interfaces;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace WebAPIWithDependencyInjection.Controllers
{
    [Route("api/Car")]
    [RequireHttps]
    public class CarController : ApiController
    {
        public IBusinessAccessLayer _bal;

        public CarController(IBusinessAccessLayer _balObj)
        {
            _bal = _balObj;
        }

        /// <summary>
        ///     Simple "Hello World" method to ensure service is up.
        /// </summary>
        /// <returns>The literal "Hello World".</returns>
        [HttpGet]
        [Route("~/api/HelloWorld")]
        public string HelloWorld() => $"Hello World - Eci Trace Manager Service on '{Environment.MachineName}'  (.Net Version = {Environment.Version}) responding.";

        // GET api/Car
        [HttpGet]
        public JsonResult GetCarByCarId(int carId)
        {
            return new JsonResult { Data = _bal.GetCarDetails(carId) };
        }
    }
}
