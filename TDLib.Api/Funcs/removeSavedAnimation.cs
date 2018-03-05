using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class removeSavedAnimation : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "removeSavedAnimation";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("animation")]
                public InputFile animation_;

        }

    }

}