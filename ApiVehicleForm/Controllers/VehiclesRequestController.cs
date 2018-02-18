using ApiVehicleForm.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace ApiVehicleForm.Controllers
{
    public class VehiclesRequestController : ApiController
    {
        static readonly IVehicleRequestRepository repository = new VehicleRequestRepository();

        // POST /api/vehiclesrequest/{vehicle}
        public HttpResponseMessage Post(VehicleRequest item)
        {
            var obj = repository.ProcessVehicle(item);
            var response = new HttpResponseMessage(HttpStatusCode.Accepted);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

            return response;
        }
    }
}
