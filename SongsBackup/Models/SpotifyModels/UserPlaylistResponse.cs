﻿namespace SongsBackup.Models.SpotifyModels
{
    using Newtonsoft.Json;

    public class UserPlaylistResponse
    {
        [JsonProperty("href")] public string Href { get; set; }

        [JsonProperty("limit")] public int Limit { get; set; }

        [JsonProperty("next")] public object Next { get; set; }

        [JsonProperty("offset")] public int Offset { get; set; }

        [JsonProperty("previous")] public object Previous { get; set; }

        [JsonProperty("total")] public int Total { get; set; }

        [JsonProperty("items")] public Items[] Items { get; set; }
    }
}




