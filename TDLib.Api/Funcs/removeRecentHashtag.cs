using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class removeRecentHashtag : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "removeRecentHashtag";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("hashtag")]
                public string hashtag_;

        }

    }

}