using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class PageBlock : Structure
    {

        public class PageBlockEmbeddedPost : PageBlock
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockEmbeddedPost";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("url")]
                public string Url { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("author")]
                public string Author { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("author_photo")]
                public Photo AuthorPhoto { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("date")]
                public int Date { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("page_blocks")]
                public PageBlock[] PageBlocks { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public RichText Caption { get; set; }

        }

    }

}
