using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Utility;

using System.Collections.Generic;
using UnityEngine;
using Utilites.Config;
using Logger = Utilites.Logger.Logger;
using LogType = Utilites.Logger.LogType;
using LogLevel = Utilites.Logger.LogLevel;
using System;
using Utilites.Logger;
using MoreIngots.MI;
using Harmony;
using System.Reflection;

namespace MoreIngots.MI
{
    /// <summary>
    /// Main class for loading the fabricator tabs
    /// </summary>
    public partial class Load
    {
        /// <summary>
        /// Loads the fabricator tabs
        /// </summary>
        public static void FabricatorTabs()
        {
            try
            {
                var spritetabcraft = moreingots.LoadAsset<Sprite>("MIFabTabCraft");
                var spritetabunpack = moreingots.LoadAsset<Sprite>("MIFabTabUnpack");
                var spritetabcraft2 = ingotsplus.LoadAsset<Sprite>("IPFabTabCraft");
                var spritetabunpack2 = ingotsplus.LoadAsset<Sprite>("IPFabTabUnpack");
                if (MI.Config._alttextures)
                {
                    MI.Log.Debug("Loading fabricator tabs with alternative sprites... (0/2)");
                    CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Craft MoreIngots", "pack", SpriteManager.Get(TechType.Titanium));
                    MI.Log.Debug("Loading fabricator tabs with alternative sprites... (1/2)");
                    CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Unpack MoreIngots", "unpack", SpriteManager.Get(TechType.Titanium));
                    MI.Log.Debug("Loading fabricator tabs with alternative sprites... (2/2)");
                    MI.Log.Debug("Fabricator tabs with alternative sprites loaded");
                }
                else
                {
                    MI.Log.Debug("Loading fabricator tabs... (0/2)");
                    CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Craft MoreIngots", "pack", SpriteManager.Get(TechType.Copper));
                    MI.Log.Debug("Loading fabricator tabs... (1/2)");
                    CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Unpack MoreIngots", "unpack", SpriteManager.Get(TechType.Titanium));
                    MI.Log.Debug("Loading fabricator tabs... (2/2)");
                    MI.Log.Debug("Fabricator tabs loaded");
                }
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
    }
}
