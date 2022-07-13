using Qurre;
using Qurre.API.Events;
using Qurre.Events;
using System;

namespace HitMarker
{
    public class HitMarker : Plugin
    {
        public override string Developer => "ohayo!#5601";
        public override string Name => "EasyHitMarker";
        public override Version Version => new Version(1, 0, 1);
        public override int Priority => int.MinValue;

        public static bool Enabled { get; internal set; }

        public override void Enable()
        {
            String PluginName = Config.GetString("hitmarker_plugin_name", "EasyHitMarker");
            String custmess = Config.GetString("hitmarker_hint_message", "-<color=#F51FDE>{damageamount}</color> HP");
            bool Enabled = Config.GetBool("hitmarker_enable", true);
            float hintduration = Config.GetFloat("hitmarker_hint_duration", 1);

            if (!Enabled) {
                Log.Error(" the hitmarker is disabled because you disabled it in the config");
                return;
            }

            Player.DamageProcess += OnDamageProcess;

            Log.Info(" hitmarker enabled!!! :)");
            Log.Info(" version: 1.0.1");
            Log.Info(" dev: ohayo!#5601");
        }

        public override void Disable()
        {
            Player.DamageProcess -= OnDamageProcess;

            Log.Info(" hitmarker disabled!!! :(");
            Log.Info(" version: 1.0.1");
            Log.Info(" dev: ohayo!#5601");
        }

        public static void OnDamageProcess(DamageProcessEvent ev)
        {
            Random r = new Random();

            String ns = "";

            int damageamount = (int)ev.Amount;

            float durationhint = Config.GetFloat("hitmarker_hint_duration", 1);

            String message = Config.GetString("hitmarker_hint_message", "-<color=#F51FDE>{damageamount}</color> HP").Replace("{damageamount}", $"{damageamount}");

            for (int i = 0; i < r.Next(4, 12); i++)
            {
                ns += "\n";
            }

            if (ev.Attacker.Team != Team.SCP)
            {
                ev.Attacker.ShowHint($"<pos={r.Next(-15, 30)}%>{message}{ns}", durationhint);
            }
        }
            
    }
}
