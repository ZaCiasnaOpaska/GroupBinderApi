using System.Collections.Generic;

namespace GroupBinderApi.Logic.Models
{
    public class GroupBinderContext
    {
        public List<LocationInfo> LocalizationInfos { get; } = new List<LocationInfo>();
    }
}