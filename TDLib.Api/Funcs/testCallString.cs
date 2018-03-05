using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class testCallString : Method<TestString>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "testCallString";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("x")]
                public string x_;

        }

    }

}