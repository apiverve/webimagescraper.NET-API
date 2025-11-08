using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Images data
    /// </summary>
    public class Images
    {
        [JsonProperty("external")]
        public bool External { get; set; }

        [JsonProperty("src")]
        public string Src { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("imageCount")]
        public int ImageCount { get; set; }

        [JsonProperty("images")]
        public Images[] Images { get; set; }

        [JsonProperty("maxLinksReached")]
        public bool MaxLinksReached { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
