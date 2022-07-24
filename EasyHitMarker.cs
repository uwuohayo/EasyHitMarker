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
        public override Version Version => new Version(1, 0, 2);
        public override int Priority => int.MinValue;

        public override void Enable()
        {
            String hitmarker_plugin_name = Config.GetString("hitmarker_plugin_name", "EasyHitMarker");
            bool hitmarker_enable = Config.GetBool("hitmarker_enable", true);
            String hitmarker_hint_message = Config.GetString("hitmarker_hint_message", "-<color=#F51FDE>{damageamount}</color> HP");
            float hitmarker_hint_duration = Config.GetFloat("hitmarker_hint_duration", 1);
            int hitmarker_randShow1 = Config.GetInt("hitmarker_randShow1", -50);
            int hitmarker_randShow2 = Config.GetInt("hitmarker_randShow2", 50);


            if (hitmarker_enable == false) {
                Log.Error(" the hitmarker is disabled because you disabled it in the config");
                return;
            }

            Player.DamageProcess += OnDamageProcess;

            Log.Info(" hitmarker enabled!!! :)");
            Log.Info(" version: 1.0.2");
            Log.Info(" dev: ohayo!#5601");
        }

        public override void Disable()
        {
            Player.DamageProcess -= OnDamageProcess;

            Log.Info(" hitmarker disabled!!! :(");
            Log.Info(" version: 1.0.2");
            Log.Info(" dev: ohayo!#5601");
        }

        public static void OnDamageProcess(DamageProcessEvent ev)
        {
            Random r = new Random();
            int damageamount = (int)ev.Amount;

            float durationhint = Config.GetFloat("hitmarker_hint_duration", 1);
            int rand1 = Config.GetInt("hitmarker_randShow1", -50);
            int rand2 = Config.GetInt("hitmarker_randShow2", 50);
            String message = Config.GetString("hitmarker_hint_message", "-<color=#F51FDE>{damageamount}</color> HP").Replace("{damageamount}", $"{damageamount}");

            if (ev.Attacker.Team != Team.SCP)
            {
                if (ev.Attacker.Team != ev.Target.Team)
                {
                    ev.Attacker.ShowHint($"<pos={r.Next(rand1, rand2)}%>{message}", durationhint);
                }
            }
        }
            
    }
}
