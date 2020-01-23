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
                //Create the root node for the fabricator
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MI", "More Ingots", SpriteManager.Get(TechType.TitaniumIngot));
                //Create the root node for the fabricator
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "BI", "Bulk", SpriteManager.Get(TechType.TitaniumIngot));
                //Lets create the fabricator entry for metallic packing and add it to the parent root MI
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIPack", "Metallic Packing", SpriteManager.Get(TechType.Copper), "MI");
                //Lets create the fabricator entry for metallic packing and add it to the parent root MI
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "BIPack", "Metallic Packing", SpriteManager.Get(TechType.Copper), "BI");
                //Lets create the fabricator entry for metallic stacking and add it to the parent root MI
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIStack", "Metallic Stacking", SpriteManager.Get(TechType.Titanium),"MI");
                //Lets create the fabricator entry for metallic stacking and add it to the parent root MI
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "BIStack", "Metallic Stacking Bulk", SpriteManager.Get(TechType.Titanium), "BI");

                //Lets create the fabricator entry for metallic packing and add it to the parent root MI
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnPack", "Metallic UnPacking", SpriteManager.Get(TechType.Copper), "MI");
                //Lets create the fabricator entry for metallic packing and add it to the parent root MI
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "BIUnPack", "Metallic UnPacking Bulk", SpriteManager.Get(TechType.Copper), "BI");
                //Lets create the fabricator entry for metallic packing and add it to the parent root MI
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIUnStack", "Metallic UnStacking", SpriteManager.Get(TechType.Diamond), "MI");
                //Lets create the fabricator entry for metallic packing and add it to the parent root MI
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "BIUnStack", "Metallic UnStacking Bulk", SpriteManager.Get(TechType.Diamond), "BI");
                //Lets create and add the resources to the fabricator
                MIResources.CreateResources();
            }
            catch (Exception e)
            {
                QuickLogger.Error(e);
            }
        }
    }
}
