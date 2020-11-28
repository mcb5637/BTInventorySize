using BattleTech;
using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly:AssemblyVersion("1.0.1.0")]

namespace BTInventorySize
{
    class BTInventorySizeInit
    {
        public static void Init(string dir, string sett)
        {
            HarmonyInstance harmony = HarmonyInstance.Create("com.github.mcb5637.BTInventorySize");
            //harmony.PatchAll(Assembly.GetExecutingAssembly());
            HarmonyMethod postfix = new HarmonyMethod(typeof(MechComponentDef_InventorySize).GetMethod("Postfix"));
            postfix.after = new string[] { "MechEngineer.Features.AutoFix", "io.mission.modrepuation" };
            harmony.Patch(typeof(MechComponentDef).GetMethod("FromJSON"), null, postfix, null);
            harmony.Patch(typeof(AmmunitionBoxDef).GetMethod("FromJSON"), null, postfix, null);
            harmony.Patch(typeof(HeatSinkDef).GetMethod("FromJSON"), null, postfix, null);
            harmony.Patch(typeof(JumpJetDef).GetMethod("FromJSON"), null, postfix, null);
            harmony.Patch(typeof(SpecialComponentDef).GetMethod("FromJSON"), null, postfix, null);
            harmony.Patch(typeof(StatUpgradeDef).GetMethod("FromJSON"), null, postfix, null);
            harmony.Patch(typeof(UpgradeDef).GetMethod("FromJSON"), null, postfix, null);
            harmony.Patch(typeof(WeaponDef).GetMethod("FromJSON"), null, postfix, null);
        }
    }
}
