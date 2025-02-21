using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class images
{
    [JsonProperty("external")]
    public bool external { get; set; }

    [JsonProperty("src")]
    public string src { get; set; }

}

public class data
{
    [JsonProperty("imageCount")]
    public int imageCount { get; set; }

    [JsonProperty("images")]
    public images[] images { get; set; }

    [JsonProperty("maxLinksReached")]
    public bool maxLinksReached { get; set; }

    [JsonProperty("url")]
    public string url { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
