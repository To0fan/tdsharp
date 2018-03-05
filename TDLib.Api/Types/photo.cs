using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Photo : Structure
    {

        public partial class photo : Photo
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "photo";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("has_stickers")]
                public bool? has_stickers_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sizes")]
                public PhotoSize.photoSize[] sizes_;

        }

    }

}