using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity.Items.Armour
{
    public class SerenaOutfit : ModItem
    {
        public readonly Mod pkmnvanity;

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }


        public override void SetDefaults()
        {
            item.name = "Serena's Outfit";
            AddTooltip2("'Imported from Kalos'");
            item.width = 22;
            item.height = 26;
            item.rare = 1;
            item.vanity = true;
        }

        public override bool DrawBody()
        {
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 25);
            recipe.AddTile(86);
            recipe.SetResult(null, "SerenaOutfit", 1);
            recipe.AddRecipe();
        }
    }
}
