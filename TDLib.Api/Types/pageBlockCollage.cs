using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class PageBlock : Structure
    {

        public class PageBlockCollage : PageBlock
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockCollage";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("page_blocks")]
                public PageBlock[] PageBlocks { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public RichText Caption { get; set; }

        }

    }

}
