using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetChats : Method<Chats>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getChats";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("offset_order")]
        public string OffsetOrder { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("offset_chat_id")]
        public long OffsetChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("limit")]
        public int Limit { get; set; }

    }

}
