using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class SearchMessagesFilter : Structure
    {

        public class SearchMessagesFilterPhoto : SearchMessagesFilter
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "searchMessagesFilterPhoto";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
