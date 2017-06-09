using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupBinderApi.Logic.Models;

namespace GroupBinderApi.Logic
{
    public static class AppContext
    {
        private static GroupBinderContext Context => (GroupBinderContext) HttpContext.Current.Application["GroupBinderContext"];

        public static IEnumerable<LocationInfo> GetAllUsers()
        {
            return Context.LocalizationInfos;
        }

        public static void SaveUserLocation(string phone, double lat, double lng)
        {
            var info = new LocationInfo(phone, lat, lng);
            Context.LocalizationInfos.RemoveAll(x => x.Phone == phone);
            Context.LocalizationInfos.Add(info);
        }

        public static void AddLostUser(string phone)
        {
            var info = Context.LocalizationInfos.First(x => x.Phone == phone);
            info.IsLost = true;
        }
    }
}