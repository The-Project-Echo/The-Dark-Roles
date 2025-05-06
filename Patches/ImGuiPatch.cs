using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using TheDarkRoles.Modules;
using UnityEngine;

namespace TheDarkRoles.Patches
{
    [HarmonyPatch(typeof(AmongUsClient), nameof(AmongUsClient.Awake))]
    public class ImGuiPatch
    {
        public static void Postfix()
        {
            try
            {
                ClassInjector.RegisterTypeInIl2Cpp<HostFunctions>();

                var obj = new GameObject("HostFunctions_SafeLoader");
                obj.AddComponent<HostFunctions>();
                GameObject.DontDestroyOnLoad(obj);
            }
            catch (Exception e)
            {
                TheDarkRoles.Logger.Error($"Loader failed: {e}", "HostFunctions");
            }
        }
    }
}
