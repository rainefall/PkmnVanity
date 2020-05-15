using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity.Items.Armour
{
    public class LillieHat : ModItem
    {

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }


        public override void SetDefaults()
        {
            item.name = "Lillie's Hat";
            item.width = 34;
            item.height = 16;
            item.rare = 1;
            item.vanity = true;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = true;
            base.DrawHair(ref drawHair, ref drawAltHair);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(86);
            recipe.SetResult(null, "LillieHat", 1);
            recipe.AddRecipe();
        }
    }
}