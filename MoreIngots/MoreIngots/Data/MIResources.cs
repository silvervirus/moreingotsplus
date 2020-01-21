using System.Collections.Generic;
using MoreIngots.Craftables;
using MoreIngots.Utilities;

namespace MoreIngots.Data
{
    internal static class MIResources
    {
        internal static List<ResourceData> NewResources = new List<ResourceData>()
        {
            {new ResourceData {Type = "Gold", Element = "Au",FriendlyName = "Gold", TechType = TechType.Gold}},
            {new ResourceData {Type = "Diamond", Element = "C",FriendlyName = "Diamond", TechType = TechType.Diamond}},
            {new ResourceData {Type = "Lithium", Element = "Li",FriendlyName = "Lithium", TechType = TechType.Lithium}},
        };
        internal static void CreateResources()
        {
            foreach (var resource in NewResources)
            {
                var newResourceCraftable = new ResourceItem(resource);
                newResourceCraftable.Patch();
                QuickLogger.Info($"Added new resource {resource.Type}");
            }
        }
    }

    internal class ResourceData
    {
        public string Type { get; set; }
        /// <summary>
        /// The Element of the resource [NOTE: Will be used in the name of the icon and class name].
        /// </summary>
        public string Element { get; set; }
        /// <summary>
        /// Friendly name of the resource [NOTE: Will be used in the description of the mod]
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// The TechType corresponding to the resource [NOTE: Will be used in the ingredients of the mod]
        /// </summary>
        public TechType TechType { get; set; }

    }
}
