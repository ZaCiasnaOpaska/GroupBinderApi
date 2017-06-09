using System.Collections.Generic;

namespace GroupBinderApi.Logic.Models
{
    public class LocationInfo
    {
        private static readonly IDictionary<string, string> PhoneToUserName = new Dictionary<string, string>
        {
            {"691608245", "Kuba"},
            {"531621685", "Conrat" }
        };

        public string Phone { get; }
        public string Name { get; }
        public double Lat { get; }
        public double Lng { get; }

        public LocationInfo(string phone, double lat, double lng)
        {
            Phone = phone;
            Lat = lat;
            Lng = lng;
            Name = PhoneToUserName[phone];
        }
    }
}