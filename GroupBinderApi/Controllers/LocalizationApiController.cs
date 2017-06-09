using System.Collections.Generic;
using System.Web.Http;
using GroupBinderApi.Logic.Helpers;
using GroupBinderApi.Logic.Models;
using GroupBinderApi.Logic.Services;

namespace GroupBinderApi.Controllers
{
    public class LocalizationApiController : ApiController
    {
        private readonly LocalizationService _localizationService;

        public LocalizationApiController()
        {
            _localizationService = new LocalizationService();
        }
        
        [Route("api/localizations/getAll")]
        public IEnumerable<LocalizationInfo> GetAll()
        {
            var infos = _localizationService.GetAllLocalizations();

            return infos;
        }

        [HttpPost]
        public void SaveUserLocation(LocalizationInfo info)
        {
            AppContext.SaveUserLocation(info);
        }
    }
}
