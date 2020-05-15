using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity.Items.Armour
{
    public class SunHat : ModItem
    {

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }


        public override void SetDefaults()
        {
            item.name = "Sun's Hat";
            item.toolTip2 = "'At least you can take it off.'";
            item.width = 22;
            item.height = 12;
            item.rare = 1;
            item.vanity = true;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(86);
            recipe.SetResult(null, "SunHat", 1);
            recipe.AddRecipe();
        }
    }
}