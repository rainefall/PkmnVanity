using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity.Items.Armour
{
    public class MoonHat : ModItem
    {

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }


        public override void SetDefaults()
        {
            item.name = "Moon's Hat";
            item.toolTip2 = "'So someone else went to glove world...'";
            item.width = 18;
            item.height = 16;
            item.rare = 1;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(86);
            recipe.SetResult(null, "MoonHat", 1);
            recipe.AddRecipe();
        }
    }
}