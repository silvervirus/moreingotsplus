using System;
using System.IO;


namespace MoreIngots.Configuration
{
    internal static class Mod
    {
        /// <summary>
        /// The ClassID of the mod
        /// </summary>
        internal const string ModName = "MoreIngots";
        
        internal static string ModAssetFolder = Path.Combine(ModName,"Assets");
        internal static string GetAssetFolder()
        {
            return Path.Combine(GetModPath(), "Assets");
        }
        private static string GetModPath()
        {
            return Path.Combine(GetQModsPath(), ModName);
        }
        private static string GetQModsPath()
        {
            return Path.Combine(Environment.CurrentDirectory, "QMods");
        }
    }
}
