using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
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

        [HttpGet]
        [Route("~/api/GetCarByCarId")]
        public JsonResult GetCarByCarId(int carId)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                StringEscapeHandling = StringEscapeHandling.EscapeHtml
            };
            var result = _bal.GetCarDetails(carId);
            return new JsonResult { Data = JsonConvert.SerializeObject(result, settings), JsonRequestBehavior = JsonRequestBehavior.AllowGet }; ;
        }
    }
}
