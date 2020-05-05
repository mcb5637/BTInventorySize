using BattleTech;
using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BTInventorySize
{
    class BTInventorySizeInit
    {
        public static void Init(string dir, string sett)
        {
            var harmony = HarmonyInstance.Create("com.github.mcb5637.BTInventorySize");
            //harmony.PatchAll(Assembly.GetExecutingAssembly());
            harmony.Patch(typeof(MechComponentDef).GetMethod("FromJSON"), null, new HarmonyMethod(typeof(MechComponentDef_InventorySize).GetMethod("Postfix")), null);
            harmony.Patch(typeof(AmmunitionBoxDef).GetMethod("FromJSON"), null, new HarmonyMethod(typeof(MechComponentDef_InventorySize).GetMethod("Postfix")), null);
            harmony.Patch(typeof(HeatSinkDef).GetMethod("FromJSON"), null, new HarmonyMethod(typeof(MechComponentDef_InventorySize).GetMethod("Postfix")), null);
            harmony.Patch(typeof(JumpJetDef).GetMethod("FromJSON"), null, new HarmonyMethod(typeof(MechComponentDef_InventorySize).GetMethod("Postfix")), null);
            harmony.Patch(typeof(SpecialComponentDef).GetMethod("FromJSON"), null, new HarmonyMethod(typeof(MechComponentDef_InventorySize).GetMethod("Postfix")), null);
            harmony.Patch(typeof(StatUpgradeDef).GetMethod("FromJSON"), null, new HarmonyMethod(typeof(MechComponentDef_InventorySize).GetMethod("Postfix")), null);
            harmony.Patch(typeof(UpgradeDef).GetMethod("FromJSON"), null, new HarmonyMethod(typeof(MechComponentDef_InventorySize).GetMethod("Postfix")), null);
            harmony.Patch(typeof(WeaponDef).GetMethod("FromJSON"), null, new HarmonyMethod(typeof(MechComponentDef_InventorySize).GetMethod("Postfix")), null);
        }
    }
}
