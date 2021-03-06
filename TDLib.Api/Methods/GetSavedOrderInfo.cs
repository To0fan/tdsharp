using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class GetSavedOrderInfo : Method<OrderInfo>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "getSavedOrderInfo";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

    }

}
