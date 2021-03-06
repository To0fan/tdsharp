using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatMemberStatus : Structure
    {

        public class ChatMemberStatusCreator : ChatMemberStatus
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatMemberStatusCreator";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_member")]
                public bool IsMember { get; set; }

        }

    }

}
