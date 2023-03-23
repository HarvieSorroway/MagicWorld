using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using BepInEx;

namespace MagicWorld
{
    [BepInPlugin("magicworld", "Magic World","1.0.0")]
    public class Plugins : BaseUnityPlugin
    {
        public readonly static string id = "magicworld";

        public static bool inited = false;

        public void OnEnable()
        {
            On.RainWorld.OnModsInit += RainWorld_OnModsInit;
        }

        private void RainWorld_OnModsInit(On.RainWorld.orig_OnModsInit orig, RainWorld self)
        {
            orig.Invoke(self);
            try
            {
                Init();
            }
            catch (Exception e)
            {
                Logger.LogError(e);
            }
        }

        public void Init()
        {

            inited = true;
        }
    }
}
