using System.Collections.Generic;

namespace GroupBinderApi.Logic.Models
{
    public class GroupBinderContext
    {
        public List<LocationInfo> LocalizationInfos { get; } = new List<LocationInfo>();
        public List<string> LostPeopleNumbers { get; } = new List<string>();
    }
}