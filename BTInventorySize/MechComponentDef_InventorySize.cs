using BattleTech;
using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTInventorySize
{
    //[HarmonyPatch(typeof(MechComponentDef), "FromJSON")]
    class MechComponentDef_InventorySize
    {
        public static void Postfix(MechComponentDef __instance)
        {
            Traverse.Create(__instance).Property("InventorySize").SetValue(1);
        }
    }
}
