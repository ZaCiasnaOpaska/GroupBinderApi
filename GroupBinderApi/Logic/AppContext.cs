using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Web;
using GroupBinderApi.Logic.Models;

namespace GroupBinderApi.Logic
{
    public static class AppContext
    {
        private const int DistanceWhenUserShouldBeAlarmed = 75;

        private static GroupBinderContext Context => (GroupBinderContext) HttpContext.Current.Application["GroupBinderContext"];

        public static IEnumerable<LocationInfo> GetAllUsers()
        {
            var infos = Context.LocalizationInfos;
            var user = infos.First(x => x.Phone == "531621685");

            if (user.Lat < 54.3746065)
            {
                user.Lat += 0.0001;
                CheckIfDistant(user);
            }
            return infos;
        }

        public static void SaveUserLocation(string phone, double lat, double lng)
        {
            var info = new LocationInfo(phone, lat, lng);
            
            CheckIfDistant(info);

            Context.LocalizationInfos.RemoveAll(x => x.Phone == phone);
            Context.LocalizationInfos.Add(info);
        }

        private static void CheckIfDistant(LocationInfo info)
        {
            var geoCoords = new GeoCoordinate(info.Lat, info.Lng);
            var distantFromHowManyUsers = Context.LocalizationInfos
                .Where(x => x.Phone != info.Phone)
                .Select(x => new GeoCoordinate(x.Lat, x.Lng))
                .Count(x => x.GetDistanceTo(geoCoords) > DistanceWhenUserShouldBeAlarmed);
            if (distantFromHowManyUsers > 0.75 * Context.LocalizationInfos.Count)
            {
                info.IsDistant = true;
            }
        }

        public static void AddLostUser(string phone)
        {
            var info = Context.LocalizationInfos.First(x => x.Phone == phone);
            info.IsLost = true;
        }

        public static void InitializeWithFakeUsers()
        {
            Context.LocalizationInfos.Add(new LocationInfo("531621685", 54.3738065, 18.6129093));
            Context.LocalizationInfos.Add(new LocationInfo("123123123", 54.3733065, 18.6129093));
            Context.LocalizationInfos.Add(new LocationInfo("456456456", 54.3738065, 18.6126093));
            Context.LocalizationInfos.Add(new LocationInfo("789789789", 54.3738065, 18.6124093));
            Context.LocalizationInfos.Add(new LocationInfo("111111111", 54.3738065, 18.6132093));
            Context.LocalizationInfos.Add(new LocationInfo("222222222", 54.3736065, 18.6127093));
            Context.LocalizationInfos.Add(new LocationInfo("333333333", 54.3735065, 18.6128093));
        }
    }
}