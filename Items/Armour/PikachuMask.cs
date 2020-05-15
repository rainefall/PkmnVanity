using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity.Items.Armour
{
    public class PikachuMask : ModItem
    {


        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }


        public override void SetDefaults()
        {
            item.name = "Pikachu Mask";
            item.toolTip2 = "'what is this spriting?'";
            item.width = 28;
            item.height = 24;
            item.rare = 1;
            item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.Ruby, 2);
            recipe.AddTile(86);
            recipe.SetResult(null, "PikachuMask", 1);
            recipe.AddRecipe();
        }
    }
}