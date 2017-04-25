using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Net.Chdk.Model.CameraModel
{
    public sealed class CameraModelInfo
    {
        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; }

        public string[] Names { get; set; }
    }
}
