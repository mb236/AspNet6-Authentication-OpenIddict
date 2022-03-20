using System.Text.Json.Serialization;

namespace identity_angular.Models
{
    public class OidcConfiguration
    {
        [JsonPropertyName("authority")]
        public string Authority { get; set; }

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonPropertyName("post_logout_redirect_uri")]
        public string PostLogoutRedirectUri { get; set; }

        [JsonPropertyName("response_type")]
        public string ResponseType { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("monitor_session")]
        public bool MonitorSession { get; set; }
    }
}
