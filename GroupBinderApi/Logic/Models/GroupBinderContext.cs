using System.Collections.Generic;

namespace GroupBinderApi.Logic.Models
{
    public class GroupBinderContext
    {
        public List<LocalizationInfo> LocalizationInfos { get; set; } = new List<LocalizationInfo>();
    }
}