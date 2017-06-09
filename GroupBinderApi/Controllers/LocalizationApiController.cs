using System.Collections.Generic;
using System.Web.Http;
using GroupBinderApi.Logic;
using GroupBinderApi.Logic.Models;
using GroupBinderApi.Logic.RequestModels;

namespace GroupBinderApi.Controllers
{
    public class LocalizationApiController : ApiController
    {
        [Route("api/localization/getAll")]
        public IEnumerable<LocationInfo> GetAll()
        {
            return AppContext.GetAllUsers();
        }

        [HttpPost]
        [Route("api/localization/saveUserLocation")]
        public void SaveUserLocation(SaveUserLocationRequestModel request)
        {
            AppContext.SaveUserLocation(request.Phone, request.Lat, request.Lng);
        }

        [Route("api/localization/lostPeople")]
        public IEnumerable<LocationInfo> GetLostPeople()
        {
            return AppContext.GetLostPeople();
        }

        [HttpPost]
        [Route("api/localization/imLost")]
        public void ImLost(ImLostRequestModel request)
        {
            AppContext.AddLostUser(request.Phone);
        }
    }
}
