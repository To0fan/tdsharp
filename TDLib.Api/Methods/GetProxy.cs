using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetProxy : Method<Proxy>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getProxy";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}
