using Terraria;
using Terraria.ModLoader;
using PokemonVanity;

namespace PokemonVanity.Buffs
{
    public class FennekinPet : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[Type] = "Fennekin";
            Main.buffTip[Type] = "\"I knew before I even arrived!\"";
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<PokemonPlayer>(mod).fennekinPet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("FennekinPet")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("FennekinPet"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}