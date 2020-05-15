using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity.Items.Placeable
{
    public class StarterBench : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Starter Bench";
            item.width = 30;
            item.height = 22;
            item.maxStack = 99;
            AddTooltip2("The hardest decision of your childhood.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 150;
            item.createTile = mod.TileType("StarterBench");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.Glass, 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeadBar, 10);
            recipe.AddIngredient(ItemID.Glass, 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}