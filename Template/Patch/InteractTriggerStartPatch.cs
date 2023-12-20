using HarmonyLib;
using UnityEngine;

namespace Template.Patch {

    [HarmonyPatch(typeof(StartOfRound))]
    [HarmonyPatch("Start")]
    class StartOfRoundStartPatch {
        public static void Postfix(InteractTrigger __instance) {
            try {
                Plugin.Instance.PluginLogger.LogInfo("StartOfRound.Start() was just called!");

                #if DEBUG
                Plugin.Instance.PluginLogger.LogInfo("This is a debug build!");
                #endif

                if (Plugin.Instance.PluginConfig.GetCustomConfigValue()) {
                    Plugin.Instance.PluginLogger.LogInfo("CustomConfigValue is true!");
                } else {
                    Plugin.Instance.PluginLogger.LogInfo("CustomConfigValue is false!");
                }
            }
            catch (System.Exception e)
            {
                Plugin.Instance.PluginLogger.LogError("Error in StartOfRoundStartPatch.Postfix: " + e);
                Plugin.Instance.PluginLogger.LogError(e.StackTrace);
            }
        }
    }
}