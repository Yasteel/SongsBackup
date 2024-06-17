﻿namespace SongsBackup.Models.SpotifyModels
{
    using Newtonsoft.Json;

    public class Images
    {
        [JsonProperty("url")] 
        public string Url { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }
}