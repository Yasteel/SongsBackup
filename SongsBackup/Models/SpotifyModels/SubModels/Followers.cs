﻿namespace SongsBackup.Models.SpotifyModels
{
    using Newtonsoft.Json;
    public class Followers
    {
        [JsonProperty("href")] public object Href { get; set; }

        [JsonProperty("total")] public int Total { get; set; }
    }
}