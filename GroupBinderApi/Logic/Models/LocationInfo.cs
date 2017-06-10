using System.Collections.Generic;

namespace GroupBinderApi.Logic.Models
{
    public class LocationInfo
    {
        private static readonly IDictionary<string, string> PhoneToUserName = new Dictionary<string, string>
        {
            {"691608245", "Kuba"},
            {"531621685", "Konrad"},
            {"123123123", "Dawid"},
            {"456456456", "Adam"},
            {"789789789", "Ewelina"},
            {"111111111", "Patrycja"},
            {"222222222", "Ela"},
            {"333333333", "Dennis"}
        };

        public string Phone { get; }
        public string Name { get; }
        public double Lat { get; set; }
        public double Lng { get; set; }
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