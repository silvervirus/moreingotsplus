using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Utility;
using System;
using Harmony;
using UnityEngine;
using MoreIngotsplus.MI;
using Logger = Utilites.Logger.Logger;
using LogType = Utilites.Logger.LogType;
using LogLevel = Utilites.Logger.LogLevel;
using Utilites.Logger;
using Utilites.Config;
using System.Collections.Generic;
using System.Collections;

namespace MoreIngotsplus.MI
{
    /// <summary>
    /// Main class for loading the asset bundles
    /// </summary>
    public partial class Load

    {
        public static AssetBundle moreingots;
        public static AssetBundle ingotsplus;
        public static AssetBundle moreingots_salt;
        public static AssetBundle ingotsplus_salt;
        public static AssetBundle sulphur;
        /// <summary>
        /// Loads the asset bundles
        /// </summary>
        public static void AssetBundles()
        {
            try
            {
                Log.Debug("Loading asset bundles... (0/5)");
               var moreingots = AssetBundle.LoadFromFile(@"./QMods/moreingotsplus/Assets/moreingots.assets");
                Log.Debug("\"moreingots\" asset bundle loaded");
                Log.Debug("Loading asset bundles... (1/5)");
               var ingotsplus = AssetBundle.LoadFromFile(@"/QMods/moreingotsplus/Assets/yenzen-ingotsplus.assets");
                Log.Debug("\"yenzen-ingotsplus\" asset bundle loaded");
                Log.Debug("Loading asset bundles... (2/5)");
                moreingots_salt = AssetBundle.LoadFromFile(@"./QMods/moreingotsplus/Assets/salt-alexejheroytb.assets");
                Log.Debug("\"salt-alexejheroytb\" asset bundle loaded");
                Log.Debug("Loading asset bundles... (3/5)");
                ingotsplus_salt = AssetBundle.LoadFromFile(@"./QMods/moreingotsplus/Assets/salt-yenzen.assets");
                Log.Debug("\"salt-yenzen\" asset bundle loaded");
                Log.Debug("Loading asset bundles... (4/5)");
                sulphur = AssetBundle.LoadFromFile(@"./QMods/moreingotsplus/Assets/sulphur.assets");
                Log.Debug("\"sulphur\" asset bundle loaded");
                Log.Debug("Loading asset bundles... (5/5)");
                Log.Debug("Asset bundles loaded");
            }
            catch (Exception e)
            {
                Log.e(e);
            }
        }
    }
}
