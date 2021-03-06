using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class DeleteProfilePhoto : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "deleteProfilePhoto";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("profile_photo_id")]
        public string ProfilePhotoId { get; set; }

    }

}
