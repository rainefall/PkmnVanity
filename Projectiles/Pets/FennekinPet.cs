using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PokemonVanity.Projectiles.Pets
{
    public class FennekinPet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Bunny);
            projectile.name = "Fennekin Pet";
            aiType = ProjectileID.Bunny;
            drawOriginOffsetY -= 10;
            Main.projFrames[projectile.type] = 8;
            Main.projPet[projectile.type] = true;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.bunny = false; // Relic from aiType
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            PokemonPlayer modPlayer = player.GetModPlayer<PokemonPlayer>(mod);
            if (player.dead)
            {
                modPlayer.fennekinPet = false;
            }
            if (modPlayer.fennekinPet)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}