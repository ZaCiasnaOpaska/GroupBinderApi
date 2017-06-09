using System.Web;
using GroupBinderApi.Logic.Models;

namespace GroupBinderApi.Logic.Helpers
{
    public static class AppContext
    {
        private static GroupBinderContext Context => (GroupBinderContext) HttpContext.Current.Application["GroupBinderContext"];

        public static void SaveUserLocation(LocalizationInfo info)
        {
            Context.LocalizationInfos.RemoveAll(i => i.Phone == info.Phone);
            Context.LocalizationInfos.Add(info);
        }
    }
}