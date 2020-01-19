using SMLHelper.V2.Handlers;
using System;

namespace MoreIngotsplus.MI
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
                
                if (MI.Config._alttextures)
                {
                    MI.Log.Debug("Loading fabricator tabs with alternative sprites... (0/2)");
                    CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Craft", "Pack", SpriteManager.Get(TechType.Titanium));
                    MI.Log.Debug("Loading fabricator tabs with alternative sprites... (1/2)");
                    CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Unpack", "Unpack", SpriteManager.Get(TechType.PlasteelIngot));
                    MI.Log.Debug("Loading fabricator tabs with alternative sprites... (2/2)");
                    MI.Log.Debug("Fabricator tabs with alternative sprites loaded");
                }

            }
            catch (Exception e)
            {
                Log.e(e);
            }
            try
            {
                MI.Log.Debug("Loading fabricator tabs... (0/2)");
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Craft", "Pack", SpriteManager.Get(TechType.TitaniumIngot));
                MI.Log.Debug("Loading fabricator tabs... (1/2)");
                CraftTreeHandler.AddTabNode(CraftTree.Type.Fabricator, "Unpack", "Unpack", SpriteManager.Get(TechType.Copper));
                MI.Log.Debug("Loading fabricator tabs... (2/2)");
                MI.Log.Debug("Fabricator tabs loaded");
            }
            catch (Exception E)
            {
                Log.e(E);
            }
        }
    }
}