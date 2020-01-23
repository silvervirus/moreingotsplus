using System;
using System.Collections.Generic;
using System.Linq;
using MoreIngots.Configuration;
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
    internal class DecompressedItemBulk : Craftable
    {
        private readonly GameObject _ingotPrefab;
        private TechType _fromTechType;
        private TechType _toTechType;
        private string[] _stepsToFabricator;
        private string _type;

        public override TechGroup GroupForPDA => TechGroup.Resources;
        public override TechCategory CategoryForPDA => TechCategory.AdvancedMaterials;
        public override string AssetsFolder => Mod.ModAssetFolder;
        public override string IconFileName { get; }
        public override string[] StepsToFabricatorTab => _stepsToFabricator;
        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;


        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="fromTechType"></param>
        /// <param name="toTechType"></param>
        public DecompressedItemBulk(TechType fromTechType, TechType toTechType, string type, string[] stepsToFabricator,string suffix) : base($"{suffix}{toTechType}", $"Unpacked {type} Ingots", $"Unpacks {type}. Added by the MoreIngots mod")
        {
            _ingotPrefab = CraftData.GetPrefabForTechType(toTechType);
            
            _fromTechType = fromTechType;

            _toTechType = toTechType;

            _stepsToFabricator = stepsToFabricator;
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
                craftAmount = 0,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient(_fromTechType, 5)
                },
                LinkedItems = CreateLinkedItemsList().ToList()
            };

            return techData;
        }

        IEnumerable<TechType> CreateLinkedItemsList()
        {
            for (int i = 0; i < 48; i++)
            {
                yield return _toTechType;
            }
        }
        
        protected override Atlas.Sprite GetItemSprite()
        {
            return SpriteManager.Get(_toTechType);
        }
    }
}
