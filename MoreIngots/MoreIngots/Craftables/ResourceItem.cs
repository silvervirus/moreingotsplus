using System;
using System.Collections.Generic;
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
    internal class ResourceItem : Craftable
    {
        private readonly GameObject _ingotPrefab;
        private readonly ResourceData _resourceData;

        public override TechGroup GroupForPDA => TechGroup.Resources;
        public override TechCategory CategoryForPDA => TechCategory.AdvancedMaterials;
        public override string AssetsFolder => Mod.ModAssetFolder;
        public override string IconFileName { get; }
        public override string[] StepsToFabricatorTab => new[] { "MI","MIPack"};
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;


        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="resourceKey"></param>
        /// <param name="resoureData">The data that has all information needed to create a new resource</param>
        public ResourceItem(ResourceData resoureData) : base($"MI{resoureData.Type}", $"Packed {resoureData.FriendlyName}", $"{resoureData.Element}. Compressed {resoureData.FriendlyName}. Added by the MoreIngots mod")
        {
            _ingotPrefab = CraftData.GetPrefabForTechType(TechType.TitaniumIngot);
            
            //Set icon Name;
            IconFileName = $"MI{resoureData.Type}.png";

            _resourceData = resoureData;

            //When this object has finished patching to the game create a stack variant of it
            OnFinishedPatching += () =>
            {
                var customResourceData = resoureData.DeepCopy();
                customResourceData.TechType = this.TechType;
                var stacked = new StackedItem(customResourceData);
                stacked.Patch();

                var unpacked = new DecompressedItem(TechType, _resourceData.TechType, resoureData.Type, new[] { "MI", "MIUnPack" },"MIPU");
                unpacked.Patch();
                
                var unStack = new DecompressedItem(stacked.TechType, TechType, resoureData.Type, new[] { "MI", "MIUnStack"},"MISU");
                unStack.Patch();
            };
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
                craftAmount = 1,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient(_resourceData.TechType, 10)
                }
            };

            return techData;
        }


    }
}
