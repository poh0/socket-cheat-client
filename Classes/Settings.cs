using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBase.Classes
{
    public class Settings
    {
        [JsonProperty("bhop")]
        public bool BunnyhopEnabled { get; set; }

        [JsonProperty("esp")]
        public bool ESP { get; set; }

        [JsonProperty("box_esp")]
        public bool box_esp { get; set; }

        [JsonProperty("healthbar_esp")]
        public bool healthbar_esp { get; set; }

        [JsonProperty("snaplines")]
        public bool snaplines { get; set; }

        [JsonProperty("fov_value")]
        public int fov { get; set; }
    }
}
