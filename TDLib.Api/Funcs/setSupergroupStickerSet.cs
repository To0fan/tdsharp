using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class setSupergroupStickerSet : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "setSupergroupStickerSet";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("supergroup_id")]
                public int? supergroup_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker_set_id")]
                public string sticker_set_id_;

        }

    }

}