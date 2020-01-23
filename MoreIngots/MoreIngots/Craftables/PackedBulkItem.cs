using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MoreIngots.Configuration;
using MoreIngots.Data;
using MoreIngots.Utilities;
using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using UnityEngine;

namespace MoreIngots.Craftables
{
    /// <summary>
    /// A class that represents a resource in the MoreIngots Mod this class inherits <see cref="Craftable"/> to make it easier to add craftable items to the game.
    /// </summary>
    [Serializable]
    internal class PackedbulkItem : Craftable
    {
        private readonly GameObject _ingotPrefab;
        private ResourceData _resourceData;

        public override TechGroup GroupForPDA => TechGroup.Resources;
        public override TechCategory CategoryForPDA => TechCategory.AdvancedMaterials;
        public override string AssetsFolder => Mod.ModAssetFolder;
        public override string IconFileName { get; }
        public override string[] StepsToFabricatorTab => new[] {"BI", "BIPack" };
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;


        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <param name="resoureData">The data that has all information needed to create a new resource</param>
        public PackedbulkItem(ResourceData resoureData) : base($"MIP{resoureData.Type}", $"packedBulk {resoureData.FriendlyName}", $"{resoureData.Element}. packed {resoureData.FriendlyName}. Added by the MoreIngots mod")
        {
            _ingotPrefab = CraftData.GetPrefabForTechType(TechType.PlasteelIngot);
            
            //Set icon Name;
            IconFileName = $"MI{resoureData.Type}.png";

            _resourceData = resoureData;
        }

        /// <summary>
        /// The object that will be used show the crafted item
        /// </summary>
        /// <returns></returns>
        public override GameObject GetGameObject()
        {
            // Lets try create the GameObject if it fails return null and  log a message
            try
            {
                //Make a copy of the Titanium Ingot model
                var prefab = GameObject.Instantiate(_ingotPrefab);

                //Set the prefab name of the prefab
                prefab.name = this.PrefabFileName;

                return prefab;

            }
            catch (Exception e)
            {
               QuickLogger.Error(e.Message);
               return null;
            }
        }

        /// <summary>
        /// The blue print recipe that will be used to craft this item
        /// </summary>
        /// <returns></returns>
        protected override TechData GetBlueprintRecipe()
        {
            var techData = new TechData()
            {
                craftAmount = 5,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient(_resourceData.TechType, 48)
                }
            };

            return techData;
        }
    }
}
