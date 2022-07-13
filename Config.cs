using System.ComponentModel;

namespace EasyHitMarker
{
    public class Config
    {
        [Description("plugin name")]
        public string hitmarker_plugin_name { get; set; } = "EasyHitMarker";
        [Description("enable hitmarker?")]
        public bool hitmarker_enable { get; set; } = true;
        [Description("customize the hitmarker :)")]
        public string hitmarker_hint_message { get; set; } = "-<color=#F51FDE>{damageamount}</color> HP";
        [Description("duration for 1 hint")]
        public float hitmarker_hint_duration { get; set; } = 1;
    }
}
