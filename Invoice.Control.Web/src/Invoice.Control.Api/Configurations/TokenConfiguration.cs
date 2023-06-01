namespace Invoice.Control.Api.Configurations
{
    public class TokenConfiguration
    {
        public string Secret { get; set; }
        public int ExpirationInHours { get; set; }
        public string Issuer { get; set; }
        public string ValidAt { get; set; }
    }
}
