namespace GroupBinderApi.Logic.RequestModels
{
    public class SaveUserLocationRequestModel
    {
        public string Phone { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}