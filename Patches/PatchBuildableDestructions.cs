﻿using HarmonyLib;
using JetBrains.Annotations;
using Pustalorc.Plugins.BaseClustering.API.Delegates;
using SDG.Unturned;

namespace Pustalorc.Plugins.BaseClustering.Patches
{
    [HarmonyPatch]
    public static class PatchBuildablesDestroy
    {
        public static event BuildableDestroyed OnBuildableDestroyed;

        [HarmonyPatch(typeof(BarricadeManager), "destroyBarricade")]
        [HarmonyPrefix]
        [UsedImplicitly]
        private static void DestroyBarricade([NotNull] BarricadeRegion region, ushort index)
        {
            ThreadUtil.assertIsGameThread();

            OnBuildableDestroyed?.Invoke(region.drops[index].model);
        }

        [HarmonyPatch(typeof(StructureManager), "destroyStructure")]
        [HarmonyPrefix]
        [UsedImplicitly]
        private static void DestroyStructure([NotNull] StructureRegion region, ushort index)
        {
            ThreadUtil.assertIsGameThread();

            OnBuildableDestroyed?.Invoke(region.drops[index].model);
        }
    }
}