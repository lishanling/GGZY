namespace GGZY.Services.Infrastructure.Model
{
    public class UnifyUserAppAuth
    {
        public string Id { get; set; }

        public string AppKey { get; set; }
        public string Name { get; set; }
        public string UserGuid { get; set; }
        public string Icon { get; set; }
        public decimal? Sort { get; set; }
        public string AppUid { get; set; }
        public string AppType { get; set; }
    }
}