using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity.Items.Armour
{
    public class LucarioLegs : ModItem
    {
        public readonly Mod pkmnvanity;

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }


        public override void SetDefaults()
        {
            item.name = "Lucario Costume Legs";
            AddTooltip2("'Tail not included.'");
            item.width = 88;
            item.height = 52;
            item.rare = 1;
            item.vanity = true;
        }

        public override bool DrawBody()
        {
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddTile(86);
            recipe.SetResult(null, "LucarioLegs", 1);
            recipe.AddRecipe();
        }
    }
}