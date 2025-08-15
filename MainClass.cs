using System;
using System.IO;
using UnityEngine;
using HarmonyLib;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Configuration;
using System.Collections;
using System.Collections.Generic;
using ComputerysModdingUtilities;
using TMPro;
using HeathenEngineering.DEMO;
using HeathenEngineering.SteamworksIntegration;

[assembly: StraftatMod(isVanillaCompatible: true)] // CLIENT version, Party Pooper...
namespace STRAFTATMod
{
    [BepInPlugin("dimolade.dimolade.InfTaunt", "Infinite Taunt", "1.0.0.0")]
    public class Loader : BaseUnityPlugin
    {
        private void Awake()
        {
            /* Initialize Harmony */
            var harmony = new Harmony("dimolade.harmony.InfTaunt");
            harmony.PatchAll();
        }
    }
    [HarmonyPatch(typeof(FirstPersonController), "HandleTaunt")]
    class TauntPatch
    {
        static bool Prefix(FirstPersonController __instance)
        {
            __instance.tauntTimer -= Time.deltaTime;
            if (__instance.tauntTimer > 0f)
            {
                int count = 10;
                for (int i = 0; i < count; i++)
                {
                    string thisKey = "Alpha" + ((i + 1) % count);
                    if (Input.GetKeyDown(thisKey))
                    {
                        __instance.audio.PlayOneShot(__instance.tauntClip[i]);
                    }
                }
                return false;
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                __instance.AboubiPlayServer(0);
                Settings.Instance.IncreaseTauntsAmount();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                __instance.AboubiPlayServer(1);
                Settings.Instance.IncreaseTauntsAmount();
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                __instance.AboubiPlayServer(2);
                Settings.Instance.IncreaseTauntsAmount();
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                __instance.AboubiPlayServer(3);
                Settings.Instance.IncreaseTauntsAmount();
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                __instance.AboubiPlayServer(4);
                Settings.Instance.IncreaseTauntsAmount();
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                __instance.AboubiPlayServer(5);
                Settings.Instance.IncreaseTauntsAmount();
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                __instance.AboubiPlayServer(6);
                Settings.Instance.IncreaseTauntsAmount();
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                __instance.AboubiPlayServer(7);
                Settings.Instance.IncreaseTauntsAmount();
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                __instance.AboubiPlayServer(8);
                Settings.Instance.IncreaseTauntsAmount();
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                __instance.AboubiPlayServer(9);
                Settings.Instance.IncreaseTauntsAmount();
            }
            return false;
        }
    }
}