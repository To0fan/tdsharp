using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetWallpapers : Method<Wallpapers>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getWallpapers";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}
