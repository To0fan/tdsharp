using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class setUsername : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "setUsername";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("username")]
                public string username_;

        }

    }

}