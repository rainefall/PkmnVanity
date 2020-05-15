using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity.Items.Armour
{
    public class LucarioTorso : ModItem
    {
        public readonly Mod pkmnvanity;

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }


        public override void SetDefaults()
        {
            item.name = "Lucario Costume Torso";
            AddTooltip2("'Lucarionite Sold Separately.'");
            item.width = 80;
            item.height = 30;
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
            recipe.AddIngredient(ItemID.Silk, 20);
            recipe.AddIngredient(ItemID.IronBar, 3);
            recipe.AddTile(86);
            recipe.SetResult(null, "LucarioTorso", 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 20);
            recipe.AddIngredient(ItemID.LeadBar, 3);
            recipe.AddTile(86);
            recipe.SetResult(null, "LucarioTorso", 1);
            recipe.AddRecipe();
        }
    }
}