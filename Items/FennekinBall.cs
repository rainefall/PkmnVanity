using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity.Items
{
    public class FennekinBall : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Carrot);
            item.name = "Pokeball";
            item.toolTip = "Contains a Fennekin";
            item.shoot = mod.ProjectileType("FennekinPet");
            item.buffType = mod.BuffType("FennekinPet");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Acorn, 1);
            recipe.AddIngredient(ItemID.Fireblossom, 1);
            recipe.AddTile(null, "StarterBench");
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Acorn, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddTile(null, "StarterBench");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}