using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Wallpaper : Structure
    {

        public partial class wallpaper : Wallpaper
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "wallpaper";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public int? id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sizes")]
                public PhotoSize.photoSize[] sizes_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("color")]
                public int? color_;

        }

    }

}