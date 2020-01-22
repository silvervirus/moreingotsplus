﻿using MoreIngots.Data;
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


                //Lets create the fabricator entry for metallic packing and add it to the parent root MI
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIPack", "Metallic Packing", SpriteManager.Get(TechType.Copper), "MI");

                //Lets create the fabricator entry for metallic stacking and add it to the parent root MI
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "MIStack", "Metallic Stacking", SpriteManager.Get(TechType.Titanium),"MI");
                
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
