namespace MoreIngots.Items
{
    using System.Collections.Generic;
    using SMLHelper.V2.Crafting;
    using SMLHelper.V2.Handlers;
    using UnityEngine;
    
    using QModManager.API.ModLoading;

    [QModCore]
    public class Qpatch
    {
        [QModPatch]
        public static void Patch()
        {
            var MIGold = TechTypeHandler.AddTechType("MIGold", "Gold Ingot", "Au. Compressed gold. Added by the MoreIngots mod");
            var techDataG = new TechData();
            var MIDiamond = TechTypeHandler.AddTechType("MIDiamond", "Compressed Diamond", "C. Compressed diamond. Added by the MoreIngots mod");
            var techDataD = new TechData();
            var MILithium = TechTypeHandler.AddTechType("MILithium", "Lithium Ingot", "Li. Compressed lithium. Added by the MoreIngots mod");
            var techDataL = new TechData();
            var MICopper = TechTypeHandler.AddTechType("MICopper", "Copper Ingot", "Cu. Compressed copper. Added by the MoreIngots mod");
            var techDataC = new TechData();
            var MILead = TechTypeHandler.AddTechType("MILead", "Lead Ingot", "Pb. Compressed lead. Added by the MoreIngots mod");
            var techDataLi = new TechData();
            var MISilver = TechTypeHandler.AddTechType("MISilver", "Silver Ingot", "Ag. Compressed silver. Added by the MoreIngots mod");
            var techDataSi = new TechData();
            var MIMagnetite = TechTypeHandler.AddTechType("MIMagnetite", "Compressed Magnetite", "Fe3O4. Compressed magnetite. Added by the MoreIngots mod");
            var techDataM = new TechData();
            var MINickel = TechTypeHandler.AddTechType("MINickel", "Nickel Ingot", "Ni. Compressed nickel. Added by the MoreIngots mod");
            var techDataN = new TechData();
            var MIKyanite = TechTypeHandler.AddTechType("MIKyanite", "Compressed Kyanite", "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod");
            var techDataK = new TechData();
            var MIRuby = TechTypeHandler.AddTechType("MIRuby", "Compressed Ruby", "Al2O3. Compressed ruby. Added by the MoreIngots mod");
            var techDataR = new TechData();
            var MIUraninite = TechTypeHandler.AddTechType("MIUraninite", "Compressed Uraninite", "U3O8. Compressed uraninite. Added by the MoreIngots mod");
            var techDataU = new TechData();
            var MIQuartz = TechTypeHandler.AddTechType("MIQuartz", "Compressed Quartz", "SiO4. Compressed quartz. Added by the MoreIngots mod");
            var techDataQ = new TechData();
            var MISalt = TechTypeHandler.AddTechType("MISalt", "Salt Lick", "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)");
            var techDataS = new TechData();
            var MISulphur = TechTypeHandler.AddTechType("MISulphur", "Compressed Sulphur", "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)");
            var techDataSu = new TechData();
            var SITitanim = TechTypeHandler.AddTechType("SITitanim", "Stacked Titanium", "SAu. Stacked Titanium. Added by the MoreIngotsplus mod. (Suggested by Cookie)");
            var techDataST = new TechData();
            techDataG = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Gold, 1)
        
    }
            };
            CraftDataHandler.SetTechData(MIGold, techDataG);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIGold, "Resources", "Electronics");
            techDataD = new TechData()
            {
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
    {
        new Ingredient(TechType.Diamond, 1)

    }
            };
            CraftDataHandler.SetTechData(MIDiamond, techDataD);
            CraftTreeHandler.AddCraftingNode(CraftTree.Type.Fabricator, MIDiamond, "Resources", "Electronics");

        }
    }
}