using MoreIngots.Data;
using MoreIngots.Utilities;

namespace MoreIngots
{
    using System;
    using System.Reflection;
    using SMLHelper.V2.Handlers;
    using QModManager.API.ModLoading;

    [QModCore]
    public class Qpatch
    {
        [QModPatch]
        public static void Patch()
        {

            var version = QuickLogger.GetAssemblyVersion(Assembly.GetExecutingAssembly());
            QuickLogger.Info($"Started patching. Version: {version}");


#if DEBUG
            QuickLogger.DebugLogsEnabled = true;
            QuickLogger.Debug("Debug logs enabled");
#endif
            try
            {
                //Lets create the fabricator entry
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Craft", "Pack", SpriteManager.Get(TechType.TitaniumIngot));


                //Lets create and add the resources to the fabricator
                MIResources.CreateResources();
            }
            catch (Exception e)
            {
                QuickLogger.Error(e);
            }




            //var MIGold = TechTypeHandler.AddTechType("MIGold", "Gold Ingot",
            //    "Au. Compressed gold. Added by the MoreIngots mod", GetSprite("MIGold"));
            //var techDataG = new TechData();
            //var MIDiamond = TechTypeHandler.AddTechType("MIDiamond", "Compressed Diamond",
            //    "C. Compressed diamond. Added by the MoreIngots mod", GetSprite("MIDiamond"));
            //var techDataD = new TechData();
            //var MILithium = TechTypeHandler.AddTechType("MILithium", "Lithium Ingot",
            //    "Li. Compressed lithium. Added by the MoreIngots mod", GetSprite("MILithum"));
            //var techDataL = new TechData();
            //var MICopper = TechTypeHandler.AddTechType("MICopper", "Copper Ingot",
            //    "Cu. Compressed copper. Added by the MoreIngots mod", GetSprite("MICopper"));
            //var techDataC = new TechData();
            //var MILead = TechTypeHandler.AddTechType("MILead", "Lead Ingot",
            //    "Pb. Compressed lead. Added by the MoreIngots mod", GetSprite("MILead"));
            //var techDataLi = new TechData();
            //var MISilver = TechTypeHandler.AddTechType("MISilver", "Silver Ingot",
            //    "Ag. Compressed silver. Added by the MoreIngots mod", GetSprite("MISilver"));
            //var techDataSi = new TechData();
            //var MIMagnetite = TechTypeHandler.AddTechType("MIMagnetite", "Compressed Magnetite",
            //    "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", GetSprite("MIMagnetite"));
            //var techDataM = new TechData();
            //var MINickel = TechTypeHandler.AddTechType("MINickel", "Nickel Ingot",
            //    "Ni. Compressed nickel. Added by the MoreIngots mod", GetSprite("MINickel"));
            //var techDataN = new TechData();
            //var MIKyanite = TechTypeHandler.AddTechType("MIKyanite", "Compressed Kyanite",
            //    "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", GetSprite("MIKyanite"));
            //var techDataK = new TechData();
            //var MIRuby = TechTypeHandler.AddTechType("MIRuby", "Compressed Ruby",
            //    "Al2O3. Compressed ruby. Added by the MoreIngots mod", GetSprite("MIRuby"));
            //var techDataR = new TechData();
            //var MIUraninite = TechTypeHandler.AddTechType("MIUraninite", "Compressed Uraninite",
            //    "U3O8. Compressed uraninite. Added by the MoreIngots mod", GetSprite("MIUrninite"));
            //var techDataU = new TechData();
            //var MIIon = TechTypeHandler.AddTechType("MIIon", "Ion Ingot ",
            //    "I48. Compressed Ion Cubes. Added by the MoreIngots mod", GetSprite("MIIon"));
            //var techDataI = new TechData();
            //var MIQuartz = TechTypeHandler.AddTechType("MIQuartz", "Compressed Quartz",
            //    "SiO4. Compressed quartz. Added by the MoreIngots mod", GetSprite("MIQuartz"));
            //var techDataQ = new TechData();
            //var MISalt = TechTypeHandler.AddTechType("MISalt", "Salt Lick",
            //    "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", GetSprite("MISalt"));
            //var techDataS = new TechData();
            //var MISulphur = TechTypeHandler.AddTechType("MISulphur", "Compressed Sulphur",
            //    "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISulphur"));
            //var techDataSu = new TechData();
            //var MICrash = TechTypeHandler.AddTechType("MISCrash", "Compressed Crashpowder",
            //    "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MICrash"));
            //var techDataCa = new TechData();
            //var PIGold = TechTypeHandler.AddTechType("PIGold", "Unpacked Gold Ingot",
            //    "Au. Compressed gold. Added by the MoreIngots mod", GetSprite("MIGold"));
            //var techDataPg = new TechData();
            //var PIDiamond = TechTypeHandler.AddTechType("PIDiamond", "Unpacked Compressed Diamond",
            //    "C. Compressed diamond. Added by the MoreIngots mod", GetSprite("MIDiamond"));
            //var techDataDp = new TechData();
            //var PILithium = TechTypeHandler.AddTechType("PILithium", "Unpacked Lithium Ingot",
            //    "Li. Compressed lithium. Added by the MoreIngots mod", GetSprite("MILithum"));
            //var techDataLp = new TechData();
            //var PICopper = TechTypeHandler.AddTechType("PICopper", "Unpacked Copper Ingot",
            //    "Cu. Compressed copper. Added by the MoreIngots mod", GetSprite("MICopper"));
            //var techDataCP = new TechData();
            //var PILead = TechTypeHandler.AddTechType("PILead", "Unpacked Lead Ingot",
            //    "Pb. Compressed lead. Added by the MoreIngots mod", GetSprite("MILead"));
            //var techDataLip = new TechData();
            //var PISilver = TechTypeHandler.AddTechType("PISilver", "Unpacked Silver Ingot",
            //    "Ag. Compressed silver. Added by the MoreIngots mod", GetSprite("MISilver"));
            //var techDataSip = new TechData();
            //var PIMagnetite = TechTypeHandler.AddTechType("PIMagnetite", "Unpacked Compressed Magnetite",
            //    "Fe3O4. Compressed magnetite. Added by the MoreIngots mod", GetSprite("MIMagnetite"));
            //var techDataMp = new TechData();
            //var PINickel = TechTypeHandler.AddTechType("PINickel", "Unpacked Nickel Ingot",
            //    "Ni. Compressed nickel. Added by the MoreIngots mod", GetSprite("MINickel"));
            //var techDataNp = new TechData();
            //var PIKyanite = TechTypeHandler.AddTechType("PIKyanite", "Unpacked Compressed Kyanite",
            //    "Al2SiO5. Compressed kyanite. Added by the MoreIngots mod", GetSprite("MIKyanite"));
            //var techDataKp = new TechData();
            //var PIRuby = TechTypeHandler.AddTechType("PIRuby", "Unpacked Compressed Ruby",
            //    "Al2O3. Compressed ruby. Added by the MoreIngots mod", GetSprite("MIRuby"));
            //var techDataRp = new TechData();
            //var PIUraninite = TechTypeHandler.AddTechType("PIUraninite", "Unpacked Compressed Uraninite",
            //    "U3O8. Compressed uraninite. Added by the MoreIngots mod", GetSprite("MIUrninite"));
            //var techDataUp = new TechData();
            //var PIIon = TechTypeHandler.AddTechType("PIIon", "Unpacked Ion Ingot ",
            //    "I48. Compressed Ion Cubes. Added by the MoreIngots mod", GetSprite("MIIon"));
            //var techDataIp = new TechData();
            //var PIQuartz = TechTypeHandler.AddTechType("PIQuartz", "Unpacked Compressed Quartz",
            //    "SiO4. Compressed quartz. Added by the MoreIngots mod", GetSprite("MIQuartz"));
            //var techDataQp = new TechData();
            //var PISalt = TechTypeHandler.AddTechType("PISalt", "Unpacked Salt Lick",
            //    "NaCl. Salt. Added by the MoreIngots mod. (Suggested by Oddwood)", GetSprite("MISalt"));
            //var techDataSp = new TechData();
            //var PISulphur = TechTypeHandler.AddTechType("PISulphur", "Unpacked Compressed Sulphur",
            //    "S. Compressed Sulphur. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MISulphur"));
            //var techDataSup = new TechData();
            //var PICrash = TechTypeHandler.AddTechType("PISCrash", "Unpacked Compressed Crashpowder",
            //    "S. Compressed Crashpowder. Added by the MoreIngots mod. (Suggested by gnivler)", GetSprite("MICrash"));
            //var techDataCap = new TechData();
            //var SITitanim = TechTypeHandler.AddTechType("SITitanim", "Stacked Titanium",
            //    "SAu. Stacked Titanium. Added by the MoreIngotsplus mod. (Suggested by Cookie)",
            //    GetSprite("SITitanim"));
            //var techDataST = new TechData();
            
        }
    }
}
