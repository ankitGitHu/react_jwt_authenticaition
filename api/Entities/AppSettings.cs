namespace api.Entities
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }

        public int Expiry { get; set; }
    }
}