using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputFile : Structure
    {

        public class InputFileGenerated : InputFile
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputFileGenerated";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("original_path")]
                public string OriginalPath { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("conversion")]
                public string Conversion { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("expected_size")]
                public int ExpectedSize { get; set; }

        }

    }

}
