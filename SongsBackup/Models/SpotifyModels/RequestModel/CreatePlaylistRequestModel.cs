using Newtonsoft.Json;

namespace SongsBackup.Models.SpotifyModels.RequestModel
{
    public class CreatePlaylistRequestModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

    }
}

