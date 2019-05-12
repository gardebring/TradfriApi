﻿using Newtonsoft.Json;

namespace TradfriApi.Tradfri.Models
{
    public class TradfriAuth
    {
        [JsonProperty("9091")]
        public string PSK { get; set; }
        [JsonProperty("9029")]
        public string FirmwareVersion { get; set; }
    }
}
