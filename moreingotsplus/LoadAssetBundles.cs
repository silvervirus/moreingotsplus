using System;
using UnityEngine;

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
                moreingots = AssetBundle.LoadFromFile(@"./QMods/moreingotsplus/Assets/moreingots.assets");
                Log.Debug("\"moreingots\" asset bundle loaded");
                Log.Debug("Loading asset bundles... (1/5)");
                ingotsplus = AssetBundle.LoadFromFile(@"./QMods/moreingotsplus/Assets/yenzen-ingotsplus.assets");
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
