using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class SetFileGenerationProgress : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "setFileGenerationProgress";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("generation_id")]
        public string GenerationId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("expected_size")]
        public int ExpectedSize { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("local_prefix_size")]
        public int LocalPrefixSize { get; set; }

    }

}
