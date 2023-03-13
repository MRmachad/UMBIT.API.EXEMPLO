using Newtonsoft.Json;

namespace UMBIT.API.EXEMPLO.model
{
    public class Args
    {
    }

    public class Headers
    {
        public string Accept { get; set; }

        [JsonProperty("Accept-Encoding")]
        public string AcceptEncoding { get; set; }

        [JsonProperty("Accept-Language")]
        public string AcceptLanguage { get; set; }

        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }
        public string Host { get; set; }
        public string Origin { get; set; }
        public string Referer { get; set; }

        [JsonProperty("Sec-Ch-Ua")]
        public string SecChUa { get; set; }

        [JsonProperty("Sec-Ch-Ua-Mobile")]
        public string SecChUaMobile { get; set; }

        [JsonProperty("Sec-Ch-Ua-Platform")]
        public string SecChUaPlatform { get; set; }

        [JsonProperty("Sec-Fetch-Dest")]
        public string SecFetchDest { get; set; }

        [JsonProperty("Sec-Fetch-Mode")]
        public string SecFetchMode { get; set; }

        [JsonProperty("Sec-Fetch-Site")]
        public string SecFetchSite { get; set; }

        [JsonProperty("User-Agent")]
        public string UserAgent { get; set; }

        [JsonProperty("X-Amzn-Trace-Id")]
        public string XAmznTraceId { get; set; }
    }

    public class HTTPBIN
    {
        public Args args { get; set; }
        public Headers headers { get; set; }
        public string origin { get; set; }
        public string url { get; set; }
    }


}
