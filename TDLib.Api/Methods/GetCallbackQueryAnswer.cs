using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetCallbackQueryAnswer : Method<CallbackQueryAnswer>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getCallbackQueryAnswer";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("message_id")]
        public long MessageId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("payload")]
        public CallbackQueryPayload Payload { get; set; }

    }

}
