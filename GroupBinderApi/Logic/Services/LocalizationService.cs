using System.Collections.Generic;
using GroupBinderApi.Logic.Models;

namespace GroupBinderApi.Logic.Services
{
    public class LocalizationService
    {
        public IEnumerable<LocalizationInfo> GetAllLocalizations()
        {
            var result = new List<LocalizationInfo>
            {
                new LocalizationInfo {Name = "KubaKuba", Lat = 54.3827261, Lng = 18.6239686},
                new LocalizationInfo {Name = "Conrat", Lat = 54.3738065, Lng = 18.6129093},
                new LocalizationInfo {Name = "Dawid", Lat = 54.3872492, Lng = 18.6096261}
            };

            return result;
        }
    }
}