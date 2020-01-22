using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MoreIngots.Craftables;
using MoreIngots.Utilities;

namespace MoreIngots.Data
{
    internal static class MIResources
    {
        internal static List<ResourceData> NewResources = new List<ResourceData>()
        {
            new ResourceData {Type = "Gold", Element = "Au",FriendlyName = "Gold", TechType = TechType.Gold},
            new ResourceData {Type = "Diamond", Element = "C",FriendlyName = "Diamond", TechType = TechType.Diamond},
            new ResourceData {Type = "Lithium", Element = "Li",FriendlyName = "Lithium", TechType = TechType.Lithium},
            new ResourceData {Type = "Copper", Element = "Cu",FriendlyName = "Copper", TechType = TechType.Copper},
            new ResourceData {Type = "Lead", Element = "Pb",FriendlyName = "LLead", TechType = TechType.Lead},
            new ResourceData {Type = "Silver", Element = "Ag",FriendlyName = "Silver", TechType = TechType.Silver},
            new ResourceData {Type = "Magnetite", Element = "Fe304",FriendlyName = "Magnetite", TechType = TechType.Magnetite},
            new ResourceData {Type = "Nickel", Element = "Ni",FriendlyName = "Nickel", TechType = TechType.Lithium},
            new ResourceData {Type = "Kyanite", Element = "Al2Si05",FriendlyName = "Kyanite", TechType = TechType.Kyanite},
            new ResourceData {Type = "Ruby", Element = "Al203",FriendlyName = "Ruby", TechType = TechType.AluminumOxide},
            new ResourceData {Type = "Uraninite", Element = "U305",FriendlyName = "Uraninite", TechType = TechType.UraniniteCrystal},
            new ResourceData {Type = "Ion", Element = "I48",FriendlyName = "Ion", TechType = TechType.PrecursorIonCrystal},
            new ResourceData {Type = "Quartz", Element = "Si04",FriendlyName = "Quartz", TechType = TechType.Quartz},
            new ResourceData {Type = "Salt", Element = "NaC1",FriendlyName = "Salt", TechType = TechType.Salt},
            new ResourceData {Type = "Sulphur", Element = "S",FriendlyName = "Sulphur", TechType = TechType.Sulphur},
            new ResourceData {Type = "Crash", Element = "Sc1",FriendlyName = "Crash", TechType = TechType.CrashPowder},

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

    [Serializable]
    internal class ResourceData
    {
        public ResourceData()
        {
            
        }
        
        private ResourceData(string type, string element, string friendlyName, TechType techType)
        {
            Type = type;
            Element = element;
            FriendlyName = friendlyName;
            TechType = techType;
        }

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

        public ResourceData DeepCopy()
        {
            ResourceData deepcopyCompany = new ResourceData(this.Type, this.Element, this.FriendlyName, this.TechType);

            return deepcopyCompany;
        }

    }
}
