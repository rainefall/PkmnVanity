using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity.Items.Armour
{
	public class SerenaHat : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }


        public override void SetDefaults()
		{
			item.name = "Serena's Hat";
            AddTooltip2("'I just chose the one you didn't like...'");
			item.width = 28;
			item.height = 14;
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
            recipe.AddIngredient(ItemID.Goggles, 1);
            recipe.AddTile(86);
            recipe.SetResult(null, "SerenaHat", 1);
            recipe.AddRecipe();
        }
    }
}