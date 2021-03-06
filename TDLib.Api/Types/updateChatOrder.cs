using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public class UpdateChatOrder : Update
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateChatOrder";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("order")]
                public string Order { get; set; }

        }

    }

}
