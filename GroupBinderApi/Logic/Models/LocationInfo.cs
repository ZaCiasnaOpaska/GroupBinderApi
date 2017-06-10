using System.Collections.Generic;

namespace GroupBinderApi.Logic.Models
{
    public class LocationInfo
    {
        private static readonly IDictionary<string, string> PhoneToUserName = new Dictionary<string, string>
        {
            {"691608245", "Kuba"},
            {"531621685", "Conrat"},
            {"123123123", "Conrad"},
            {"456456456", "Konrad"},
            {"789789789", "Konradt"},
            {"111111111", "Czarek"},
            {"222222222", "Dawid"},
            {"333333333", "Dennis"}
        };

        public string Phone { get; }
        public string Name { get; }
        public double Lat { get; }
        public double Lng { get; }
        public bool IsLost { get; set; }
        public bool IsDistant { get; set; }

        public LocationInfo(string phone, double lat, double lng)
        {
            Phone = phone;
            Lat = lat;
            Lng = lng;
            Name = PhoneToUserName[phone];
        }
    }
}