using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TMeUrlType : Structure
    {

        public class TMeUrlTypeStickerSet : TMeUrlType
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "tMeUrlTypeStickerSet";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker_set_id")]
                public string StickerSetId { get; set; }

        }

    }

}
