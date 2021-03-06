using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class CreateBasicGroupChat : Method<Chat>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "createBasicGroupChat";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("basic_group_id")]
        public int BasicGroupId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("force")]
        public bool Force { get; set; }

    }

}
