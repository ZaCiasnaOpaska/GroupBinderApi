using System.Collections.Generic;
using System.Web.Http;
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

        public IEnumerable<LocalizationInfo> GetAll()
        {
            var infos = _localizationService.GetAllLocalizations();

            return infos;
        }
    }
}
